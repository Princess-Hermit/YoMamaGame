// Joshua Janik
// Some code from Git Hub

// Change Log
// 5/23/2017	 Created an onlinie leaderboard.  This Script adds and downloads scores form a server.
// 6/9/2017		 There are now three leaderboards that can be accessed.  Leaderboard #3 is lowest score wins.
//				 To get this affect, the scores are inverted when added to the server.

//High Score Object
//Lets the app submit and recieve high scores to/from the server.
//Uses dreamlo.com

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScores : MonoBehaviour
{

	//Web URL to webserver - Don't Change
	//Leaderboard #1: High Score
	const string L1privateCode = "W62kZ-DYWkiiZIBkJnpBxwG2GNH8cXVESNQVjAybGd7g";
	const string L1publicCode = "592478e6758d06034481e9d9";

	//Leaderboard #2: High Score
	const string L2privateCode = "IO0bKXjOqkeL9VMNsgesoAl8-cDqHztUyqkGawEpbpOA";
	const string L2publicCode = "593ad6ed758d150344701c77";

	//Leaderboard #3: Fastest Time
	const string L3privateCode = "tHvrSZUyW0mQmjfdeyycjwaD76Bwmnd02aI_QrEqT4fQ";
	const string L3publicCode = "593ad91b758d15034470214f";

	//Web URL
	const string webURL = "http://dreamlo.com/lb/";

	public Highscore[] highscoresList;
	static HighScores instance;

	DisplayHighScores highscoreDisplay;
	AddHighScore addHighScore;

	//The high score server stores scores from biggest to lowest, so for Leaderboard #3,
	//I store the score as (inverseValue - score) so the scores get stored from smallest to biggest when translated back.
	private int inverseValue = 999999999;


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
		//Gets the leaderboardNum to calculate what high score table to use.
		//Store the current time so all names are different.  The current time is not shown to the user.
		WWW www = null;
		int leaderboardNum = PlayerPrefs.GetInt("leaderboardNum");
		if (leaderboardNum == 1)
		{
			www = new WWW (webURL + L1privateCode + "/add/" + WWW.EscapeURL (username + "_" + cur_time) + "/" + score);
		}
		else if (leaderboardNum == 2)
		{
			www = new WWW (webURL + L2privateCode + "/add/" + WWW.EscapeURL (username + "_" + cur_time) + "/" + score);
		}
		else
		{
			//Inverse the score so the smallest score wins.
			int inverseScore = inverseValue - score;
			www = new WWW (webURL + L3privateCode + "/add/" + WWW.EscapeURL (username + "_" + cur_time) + "/" + inverseScore);
		}

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
		//Submit Score to databace - Using the correct high score table.
		WWW www = null;
		int leaderboardNum = PlayerPrefs.GetInt("leaderboardNum");

		if (leaderboardNum == 1)
		{
			www = new WWW (webURL + L1publicCode + "/pipe/10");
		}
		else if (leaderboardNum == 2)
		{
			www = new WWW (webURL + L2publicCode + "/pipe/10");
		}
		else
		{
			www = new WWW (webURL + L3publicCode + "/pipe/10");
		}

		//Wait for Upload to be compleate.
		yield return www;

		//Make sure there where no errors with upload
		//If everything is good, tell the correct script that the scores have downloaded.
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

	//Store the data in the highscoresList so other scripts can access it.
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
			if (PlayerPrefs.GetInt ("leaderboardNum") != 3)
			{
				highscoresList [i] = new Highscore (username, score);
			}
			//If Leaderboard #3:  Use inverseValue to reverse the scores for the databace.
			else
			{
				//Can't have a time > then inverseValue
				if(score > inverseValue)
				{
					score = inverseValue;
				}
				int realScore = inverseValue - score;
				highscoresList [i] = new Highscore (username, realScore);
			}
			print (highscoresList[i].username + ": " + highscoresList[i].score);
		}
	}
}

//This is the Highscore struct
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