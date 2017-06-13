using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeryBadFoodTrigger : MonoBehaviour {

    public void veryBadTrigger()
    {
        EventManager.triggerEvent("veryBadTrigger");
    }
}
