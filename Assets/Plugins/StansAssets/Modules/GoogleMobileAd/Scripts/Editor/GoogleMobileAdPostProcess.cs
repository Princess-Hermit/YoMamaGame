//#define CODE_DISABLED
#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using System.Collections;

public class GoogleMobileAdPostProcess  {
	

	[PostProcessBuild(49)]
	public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject) {


		#if UNITY_IPHONE && !CODE_DISABLED
		SA.IOSDeploy.ISD_Settings.Instance.AddFramework(SA.IOSDeploy.iOSFramework.StoreKit);
		SA.IOSDeploy.ISD_Settings.Instance.AddFramework(SA.IOSDeploy.iOSFramework.CoreTelephony);
		SA.IOSDeploy.ISD_Settings.Instance.AddFramework(SA.IOSDeploy.iOSFramework.AdSupport);
		SA.IOSDeploy.ISD_Settings.Instance.AddFramework(SA.IOSDeploy.iOSFramework.MessageUI);
		SA.IOSDeploy.ISD_Settings.Instance.AddFramework(SA.IOSDeploy.iOSFramework.EventKit);
		SA.IOSDeploy.ISD_Settings.Instance.AddFramework(SA.IOSDeploy.iOSFramework.EventKitUI);

		SA.IOSDeploy.ISD_Settings.Instance.AddLinkerFlag("-ObjC");

		#endif
	}

}
#endif
