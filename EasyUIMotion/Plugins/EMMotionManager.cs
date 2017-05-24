using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent (typeof(AudioSource))]
public class EMMotionManager : EMSingleton<EMMotionManager> {

	private  Dictionary<string,EMSimpleMotion> simpleMotions = new Dictionary<string,EMSimpleMotion>();
	private  Dictionary<string,EMOpenCloseMotion> openCloseMotions = new Dictionary<string,EMOpenCloseMotion>();
	
	private static EMSimpleMotion simpleMotion;
	private static EMOpenCloseMotion openCloseMotion;
	
	public void RegisterMotion(EMBaseMotion mo){
		
		
		if (mo.GetType() == typeof(EMSimpleMotion) ){
			if (simpleMotions.ContainsKey( (mo as EMSimpleMotion).motionName) ){
				Debug.LogWarning("Motion manager: on " + mo.gameObject.name + " "  + (mo as EMSimpleMotion).motionName + "motion name is already exists");
			}
			else{
				simpleMotions.Add( (mo as EMSimpleMotion).motionName,(mo as EMSimpleMotion));
			}
		}
		
		if (mo.GetType() == typeof(EMOpenCloseMotion) ){
			
			if (openCloseMotions.ContainsKey( (mo as EMOpenCloseMotion).motionName) ){
				Debug.LogWarning("Motion manager: on " + mo.gameObject.name + " "  + (mo as EMOpenCloseMotion).motionName + "motion name is already exists");
			}
			else{
				openCloseMotions.Add( (mo as EMOpenCloseMotion).motionName,(mo as EMOpenCloseMotion));
			}
		}
		
	}
	
	public void UnRegisterMotion( EMBaseMotion mo){
		
		if (mo.GetType() == typeof(EMSimpleMotion) ){
			simpleMotions.Remove( (mo as EMSimpleMotion).motionName);
		}
		
		if (mo.GetType() == typeof(EMOpenCloseMotion) ){
			openCloseMotions.Remove( (mo as EMOpenCloseMotion).motionName);
		}
	}


	public static void PlayMotion(string motionName){
		if (EMMotionManager.instance.simpleMotions.TryGetValue( motionName, out simpleMotion)){
			simpleMotion.PlayMotion();
		}
		else{
			Debug.LogWarning("Motion manager: " + motionName + " doesn't exist");
		}
	}
	
	public static void RewindMotion(string motionName){
		if (EMMotionManager.instance.simpleMotions.TryGetValue( motionName, out simpleMotion)){
			simpleMotion.RewindMotion();
		}
		else{
			Debug.LogWarning("Motion manager: " + motionName + " doesn't exist");
		}
	}

	public static void ResetSimpleMotion(string motionName){
		if (EMMotionManager.instance.simpleMotions.TryGetValue( motionName, out simpleMotion)){
			simpleMotion.Reset();
		}
		else{
			Debug.LogWarning("Motion manager: " + motionName + " doesn't exist");
		}
	}


	public static void Open(string motionName){
		if (EMMotionManager.instance.openCloseMotions.TryGetValue( motionName, out openCloseMotion)){
			openCloseMotion.Open();
		}
		else{
			Debug.LogWarning("Motion manager: " + motionName + " doesn't exist");
		}
	}
	
	public static void Close(string motionName){
		if (EMMotionManager.instance.openCloseMotions.TryGetValue( motionName, out openCloseMotion)){
			openCloseMotion.Close();
		}
		else{
			Debug.LogWarning("Motion manager: " + motionName + " doesn't exist");
		}
	}


	public static void ShowUIElement( string motionName){
		if (EMMotionManager.instance.simpleMotions.TryGetValue( motionName, out simpleMotion)){
			simpleMotion.showUIElement();
		}
		else if (EMMotionManager.instance.openCloseMotions.TryGetValue( motionName, out openCloseMotion)){
			openCloseMotion.showUIElement();
		}
	}

	public static void HideUIElement( string motionName){
		if (EMMotionManager.instance.simpleMotions.TryGetValue( motionName, out simpleMotion)){
			simpleMotion.HideUIElement();
		}
		else if (EMMotionManager.instance.openCloseMotions.TryGetValue( motionName, out openCloseMotion)){
			openCloseMotion.HideUIElement();
		}
	}

	public static void EnableUIElement(string motionName){
		if (EMMotionManager.instance.simpleMotions.TryGetValue( motionName, out simpleMotion)){
			simpleMotion.EnableUIElement();
		}
		else if (EMMotionManager.instance.openCloseMotions.TryGetValue( motionName, out openCloseMotion)){
			openCloseMotion.EnableUIElement();
		}
	}

	public static void DisableUIElement(string motionName){
		if (EMMotionManager.instance.simpleMotions.TryGetValue( motionName, out simpleMotion)){
			simpleMotion.DisableUIElement();
		}
		else if (EMMotionManager.instance.openCloseMotions.TryGetValue( motionName, out openCloseMotion)){
			openCloseMotion.DisableUIElement();
		}
	}


	public static void SetStateToOpen(string motionName){
		if (EMMotionManager.instance.openCloseMotions.TryGetValue( motionName, out openCloseMotion)){
			openCloseMotion.SetStateToOpen();
		}
	}

	public static void SetStateToClose(string motionName){
		if (EMMotionManager.instance.openCloseMotions.TryGetValue( motionName, out openCloseMotion)){
			openCloseMotion.SetStateToClose();
		}
	}

	public static EMBaseMotion.MotionState GetState( string motionName){
		if (EMMotionManager.instance.simpleMotions.TryGetValue( motionName, out simpleMotion)){
			return simpleMotion.motionState;
		}
		else if (EMMotionManager.instance.openCloseMotions.TryGetValue( motionName, out openCloseMotion)){
			return openCloseMotion.motionState;
		}
		else
			return EMBaseMotion.MotionState.Closed;

	}

	public static void PlaySound(AudioClip clip, float volume){
		instance.GetComponent<AudioSource>().PlayOneShot(clip,volume);	
	}


}
