using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsControler : MonoBehaviour
{
	public void ShowAd()
	{
		//The varable unityAdsCycle lets the program know how many times the player has tried the game.
		//Every 3 times, the player must see an ad before playing again.

		int adsCycle = PlayerPrefs.GetInt("unityAdsCycle");
		adsCycle++;

		if (adsCycle >= 3 && Advertisement.IsReady())
		{
			adsCycle = 0;
			Advertisement.Show();
		}

		PlayerPrefs.SetInt("unityAdsCycle", adsCycle);

		//Application.LoadLevel("MainMenuProto");
	}
}