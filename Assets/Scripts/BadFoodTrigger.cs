using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadFoodTrigger : MonoBehaviour {

    public void badTrigger()
    {
        EventManager.triggerEvent("badTrigger");
    }
}
