using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderManager : MonoBehaviour {

	public string volTypeKey;

	void Awake () {
		switch(gameObject.name.Substring(0,3)){
		case "SFX":
			volTypeKey = "SFX Volume";

//			Debug.Log ("I'm "+ volTypeKey);

			if(PlayerPrefs.HasKey(volTypeKey)){
				gameObject.GetComponent <Slider> ().value = PlayerPrefs.GetFloat (volTypeKey);

//				Debug.Log ("loading existing playerpref for " + volTypeKey);

			} else {
				gameObject.GetComponent <Slider> ().value = .5f;

//				Debug.Log ("creating new pref for " + volTypeKey);

			}
			break;
		case "Mus":
			volTypeKey = "Music Volume";

//			Debug.Log ("I'm "+ volTypeKey);

			if(PlayerPrefs.HasKey(volTypeKey)){
				gameObject.GetComponent <Slider> ().value = PlayerPrefs.GetFloat(volTypeKey);

//				Debug.Log ("loading existing playerpref for " + volTypeKey);
			} else {
				gameObject.GetComponent <Slider> ().value = .5f;

//				Debug.Log ("creating new pref for " + volTypeKey);
			}
			break;
		}
	}

	public void saveValue(){
		PlayerPrefs.SetFloat (volTypeKey, gameObject.GetComponent <Slider> ().value);
//		Debug.Log("setting " + volTypeKey + " pref to " + gameObject.GetComponent <Slider> ().value);
	}
}
