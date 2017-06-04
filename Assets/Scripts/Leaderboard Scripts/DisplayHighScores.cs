// Code from Git Hub
// Added Code by Joshua Janik
// 5/23/2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighScores : MonoBehaviour
{

	public Text[] highscoreText;
	public HighScores highscoresManager = null;

	// Use this for initialization
	void Start()
	{
		for (int i = 0; i < highscoreText.Length; i ++)
		{
			highscoreText[i].text = i+1 + ". Loading...";
		}


		highscoresManager = GetComponent<HighScores>();
		StartCoroutine("RefreshHighscores");
	}

	public void OnHighscoresDownloaded(Highscore[] highscoreList)
	{
		for (int i =0; i < highscoreText.Length; i ++)
		{
			highscoreText[i].text = i+1 + ". ";
			if (i < highscoreList.Length)
			{
				//In the name field, get rid of the time stamp.
				string username = highscoreList [i].username.Split (new char[] {'-'}, System.StringSplitOptions.RemoveEmptyEntries)[0];
				username = username.Replace ("+", " ");
				//Display the name and score
				highscoreText [i].text += username + " - " + highscoreList [i].score;
			}
			else
			{
				highscoreText [i].text += "  --:--";
			}
		}
	}
	
	IEnumerator RefreshHighscores()
	{
		while (true)
		{
			highscoresManager.downloadHighscores();
			yield return new WaitForSeconds(30);
		}
	}
}
