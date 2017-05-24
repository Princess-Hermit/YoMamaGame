using UnityEngine;
using System.Collections;

[System.Serializable]
public class EMEasingParameter{

	public EMEasing.EaseType easeType = EMEasing.EaseType.Linear;
	public float time=1;
	public float delay=0;

	public EMEasingParameter(){
		time = 1;
		delay =0;
	}
}
