using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAds : MonoBehaviour
{
	private bool addShowing = false;

	void Start()
	{
		if (Advertisement.IsReady())
		{
			Advertisement.Show();
		}
	}

	void Update()
	{		
		if (addShowing == false && Advertisement.isShowing)
		{
			addShowing = true;
			print ("Add is showing");
		}
		if (addShowing == true && !Advertisement.isShowing)
		{
			Application.LoadLevel("MainMenuProto");
		}
	}
}