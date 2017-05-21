using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

[AddComponentMenu("UI/Effects/Simple Motion")]
[System.Serializable]
public class EMSimpleMotion : EMBaseMotion {

	#region Unity Events
	[System.Serializable] public class OnPlayStartHandler : UnityEvent<string>{}
	[System.Serializable] public class OnPlayEndHandler : UnityEvent<string>{}
	[System.Serializable] public class OnRewindStartHandler : UnityEvent<string>{}
	[System.Serializable] public class OnRewindEndHandler : UnityEvent<string>{}
	
	
	[SerializeField] public OnPlayStartHandler onPlayStart;
	[SerializeField] public OnPlayEndHandler onPlayEnd;
	[SerializeField] public OnRewindStartHandler onRewindStart;
	[SerializeField] public OnRewindEndHandler onRewindEnd;
	#endregion
	
	public EMMotionProperties simpleProp;
	public bool playSoundRewind;

	public bool showMotionInspector;
	public bool showEventInspector;


	#region Constructor
	public EMSimpleMotion(){
		
		isShuttingDown = false;
		simpleProp = new EMMotionProperties( EMMotionProperties.MotionType.OneShot);
		playSoundRewind = false;

	}
	#endregion

	#region Monobehaviour Callback
	void Start(){

		if (!cachedCanvasScaler){
			DoAwake();
		}

		motionState = MotionState.Closed;
	}

	#endregion

	#region Motion
	public void PlayMotion(string motionName){
		SendMessage( "PlayMotionByName",motionName,SendMessageOptions.DontRequireReceiver);
	}

	private void PlayMotionByName(string motionName){
		if (this.motionName == motionName)
			PlayMotion();
	}

	public void PlayMotion(){

		if (motionState == MotionState.Closed){
			currentProp = simpleProp;
			currentProp.motionType = EMMotionProperties.MotionType.OneShot;
			LaunchMotionSequence( simpleProp,true,false);
		}

	}


	public void RewindMotion(string motionName){
		SendMessage( "RewindMotionByName",motionName,SendMessageOptions.DontRequireReceiver);
	}

	private void RewindMotionByName(string motionName){
		if (this.motionName == motionName)
			RewindMotion();
	}

	public void RewindMotion(){

		if ( motionState == MotionState.Open){
			currentProp = simpleProp;
			currentProp.motionType = EMMotionProperties.MotionType.OneShotRewind;
			LaunchMotionSequence( simpleProp,true,true);
		}
	}


	public void Reset(string motionName){
		SendMessage( "ResetByName",motionName,SendMessageOptions.DontRequireReceiver);
	}

	private void ResetByName(string motionName){
		if (this.motionName == motionName)
			Reset();
	}

	public void Reset(){
		motionState = MotionState.Closed;
	}
	#endregion

	#region Motion CallBack
	protected override void On_StartMotion(string id){
		if (id == motionId){
			if (currentProp.motionType == EMMotionProperties.MotionType.OneShot){
				if (motionState != MotionState.Opening){
					motionState = MotionState.Opening;
					onPlayStart.Invoke(motionName);
					if (simpleProp.sound !=null){
						EMMotionManager.PlaySound( simpleProp.sound, simpleProp.volume);
					}
				}
			}
			else{
				if (motionState != MotionState.Closing){
					motionState = MotionState.Closing;
					onRewindStart.Invoke(motionName);
					if (simpleProp.sound !=null && playSoundRewind){
						EMMotionManager.PlaySound( simpleProp.sound, simpleProp.volume);
					}
				}
			}
		}
	}
	
	protected override void On_EndMotion (string id){
		
		if (id == motionId){
			
			currentPropertiesCounter++;
			
			if (currentPropertiesCounter >= propertiesCounter){
				if (currentProp.motionType == EMMotionProperties.MotionType.OneShot){
					motionState = MotionState.Open;
					onPlayEnd.Invoke(motionName);
				}
				else{
					motionState = MotionState.Closed;
					onRewindEnd.Invoke( motionName);
				}
			}
			
		}
	}
	#endregion
}
