using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Timer2 : MonoBehaviour {

    private Text timer;
    private float time;
    private bool start = false;
    private bool timeStart = false;

    private UnityAction startListener;
    private UnityAction restartListener;
    private UnityAction gameOverListener;

    void Awake()
    {
        startListener = new UnityAction(startTimer);
        restartListener = new UnityAction(startTimer);
        gameOverListener = new UnityAction(stopTimer);
    }

    void OnEnable()
    {
        EventManager.StartListening("start", startListener);
        EventManager.StartListening("restart", restartListener);
        EventManager.StartListening("gameOver", gameOverListener);
    }
    void OnDisable()
    {
        EventManager.StopListening("start", startListener);
        EventManager.StopListening("restart", restartListener);
        EventManager.StopListening("gameOver", gameOverListener);
    }

    // Use this for initialization
    void Start () {
        timer = GetComponent<Text>();
        timer.text = "Time: 0.0";
	}


    void stopTimer()
    {
        timeStart = false;
        timer.text = "Time: " + time.ToString("0.00");
    }

	void startTimer()
    {
        start = true;
        timeStart = true;
    }


	// Update is called once per frame
	void Update () {

        if (start)
        {
            // set Game Time
            time = 0.0f;
            start = false;
        }

        if (timeStart)
        {
            time += Time.deltaTime;
            timer.text = "Time: " + time.ToString("0.0");
        }


        
    }

    
}
