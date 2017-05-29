//Joshua Janik
//5/23/2017

//High Score Object
//Lets the app submit and recieve high scores to/from the server.
//Uses dreamlo.com
//Some code from Github

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScores : MonoBehaviour
{

	//Web URL to webserver - Don't Change
	const string privateCode = "W62kZ-DYWkiiZIBkJnpBxwG2GNH8cXVESNQVjAybGd7g";
	const string publicCode = "592478e6758d06034481e9d9";
	const string webURL = "http://dreamlo.com/lb/";

	//const string _ip = NetworkPlayer.ipAddress;

	public Highscore[] highscoresList;
	static HighScores instance;

	DisplayHighScores highscoreDisplay;
	AddHighScore addHighScore;


	//Methoids
	void Awake()
	{
		instance = this;
		highscoreDisplay = GetComponent<DisplayHighScores> ();
		addHighScore = GetComponent<AddHighScore> ();
	}

	public static void addNewHighScore(string username, int score)
	{
		instance.StartCoroutine (instance.uploadNewHighScore(username, score));
	}

	public void downloadHighscores()
	{
		StartCoroutine ("downloadHighscoresFromDatabace");
	}


	//Helper Methoids
	//Upload a High Score - Don't need to call directly
	IEnumerator uploadNewHighScore(string username, int score)
	{
		//Calculate time sence 1970
		System.DateTime epochStart = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
		int cur_time = (int)(System.DateTime.UtcNow - epochStart).TotalSeconds;
		//print (cur_time);

		//Submit Score to databace
		WWW www = new WWW (webURL + privateCode + "/add/" + WWW.EscapeURL (username + "-" + cur_time) + "/" + score);

		//Wait for Upload to be compleate.
		yield return www;

		//Make sure there where no errors with upload
		if (string.IsNullOrEmpty (www.error))
		{
			//No Errors
			print("Upload Good!");
			downloadHighscores ();
		}
		else
		{
			//There where Errors
			print("There was an error with the Upload");
		}
	}

	//Download Scores - Don't need to call directly
	IEnumerator downloadHighscoresFromDatabace()
	{
		//Submit Score to databace
		WWW www = new WWW (webURL + publicCode + "/pipe/10");

		//Wait for Upload to be compleate.
		yield return www;

		//Make sure there where no errors with upload
		if (string.IsNullOrEmpty (www.error))
		{
			//No Errors
			FormatHighscores(www.text);
			if (highscoreDisplay != null)
			{
				highscoreDisplay.OnHighscoresDownloaded (highscoresList);
			}
			else if (addHighScore != null)
			{
				addHighScore.OnHighscoresDownloaded (highscoresList);
			}
			else
			{
				print ("ERROR: null script");
			}
		}
		else
		{
			//There where Errors
			print("There was an error with the Upload");
		}
	}

	void FormatHighscores (string textStream)
	{
		string[] entries = textStream.Split (new char[] {'\n'}, System.StringSplitOptions.RemoveEmptyEntries);

		highscoresList = new Highscore[entries.Length];
		for (int i = 0; i < entries.Length; i++)
		{
			string[] entryInfo = entries[i].Split(new char[] {'|'});
			string username = entryInfo[0];//.Split(new char[] {'='})[0];
			int score = int.Parse(entryInfo[1]);
			//string ip = entryInfo [0].Split(new char[] {'='})[1];
			highscoresList[i] = new Highscore(username,score);
			print (highscoresList[i].username + ": " + highscoresList[i].score);
		}
	}
}

public struct Highscore
{
	public string username;
	public int score;
	//public string ip;

	public Highscore(string _username, int _score)
	{
		username = _username;
		score = _score;
	}
}

public struct boolWrapper
{
	public bool boolean;

	public boolWrapper(bool _boolean)
	{
		boolean = _boolean;
	}
}