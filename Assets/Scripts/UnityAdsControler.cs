using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsControler : MonoBehaviour
{
	public void ShowAd()
	{
		if (Advertisement.IsReady())
		{
			Advertisement.Show();
		}

		Application.LoadLevel("MainMenuProto");
	}
}