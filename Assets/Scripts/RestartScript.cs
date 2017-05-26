using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class RestartScript : MonoBehaviour {

    private UnityAction gameEndListener;

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}

    void Awake()
    {
        gameEndListener = new UnityAction(gameEnd);
    }

    void OnEnable()
    {
        EventManager.StartListening("gameOver", gameEndListener);
    }
    
    /*void OnDisable()
    {
       EventManager.StopListening("gameOver", gameEndListener);
    }*/

    void gameEnd()
    {
        gameObject.SetActive(true);
    }

    public void triggerReset()
    {
        EventManager.triggerEvent("restart");
        gameObject.SetActive(false);
    }
}
