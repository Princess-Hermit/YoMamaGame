using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot3Trigger : MonoBehaviour {

    public void slot3Click()
    {
        EventManager.triggerEvent("slot3Click");
    }
}
