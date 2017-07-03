using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour {

    private Text score;
    private int scoreNum;

    private UnityAction greatScoreListener;
    private UnityAction goodScoreListener;
    private UnityAction badScoreListener;
    private UnityAction veryBadScoreListener;
    private UnityAction restartListener;
    private UnityAction gameOverListener;

    public GameObject mama;
    public Animator anim;


    void Awake()
    {
        greatScoreListener = new UnityAction(greatScore);
        goodScoreListener = new UnityAction(goodScore);
        badScoreListener = new UnityAction(badScore);
        veryBadScoreListener = new UnityAction(veryBadScore);
        restartListener = new UnityAction(restartGame);
        gameOverListener = new UnityAction(gameEnd);
    }

    void OnEnable()
    {
        EventManager.StartListening("greatTrigger", greatScoreListener);
        EventManager.StartListening("goodTrigger", goodScoreListener);
        EventManager.StartListening("badTrigger", badScoreListener);
        EventManager.StartListening("veryBadTrigger", veryBadScoreListener);
        EventManager.StartListening("restart", restartListener);
        EventManager.StartListening("gameOver", gameOverListener);
    }

    void OnDisable()
    {
        EventManager.StopListening("greatTrigger", greatScoreListener);
        EventManager.StopListening("goodTrigger", goodScoreListener);
        EventManager.StopListening("badTrigger", badScoreListener);
        EventManager.StopListening("veryBadTrigger", veryBadScoreListener);
        EventManager.StopListening("restart", restartListener);
        EventManager.StopListening("gameOver", gameOverListener);
    }

    
    void Start () {
        mama = GameObject.FindGameObjectWithTag("Mama");
        anim = mama.GetComponent<Animator>();
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
        anim.Play("MamaHappy");
    }
    void goodScore()
    {
        scoreNum += 10;
        score.text = "lbs: " + scoreNum;
        anim.Play("MamaHappy");
    }
    void badScore()
    {
        scoreNum -= 5;
        score.text = "lbs: " + scoreNum;
        anim.Play("MamaSad");
    }
    void veryBadScore()
    {
        scoreNum -= 10;
        score.text = "lbs: " + scoreNum;
        anim.Play("MamaSad");
    }

    // resize Mama
    private void Update()
    {
        mama.transform.localScale = new Vector3(scoreNum/1000f + 0.2f, scoreNum/ 1000f + 0.2f, 0);
    }

    void gameEnd()
    {
        //finalScore is the players score
        PlayerPrefs.SetInt("finalScore", scoreNum);
        //Load the AddNewHighScore scene
        SceneManager.LoadScene("AddNewHighScore");
    }

}
