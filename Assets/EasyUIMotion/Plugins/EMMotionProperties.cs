using UnityEngine;
using System.Collections;

[System.Serializable]
public class EMMotionProperties{

	public enum MotionDirection {UserDefined,Top,Right,Bottom,Left,Center};
	public enum MotionType {Open, Close, OneShot, OneShotRewind};
	
	public MotionType motionType;
	public bool isInside;

	public EMTransform transform;

	// sound effect
	public AudioClip sound;
	public float volume;
	
	// auto flip
	public bool autoClose;
	public float autoCloseDelayTime;

	// Move
	public bool isMove;
	public MotionDirection moveDirection;
	public EMEasingParameter moveEasing;	

	// Rotate
	public bool isRotate;
	public EMEasingParameter rotateEasing;

	// Alpha
	public bool isAlpha;
	public EMEasingParameter alphaEasing;

	// Scale
	public bool isScale;
	public EMEasingParameter scaleEasing;

	// Inspector
	public bool inspectorShowMove=false;
	public bool inspectorShowColor=false;
	public bool inspectorShowRotate=false;
	public bool inspectorShowScale=false;	

	public EMMotionProperties(MotionType motionType){

		transform = new EMTransform();
		this.motionType = motionType;

		sound = null;
		volume =1;

		autoClose = false;
		autoCloseDelayTime =0;

		isMove = false;
		moveDirection = MotionDirection.Top;
		moveEasing = new EMEasingParameter();

		isRotate = false;
		rotateEasing= new EMEasingParameter();

		isAlpha = false;
		alphaEasing = new EMEasingParameter();

		isScale = false;
		scaleEasing = new EMEasingParameter();

		if (motionType == MotionType.OneShot){
			isInside = true;
		}
		else{
			isInside = false;
		}
	}

	public void ComputeTransform(){

	}
}
