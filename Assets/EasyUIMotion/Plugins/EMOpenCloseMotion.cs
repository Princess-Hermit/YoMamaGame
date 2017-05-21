using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

[AddComponentMenu("UI/Effects/Open-Close Motion")]
[System.Serializable]
public class EMOpenCloseMotion : EMBaseMotion {

	#region Unity Events
	[System.Serializable] public class OnOpenStartHandler : UnityEvent<string>{}
	[System.Serializable] public class OnOpenEndHandler : UnityEvent<string>{}
	[System.Serializable] public class OnCloseStartHandler : UnityEvent<string>{}
	[System.Serializable] public class OnCloseEndHandler : UnityEvent<string>{}
	
	
	[SerializeField] public OnOpenStartHandler onOpenStart;
	[SerializeField] public OnOpenEndHandler onOpenEnd;
	[SerializeField] public OnCloseStartHandler onCloseStart;
	[SerializeField] public OnCloseEndHandler onCloseEnd;
	#endregion

	#region Members
	public bool OpenAtStart;
	//public bool destroyOnClose;
	
	public EMMotionProperties openProp;
	public EMMotionProperties closeProp;

	public bool showOpenInspector;
	public bool showCloseInspector;
	public bool showEventInspector;	
	#endregion

	#region Constructor
	public EMOpenCloseMotion(){
	
		motionState = MotionState.Closed;
		OpenAtStart = true;
		isShuttingDown = false;
		openProp = new EMMotionProperties( EMMotionProperties.MotionType.Open);
		closeProp = new EMMotionProperties( EMMotionProperties.MotionType.Close);
	}
	#endregion

	#region Monobehaviour Callback
	void Start(){

		if (!cachedCanvasScaler){
			DoAwake();
		}
		motionState = MotionState.Closed;

		if (OpenAtStart){
			HideUIElement();
			Open();
		}
		else{
			GetTransformFromProperties( openProp,false).ApplyAllToRectTransform( cachedTransform, cachedCanvasGroup);
			HideUIElement();
		}

	}
	#endregion

	#region Motion
	public void OpenClose(bool open){
		if (open)
			Open();
		else
			Close ();
	}


	public void Open(string motionName){
		SendMessage( "OpenByName",motionName,SendMessageOptions.DontRequireReceiver);
	}

	private void OpenByName(string motionName){
		if (this.motionName == motionName)
			Open();
	}

	public void Open(bool force=false){

		if (motionState == MotionState.Closed || force ){
			GetTransformFromProperties( openProp,false).ApplyAllToRectTransform( cachedTransform, cachedCanvasGroup);
			currentProp = openProp;
			LaunchMotionSequence( openProp,force,true);
		}
	}

	
	public void Close(string motionName){
		SendMessage( "CloseByName",motionName,SendMessageOptions.DontRequireReceiver);
	}
	private void CloseByName(string motionName){
		if (this.motionName == motionName)
			Close();
	}
	public void Close(bool force=false){

		if (motionState == MotionState.Open || motionState == MotionState.Opening){
			StopMotion();
			currentProp = closeProp;
			LaunchMotionSequence( closeProp,force,false);
		}
	}
	
	public void SetStateToClose(string motionName){
		SendMessage( "SetStateToCloseByName",motionName,SendMessageOptions.DontRequireReceiver);
	}
	private void SetStateToCloseByName(string motionName){
		if (this.motionName == motionName)
			SetStateToClose();
	}
	public void SetStateToClose(){
		motionState = MotionState.Closed;
	}

	public void SetStateToOpen(string motionName){
		SendMessage( "SetStatToOpenByName",motionName,SendMessageOptions.DontRequireReceiver);
	}
	private void SetStatToOpenByName(string motionName){
		if (this.motionName == motionName)
			SetStateToOpen();
	}
	public void SetStateToOpen(){
		motionState = MotionState.Open;
	}


	IEnumerator WaitToAutoClose(float waitTime){
		
		yield return  new WaitForSeconds(waitTime);
		LaunchMotionSequence( closeProp,true,false);
	}
	#endregion

	#region Motion CallBack
	protected override void On_StartMotion(string id){
		if (id == motionId){
			if (currentProp.motionType == EMMotionProperties.MotionType.Open){
				if (motionState != MotionState.Opening){
					motionState = MotionState.Opening;
					onOpenStart.Invoke(motionName);

					showUIElement();
					
					if (openProp.sound !=null){
						EMMotionManager.PlaySound( openProp.sound, openProp.volume);
					}
				}
			}
			else{
				if (motionState != MotionState.Closing){
					motionState = MotionState.Closing;
					onCloseStart.Invoke(motionName);

					if (closeProp.sound !=null){
						EMMotionManager.PlaySound( closeProp.sound, closeProp.volume);
					}
				}
			}
		}
	}

	protected override void On_EndMotion (string id){

		if (id == motionId){

			currentPropertiesCounter++;
			
			if (currentPropertiesCounter >= propertiesCounter){
				if (currentProp.motionType == EMMotionProperties.MotionType.Open){
					onOpenEnd.Invoke(motionName);
					motionState = MotionState.Open;
					if (currentProp.autoClose){
						StartCoroutine( WaitToAutoClose(currentProp.autoCloseDelayTime));
					}
				}
				else{
					onCloseEnd.Invoke( motionName);
					motionState = MotionState.Closed;
					GetTransformFromProperties( openProp,false).ApplyAllToRectTransform( cachedTransform, cachedCanvasGroup );
					HideUIElement();
				}
			}

		}
	}
	#endregion
}
