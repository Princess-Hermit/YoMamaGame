using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot4Trigger : MonoBehaviour {

    public void slot4Click()
    {
        EventManager.triggerEvent("slot4Click");
    }
}
