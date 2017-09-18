using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public class TokenManager : MonoBehaviour {

	//static reference so it can be referenced from other classes easily
	public static TokenManager tokenManager;

	// these values can be adjusted to fine-tune how generous or shrewd we are with free tokens
	private static int numTokensRequired = 5;
	private float defautTimeTillNext = 120f;
	private int maxTokens = 30;


	public float timeTillNextToken;
	public int tokens;
	public DateTime mostRecentTime;

	// Checks if there is already a token manager. If so, destroys its self
	void Awake () {
		if (tokenManager == null) {
			DontDestroyOnLoad (gameObject);
			tokenManager = this;
			Load ();
		} else if (tokenManager != this) {
			Destroy (gameObject);
		}
	}

	// timer to grant free tokens (if tokens below max)
	void Update(){
		if (tokens < maxTokens) {
			if (timeTillNextToken <= 0) {
				timeTillNextToken = defautTimeTillNext;
				tokens += 1;
			}
			timeTillNextToken -= Time.deltaTime;
		} else if (tokens >= maxTokens) {
			timeTillNextToken = defautTimeTillNext;
		}

	}

/*
	// displays token number. REPLACE WITH GUI ELEMENT 
	void OnGUI(){
		GUI.Label (new Rect (10, 10, 100, 30), "Tokens: " + tokens);
		if (tokens < maxTokens) {
			GUI.Label (new Rect (110, 10, 100, 30), "Next token:" + (int)(timeTillNextToken / 60) + ": " + ((int)(timeTillNextToken) % 60).ToString ("00"));
		} else if (tokens >= maxTokens) {
			GUI.Label (new Rect (110, 10, 100, 30), "Next token:" + " MAX");
		}
	}
*/


	// called when application gains or loses focus
	void OnApplicationFocus(bool hasFocus){
		if (!hasFocus) {
			Save ();
		} else if (hasFocus) {
			Load ();
		}
	}


	// function to save data about tokens to local device
	public void Save(){
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/tokenInfo.dat");

		// makes istance of data container with current data
		TokenData data = new TokenData();
		data.tokens = tokens;
		data.timeLeft = timeTillNextToken;
		data.mostRecentTime = DateTime.Now;

		//writes the data to the specified file (Unity's persistent data path)
		bf.Serialize(file, data);
		file.Close();
	}

	//loads data from file (if it exists)
	public void Load(){
		if (File.Exists (Application.persistentDataPath + "/tokenInfo.dat")) {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/tokenInfo.dat", FileMode.Open);
			TokenData data = (TokenData)bf.Deserialize (file);
			file.Close ();

			tokens = data.tokens;
			timeTillNextToken = data.timeLeft;
			mostRecentTime = data.mostRecentTime;

			//calculates tokens given from time away
			float diffInSeconds = (float)(DateTime.Now - mostRecentTime).TotalSeconds;
			if (diffInSeconds > 0) {

				float totalSeconds = timeTillNextToken + diffInSeconds;
				if (tokens < maxTokens) {
					int tokensToAdd = (int)(totalSeconds / defautTimeTillNext);

					//adds accrued tokens; sets tokens to 30 if they would exceed 30 (max)
					if (tokensToAdd + tokens > maxTokens) {
						tokens = maxTokens;
					} else {
						tokens += tokensToAdd;
					}

					timeTillNextToken = totalSeconds % defautTimeTillNext;

				}
			}

		}
	}

	// getters for private fields that we don't want other classes modifying
	public int getTokensRequired(){
		return numTokensRequired;
	}
	public float getDefaultTime(){
		return defautTimeTillNext;
	}
	public int getMaxTokens(){
		return maxTokens;
	}
}

// Data container private class. Holds number of tokens, amount of time left on timer, and the time the game was closed/lost focus
[Serializable]
class TokenData{
	public int tokens;
	public float timeLeft;
	public DateTime mostRecentTime;
}