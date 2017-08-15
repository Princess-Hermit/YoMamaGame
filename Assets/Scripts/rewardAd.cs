using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class rewardAd : MonoBehaviour {
	public void ShowRewardedAd(){
		if (Advertisement.IsReady ("rewardedVideo")) {
			var options = new ShowOptions{ resultCallback = HandleShowResult };
			Advertisement.Show ("rewardedVideo", options);
		}
	}

	private void HandleShowResult(ShowResult result){
		switch (result) {
		case ShowResult.Finished:
			TokenManager.tokenManager.tokens += 10;
			SceneManager.LoadScene(1);
			break;
		case ShowResult.Skipped:
			SceneManager.LoadScene(1);
			break;
		case ShowResult.Failed:
			SceneManager.LoadScene(1);
			break;
		}

	}

}
