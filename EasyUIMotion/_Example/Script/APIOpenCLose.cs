using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class APIOpenCLose : MonoBehaviour {

	public Text openCloseState;
	public Text simpleState;

	public void OpenAPI(){
		EMMotionManager.Open("HedgehogOpenClose");
	}

	public void CloseAPI(){
		EMMotionManager.Close("HedgehogOpenClose");
	}

	public void PlayAPI(){
		if (EMMotionManager.GetState("HedgehogOpenClose") == EMBaseMotion.MotionState.Open)
			EMMotionManager.PlayMotion("HedgehogSimple");
	}

	public void RewindAPI(){
		if (EMMotionManager.GetState("HedgehogOpenClose") == EMBaseMotion.MotionState.Open)
			EMMotionManager.RewindMotion("HedgehogSimple");
	}

	void Update(){

		openCloseState.text =  EMMotionManager.GetState("HedgehogOpenClose").ToString();
		simpleState.text =  EMMotionManager.GetState("HedgehogSimple").ToString();

		if ( EMMotionManager.GetState("HedgehogOpenClose") == EMBaseMotion.MotionState.Closing){
			EMMotionManager.ResetSimpleMotion("HedgehogSimple");
		}
	}
}
