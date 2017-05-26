using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour {

    /*
    private UnityAction turnListener;
    private UnityAction startListener;
    private UnityAction restartListener;
    private UnityAction gameEndListener;

    void Awake()
    {
        turnListener = new UnityAction(changeTurn);
        startListener = new UnityAction(startGame);
        restartListener = new UnityAction(restartGame);
        gameEndListener = new UnityAction(gameEnd);
    }

    void OnEnable()
    {
        EventManager.StartListening("nextTurn", turnListener);
        EventManager.StartListening("start", startListener);
        EventManager.StartListening("restart", restartListener);
        EventManager.StartListening("gameOver", gameEndListener);
    }
    void OnDisable()
    {
        EventManager.StopListening("nextTurn", turnListener);
        EventManager.StopListening("start", startListener);
        EventManager.StopListening("restart", restartListener);
        EventManager.StopListening("gameOver", gameEndListener);
    }
    */

    public void startGame()
    {
        EventManager.triggerEvent("start");
        gameObject.SetActive(false);
    }

	
}
