//Joshua Janik
//6/9/2017

//Select what leaderboard to use.  Make sure to switch the leaderboard before
//displaying the leaderboard or the players high score.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLeaderboard : MonoBehaviour
{
	//Switch what leaderboard is curently active
	// 1.  High Score - Speed Feed
	// 2.  High Score - Not Yet Used
	// 3.  Fastest Time - First to Fat
	public void switchLeaderboard(int leaderboardNumber)
	{
		PlayerPrefs.SetInt("leaderboardNum", leaderboardNumber);
	}
}