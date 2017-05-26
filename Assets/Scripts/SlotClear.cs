using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SlotClear : MonoBehaviour {

    private UnityAction clearListener;
    private UnityAction gameEndListener;

    void Awake()
    {
        clearListener = new UnityAction(clear);
        gameEndListener = new UnityAction(gameEnd);
    }

    void OnEnable()
    {
        EventManager.StartListening("greatTrigger", clearListener);
        EventManager.StartListening("goodTrigger", clearListener);
        EventManager.StartListening("badTrigger", clearListener);
        EventManager.StartListening("gameOver", gameEndListener);
    }

    void OnDisable()
    {
        EventManager.StopListening("greatTrigger", clearListener);
        EventManager.StopListening("goodTrigger", clearListener);
        EventManager.StopListening("badTrigger", clearListener);
        EventManager.StopListening("gameOver", gameEndListener);
    }

    void clear()
    {
        EventManager.triggerEvent("nextTurn");
        Destroy(gameObject);
    }

    void gameEnd()
    {
        Destroy(gameObject);
    }
}
