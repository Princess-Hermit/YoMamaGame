using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodFoodTrigger : MonoBehaviour {

    public void goodTrigger()
    {
        EventManager.triggerEvent("goodTrigger");
    }
}
