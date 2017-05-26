using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot1Trigger : MonoBehaviour {

    public void slot1Click()
    {
        EventManager.triggerEvent("slot1Click");
    }
}
