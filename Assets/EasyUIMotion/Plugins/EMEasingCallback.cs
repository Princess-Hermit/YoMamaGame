using UnityEngine;
using System.Collections;

public class EMEasingCallback{

	public string id;
	public float floatValue;
	public Vector2 vector2Value;
	public Vector3 vector3Value;
	public Color colorValue;

	public EMEasingCallback(){
		floatValue = 0;
		vector2Value = Vector2.zero;
		vector3Value = Vector3.zero;
		colorValue = Color.white;
	}
}
