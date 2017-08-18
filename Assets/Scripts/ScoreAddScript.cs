using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScoreAddScript : MonoBehaviour {

    private UnityAction greatScoreAddListener;
    private UnityAction goodScoreAddListener;
    private UnityAction badScoreAddListener;
    private UnityAction veryBadScoreAddListener;

    private Text addScore;
    private float moveTime;
    public GameObject Score;
    private Vector3 scorePos;
    private bool start = false;

    private float speed = 2f;

    void Awake()
    {
        greatScoreAddListener = new UnityAction(addGreatScore);
        goodScoreAddListener = new UnityAction(addGoodScore);
        badScoreAddListener = new UnityAction(addBadScore);
        veryBadScoreAddListener = new UnityAction(addVeryBadScore);
    }

    void OnEnable()
    { 
        EventManager.StartListening("greatScoreAdd", greatScoreAddListener);
        EventManager.StartListening("goodScoreAdd", goodScoreAddListener);
        EventManager.StartListening("badScoreAdd", badScoreAddListener);
        EventManager.StartListening("veryBadScoreAdd", veryBadScoreAddListener);
    }

    void OnDisable()
    {
        EventManager.StopListening("greatScoreAdd", greatScoreAddListener);
        EventManager.StopListening("goodScoreAdd", goodScoreAddListener);
        EventManager.StopListening("badScoreAdd", badScoreAddListener);
        EventManager.StopListening("veryBadScoreAdd", veryBadScoreAddListener);
    }

    private void Start()
    {
        addScore = GetComponent<Text>();
        Score = GameObject.FindGameObjectWithTag("Score");
        scorePos = Score.transform.position + new Vector3(200, 0, 0);
    }
    private void Update()
    {
        if (start == true)
        {
            moveTime += Time.deltaTime * speed;
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, scorePos, moveTime);
            if (Vector3.SqrMagnitude(gameObject.transform.position - scorePos) < 0.0001)
            {
                Destroy(gameObject);
            }
        }
    }

    void startAnim()
    {
        start = true;
    }

    public void addGreatScore()
    {
        addScore.text = "+15";
        addScore.color = Color.green;
        startAnim();
        EventManager.StopListening("greatScoreAdd", greatScoreAddListener);
        EventManager.StopListening("goodScoreAdd", goodScoreAddListener);
        EventManager.StopListening("badScoreAdd", badScoreAddListener);
        EventManager.StopListening("veryBadScoreAdd", veryBadScoreAddListener);
    }

    public void addGoodScore()
    {
        addScore.text = "+10";
        addScore.color = Color.green;
        startAnim();
        EventManager.StopListening("greatScoreAdd", greatScoreAddListener);
        EventManager.StopListening("goodScoreAdd", goodScoreAddListener);
        EventManager.StopListening("badScoreAdd", badScoreAddListener);
        EventManager.StopListening("veryBadScoreAdd", veryBadScoreAddListener);
    }

    public void addBadScore()
    {
        addScore.text = "-5";
        addScore.color = Color.red;
        startAnim();
        EventManager.StopListening("greatScoreAdd", greatScoreAddListener);
        EventManager.StopListening("goodScoreAdd", goodScoreAddListener);
        EventManager.StopListening("badScoreAdd", badScoreAddListener);
        EventManager.StopListening("veryBadScoreAdd", veryBadScoreAddListener);
    }

    public void addVeryBadScore()
    {
        addScore.text = "-10";
        addScore.color = Color.red;
        startAnim();
        EventManager.StopListening("greatScoreAdd", greatScoreAddListener);
        EventManager.StopListening("goodScoreAdd", goodScoreAddListener);
        EventManager.StopListening("badScoreAdd", badScoreAddListener);
        EventManager.StopListening("veryBadScoreAdd", veryBadScoreAddListener);
    }

}
