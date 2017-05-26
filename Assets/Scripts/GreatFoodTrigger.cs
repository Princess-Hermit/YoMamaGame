using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatFoodTrigger : MonoBehaviour {

    public void greatTrigger()
    {
        EventManager.triggerEvent("greatTrigger");
    }
}
