using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LB_MainMenuController : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene("Test_Game");
    }

    public void ViewLeaderboard()
    {
        SceneManager.LoadScene("HighScoreTable");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
