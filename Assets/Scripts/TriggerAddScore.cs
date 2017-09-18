using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAddScore : MonoBehaviour {

    public GameObject ScoreAdd;
    public GameObject Parent;
    public GameObject Score;
    private Vector3 spacer;
    private Vector3 scorePos;

    void Start()
    {
        Parent = GameObject.FindGameObjectWithTag("Canvas");
        Score = GameObject.FindGameObjectWithTag("Score");
        spacer = new Vector3(0, 0, 0);
        scorePos = Score.transform.position;
    }

    public void AddScore()
    {
        Instantiate(ScoreAdd, scorePos + spacer, Quaternion.identity, Parent.transform);
    }

}
