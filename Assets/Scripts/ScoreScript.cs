using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScoreScript : MonoBehaviour {

    private Text score;
    private int scoreNum;

    private UnityAction greatScoreListener;
    private UnityAction goodScoreListener;
    private UnityAction badScoreListener;
    private UnityAction restartListener;

    public GameObject mama;


    void Awake()
    {
        greatScoreListener = new UnityAction(greatScore);
        goodScoreListener = new UnityAction(goodScore);
        badScoreListener = new UnityAction(badScore);
        restartListener = new UnityAction(restartGame);
    }

    void OnEnable()
    {
        EventManager.StartListening("greatTrigger", greatScoreListener);
        EventManager.StartListening("goodTrigger", goodScoreListener);
        EventManager.StartListening("badTrigger", badScoreListener);
        EventManager.StartListening("restart", restartListener);
    }

    void OnDisable()
    {
        EventManager.StopListening("greatTrigger", greatScoreListener);
        EventManager.StopListening("goodTrigger", goodScoreListener);
        EventManager.StopListening("badTrigger", badScoreListener);
        EventManager.StopListening("restart", restartListener);
    }

    
    void Start () {
        mama = GameObject.FindGameObjectWithTag("Mama");
        score = GetComponent<Text>();
        scoreNum = 0;
	}

    void restartGame()
    {
        scoreNum = 0;
        score.text = "lbs: " + scoreNum;
    }

	void greatScore()
    {
        scoreNum += 15;
        score.text = "lbs: " + scoreNum;
    }
    void goodScore()
    {
        scoreNum += 10;
        score.text = "lbs: " + scoreNum;
    }
    void badScore()
    {
        scoreNum -= 5;
        score.text = "lbs: " + scoreNum;
    }


    private void Update()
    {
        mama.transform.localScale = new Vector3(scoreNum/2000f + 0.27f, scoreNum/ 2000f + 0.3f, 0);

    }

}
