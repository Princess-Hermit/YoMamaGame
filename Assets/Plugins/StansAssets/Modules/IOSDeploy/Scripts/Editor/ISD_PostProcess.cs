﻿////////////////////////////////////////////////////////////////////////////////
//  
// @module IOS Deploy
// @author Stanislav Osipov (Stan's Assets) 
// @support support@stansassets.com
//
////////////////////////////////////////////////////////////////////////////////

#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.Collections;
using System.Diagnostics;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System;

namespace SA.IOSDeploy {

	public class PostProcess  {

		[PostProcessBuild(100)]
		public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject) {

			#if !UNITY_IPHONE
				return;
			#endif




			#if UNITY_IPHONE &&  UNITY_EDITOR_WIN
			UnityEngine.Debug.LogWarning("ISD Postprocess is not avaliable for Win");
			#endif


			#if UNITY_IPHONE && UNITY_EDITOR_OSX


			UnityEngine.Debug.Log("SA.IOSDeploy.PostProcess Started");

			Process myCustomProcess = new Process();		
			myCustomProcess.StartInfo.FileName = "python";

			List<string> frmwrkWithOpt = new List<string>();

			List<string> embededFrameworkds = new List<string>();

			foreach(Framework framework in ISD_Settings.Instance.Frameworks){
				string optional = "|0";
				if(framework.IsOptional){
					optional = "|1";
				}
				if(framework.IsEmbeded){
					embededFrameworkds.Add(framework.Name);
				}
				frmwrkWithOpt.Add(framework.Name + optional);

			}




			List<string> libWithOpt = new List<string>();

			foreach(Lib lib in ISD_Settings.Instance.Libraries) { 
				string optional = "|0";
				if(lib.IsOptional) {
					optional = "|1";
				}

				libWithOpt.Add (lib.Name + optional);
			}




			foreach(string fileName in ISD_Settings.Instance.langFolders)
			{
				string tempPath = Path.Combine (pathToBuiltProject, fileName + ".lproj");
				if(!Directory.Exists (tempPath))
				{
					Directory.CreateDirectory (tempPath);
				}
			}


			List<string> LinkerFlags = new List<string>();
			List<string> CompileFlags = new List<string>();
			foreach(Flag flag in ISD_Settings.Instance.Flags){
				if(flag.Type.Equals(FlagType.LinkerFlag)){
					LinkerFlags.Add(flag.Name);
				}else if(flag.Type.Equals(FlagType.CompilerFlag)){
					CompileFlags.Add(flag.Name);
				}
			}


			string frameworks 		= string.Join(" ", frmwrkWithOpt.ToArray());
			string libraries 		= string.Join(" ", libWithOpt.ToArray());
			string linkFlags 		= string.Join(" ", LinkerFlags.ToArray());
			string compileFlags 	= string.Join(" ", CompileFlags.ToArray());
			string languageFolders  = string.Join (" ", ISD_Settings.Instance.langFolders.ToArray ());


			#if UNITY_5

			if(BuildTarget.iOS == target){
				UnityEditor.iOS.Xcode.PBXProject proj = new UnityEditor.iOS.Xcode.PBXProject();
				string projPath = Path.Combine(pathToBuiltProject, "Unity-iPhone.xcodeproj/project.pbxproj");
				proj.ReadFromString(File.ReadAllText(projPath));
				string targetGUID = proj.TargetGuidByName("Unity-iPhone");
				if(ISD_Settings.Instance.enableBitCode){
					proj.SetBuildProperty(targetGUID, "ENABLE_BITCODE", "YES");
				}else{
					proj.SetBuildProperty(targetGUID, "ENABLE_BITCODE", "NO");
				}
				if(ISD_Settings.Instance.enableTestability){
					proj.SetBuildProperty(targetGUID, "ENABLE_TESTABILITY", "YES");
				}else{
					proj.SetBuildProperty(targetGUID, "ENABLE_TESTABILITY", "NO");
				}
				if(ISD_Settings.Instance.generateProfilingCode){
					proj.SetBuildProperty(targetGUID, "GENERATE_PROFILING_CODE", "YES");
				}else{
					proj.SetBuildProperty(targetGUID, "GENERATE_PROFILING_CODE", "NO");
				}

				File.WriteAllText(projPath, proj.WriteToString());
			}

			#endif


			myCustomProcess.StartInfo.Arguments = string.Format("Assets/" + SA.Common.Config.MODULS_PATH + "IOSDeploy/Scripts/Editor/post_process.py \"{0}\" \"{1}\" \"{2}\" \"{3}\" \"{4}\" \"{5}\"", new object[] { pathToBuiltProject, frameworks, libraries, compileFlags, linkFlags, languageFolders });
			myCustomProcess.StartInfo.UseShellExecute = false;
			myCustomProcess.StartInfo.RedirectStandardOutput = true;
			myCustomProcess.Start(); 
			myCustomProcess.WaitForExit();

			XmlDocument document = new XmlDocument();
			string filePath = Path.Combine (pathToBuiltProject, "Info.plist");
			document.Load (filePath);
			document.PreserveWhitespace = true;


			foreach(Variable var in ISD_Settings.Instance.PlistVariables)	{
			//	XmlNode temp = document.SelectSingleNode( "/plist/dict/key[text() = '" + var.Name + "']" );
			//	if(temp == null)	{
					XmlNode valNode = null;
					switch(var.Type)	{
					case PlistValueTypes.Array:
						valNode = document.CreateElement("array");
						AddArrayToPlist(var, valNode, document);
						break;

					case PlistValueTypes.Boolean:
						valNode = document.CreateElement(var.BooleanValue.ToString ().ToLower ());
						break;

					case PlistValueTypes.Dictionary:
						valNode = document.CreateElement("dict");
						AddDictionaryToPlist(var, valNode, document);
						break;

					case PlistValueTypes.Float:
						valNode = document.CreateElement("real");
						valNode.InnerText = var.FloatValue.ToString ();
						break;

					case PlistValueTypes.Integer:
						valNode = document.CreateElement("integer");
						valNode.InnerText = var.IntegerValue.ToString ();
						break;

					case PlistValueTypes.String:
						valNode = document.CreateElement("string");
						valNode.InnerText = var.StringValue;
						break;
					}
					XmlNode keyNode = document.CreateElement ("key");
					keyNode.InnerText = var.Name;
					document.DocumentElement.FirstChild.AppendChild (keyNode);
					document.DocumentElement.FirstChild.AppendChild (valNode);
				//}
			}


			XmlWriterSettings settings  = new XmlWriterSettings {
				Indent = true,
				IndentChars = "\t",
				NewLineHandling = NewLineHandling.None
			};
			XmlWriter xmlwriter = XmlWriter.Create (filePath, settings );
			document.Save (xmlwriter);
			xmlwriter.Close ();

			System.IO.StreamReader reader = new System.IO.StreamReader(filePath);
			string textPlist = reader.ReadToEnd();
			reader.Close ();

			//strip extra indentation (not really necessary)
			textPlist = (new Regex("^\\t",RegexOptions.Multiline)).Replace(textPlist,"");

			//strip whitespace from booleans (not really necessary)
			textPlist = (new Regex("<(true|false) />",RegexOptions.IgnoreCase)).Replace(textPlist,"<$1/>");

			int fixupStart = textPlist.IndexOf("<!DOCTYPE plist PUBLIC");


			if(fixupStart >= 0) {
				int fixupEnd = textPlist.IndexOf('>', fixupStart);
				if(fixupEnd >= 0) {
					string fixedPlist = textPlist.Substring(0, fixupStart);
					fixedPlist += "<!DOCTYPE plist PUBLIC \"-//Apple//DTD PLIST 1.0//EN\" \"http://www.apple.com/DTDs/PropertyList-1.0.dtd\">";
					fixedPlist += textPlist.Substring(fixupEnd+1);

					textPlist = fixedPlist;
				}
			}



			System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath, false);
			writer.Write(textPlist);
			writer.Close ();

			UnityEditor.XCodeEditor.XCProject project = new UnityEditor.XCodeEditor.XCProject(pathToBuiltProject);
			foreach(string s in embededFrameworkds){
				project.AddEmbedFramework(s);
			}
//			foreach(Lib lib in ISD_Settings.Instance.Libraries) { 
//				string optional = "|0";
//				if(lib.IsOptional) {
//					optional = "|1";
//				}
//				project.AddFile( completeLibPath, modGroup, "SDKROOT", true, lib.IsOptional );
//				//libWithOpt.Add (lib.Name + optional);
//			}

			project.Save();

			UnityEngine.Debug.Log("SA.IOSDeploy.PostProcess Finished.");
			#endif
		}

		static void AddArrayToPlist (Variable var, XmlNode node, XmlDocument doc)
		{

			if (var.ChildrensIds.Count == 0) {
				return;
			} else {
				foreach(string variableUniqueIdKey in var.ChildrensIds){
					Variable v = ISD_Settings.Instance.getVariableByKey (variableUniqueIdKey);
					AddElementToPlist (var, v, node, doc, true, false);
				}
			}
		}

		static void AddDictionaryToPlist (Variable var, XmlNode node, XmlDocument docc)
		{
			if (var.ChildrensIds.Count > 0) {
				XmlDocument doc = docc;
				foreach(string variableUniqueIdKey in var.ChildrensIds){
					Variable v = ISD_Settings.Instance.getVariableByKey (variableUniqueIdKey);
					AddElementToPlist (var, v, node, doc, false ,true);
				}
			} 
			else {
				//Draw Simple values
				if (var.ChildrensIds.Count == 0)
					return;
				foreach(string variableUniqueIdKey in var.ChildrensIds){
					Variable varDict = ISD_Settings.Instance.getVariableByKey (variableUniqueIdKey);
					AddElementToPlist (var, varDict, node, docc, true, true);
				}
			}
		}

		static void AddElementToPlist(Variable mainVariable, Variable v, XmlNode node, XmlDocument document, bool useMainVarName , bool isDictionary){
			XmlNode valNode = null;
			switch(v.Type)	{
			case PlistValueTypes.Array:
				valNode = document.CreateElement("array");
				AddArrayToPlist(v, valNode, document);
				break;

			case PlistValueTypes.Boolean:
				valNode = document.CreateElement(v.BooleanValue.ToString ().ToLower ());
				break;

			case PlistValueTypes.Dictionary:
				valNode = document.CreateElement("dict");
				AddDictionaryToPlist(v, valNode, document);
				break;

			case PlistValueTypes.Float:
				valNode = document.CreateElement("real");
				valNode.InnerText = v.FloatValue.ToString ();
				break;

			case PlistValueTypes.Integer:
				valNode = document.CreateElement("integer");
				valNode.InnerText = v.IntegerValue.ToString ();
				break;

			case PlistValueTypes.String:
				valNode = document.CreateElement("string");
				valNode.InnerText = v.StringValue;
				break;
			}

			XmlNode keyNode = document.CreateElement ("key");
			if (useMainVarName) {
				keyNode.InnerText = mainVariable.Name;
			} else {
				keyNode.InnerText = v.Name;
			}
			if (isDictionary) {
				node.AppendChild (keyNode);
			} 
			node.AppendChild (valNode);
		}


	}

}

#endif