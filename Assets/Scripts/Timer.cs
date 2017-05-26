using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Timer : MonoBehaviour {

    private Text timer;
    private float timeLeft;
    private bool start = false;
    private bool time = false;

    private UnityAction startListener;
    private UnityAction restartListener;

    void Awake()
    {
        startListener = new UnityAction(startTimer);
        restartListener = new UnityAction(startTimer);
    }

    void OnEnable()
    {
        EventManager.StartListening("start", startListener);
        EventManager.StartListening("restart", restartListener);
    }
    void OnDisable()
    {
        EventManager.StopListening("start", startListener);
        EventManager.StopListening("restart", restartListener);
    }

    // Use this for initialization
    void Start () {
        timer = GetComponent<Text>();
        timer.text = "Time Left: 30";
	}
	
	// Update is called once per frame
	void Update () {

        if (start)
        {
            // set Game Time
            timeLeft = 30f;
            start = false;
        }

        if (time)
        {
            timeLeft -= Time.deltaTime;
            timer.text = "Time Left: " + timeLeft.ToString("0.0");
        }
        if (timeLeft < 0)
        {
            timer.text = "Time Left: 0.0";
            time = false;
            EventManager.triggerEvent("gameOver");
        }
    }

    void startTimer()
    {
        start = true;
        time = true;
    }
}
