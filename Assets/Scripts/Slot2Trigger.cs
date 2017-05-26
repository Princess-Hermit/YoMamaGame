using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot2Trigger : MonoBehaviour {

    public void slot2Click()
    {
        EventManager.triggerEvent("slot2Click");
    }
}
