using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LB_GameController : MonoBehaviour {

    public Text scoreUIText;

	// Use this for initialization
	void Start () {
        // set the score text to a random number at the start of the scene
        scoreUIText.text = Random.Range(0, 10000).ToString();
	}

    public void GameOver()
    {
        // for this example, we just take the contents of the scoreUIText text object
        // and convert it into a number to use as the final score
        int finalScore = System.Int32.Parse(scoreUIText.text);

        // when the game has finished, we just need to store the
        // final score in a PlayerPref so that the leaderboard script
        // can pick it up later
        PlayerPrefs.SetInt("finalScore", finalScore);
		//PlayerPrefs.SetInt("leaderboardNum", 3);

        // load the leaderboard screen to submit the score
        SceneManager.LoadScene("AddNewHighScore");
    }

	public void goToMainMenu()
	{
		SceneManager.LoadScene("MainMenuProto");
	}
}
