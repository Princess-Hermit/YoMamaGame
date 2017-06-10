// Joshua Janik
// Some code from Git Hub
// 5/23/2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighScores : MonoBehaviour
{

	public Text[] highscoreText;
	public HighScores highscoresManager = null;

	void Start()
	{
		// Sets all the text to loading so the user knowes the score are being loaded from the databace.
		for (int i = 0; i < highscoreText.Length; i ++)
		{
			highscoreText[i].text = i+1 + ". Loading...";
		}

		//Get the highscores script
		highscoresManager = GetComponent<HighScores>();
		StartCoroutine("RefreshHighscores");
	}

	public void OnHighscoresDownloaded(Highscore[] highscoreList)
	{
		//Once the highscores have downloaded, store the data in the text fields.
		for (int i =0; i < highscoreText.Length; i ++)
		{
			highscoreText[i].text = i+1 + ". ";
			if (i < highscoreList.Length)
			{
				//In the name field, get rid of the time stamp.
				string username = highscoreList [i].username.Split (new char[] {'_'}, System.StringSplitOptions.RemoveEmptyEntries)[0];
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
		//Refresh the scores in realtime every 30 seconds.
		while (true)
		{
			highscoresManager.downloadHighscores();
			yield return new WaitForSeconds(30);
		}
	}
}
