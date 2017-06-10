// Code from Git Hub
// Added Code by Joshua Janik
// 5/24/2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class AddHighScore : MonoBehaviour
{
	public Text highscoreText;
	public GameObject inputWrapper;
	public InputField inputField;
	public HighScores highscoresManager;

	private int tableSize = 10;
	private int finalScore = -1;

	private bool addedScore = false;

	void Start()
	{
		//Find the high scores script
		highscoresManager = GetComponent<HighScores>();

		//Store the final score into highscoreText
		finalScore = PlayerPrefs.GetInt("finalScore");
		highscoreText.text = "Your Score: " + finalScore;

		StartCoroutine("RefreshHighscores");
	}

	public void OnHighscoresDownloaded(Highscore[] highscoreList)
	{
		//Once the highscores downloaded, check if the user's score is on the leaderboard.
		//If it is, set the inputWrapper object to active so the user can add their name to the leaderboard.
		if (addedScore == false)
		{
			//Leaderboard 1 & 2
			if(PlayerPrefs.GetInt ("leaderboardNum") != 3)
			{
				if (highscoreList.Length < tableSize || highscoreList [tableSize - 1].score < finalScore)
				{
					print ("TRUE");
					highscoreText.text = "Score: " + finalScore + "\nYour on the Leaderboard!";
					inputWrapper.SetActive (true);
				}
			}
			//Leaderboard 3
			else if (highscoreList.Length < tableSize || highscoreList [tableSize - 1].score > finalScore)
			{
				print ("TRUE");
				highscoreText.text = "Score: " + finalScore + "\nYour on the Leaderboard!";
				inputWrapper.SetActive (true);
			}
		}
	}

	public void submitScore()
	{
		//If score is on the Leaderboard, add it to the server
		if(inputWrapper.activeSelf == true)
		{
			HighScores.addNewHighScore (inputField.text, finalScore);
			inputWrapper.SetActive (false);
			addedScore = true;
			highscoreText.text = "Score: " + finalScore + "\nScore Submitted!";
		}
	}

	public void goToLeaderboard()
	{
		SceneManager.LoadScene("HighScoreTable");
	}
	
	IEnumerator RefreshHighscores()
	{
		//Only download the scores once.
		highscoresManager.downloadHighscores();
		yield return new WaitForSeconds(30);
	}
}