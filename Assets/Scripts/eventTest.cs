using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class eventTest : MonoBehaviour {

    private UnityAction someListener;

    void Awake()
    {
        someListener = new UnityAction(someFunction);
    }

    void OnEnable()
    {
        EventManager.StartListening("test", someListener);
    }

    void OnDisable()
    {
        EventManager.StopListening("test", someListener);
    }

    void someFunction()
    {
        Debug.Log("some function performed");
    }
}
