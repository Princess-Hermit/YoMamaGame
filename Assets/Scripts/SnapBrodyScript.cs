using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapBrodyScript : MonoBehaviour {

    private Vector3 buttonPosition;

    public void Snap()
    {
        GameObject Brody = GameObject.FindGameObjectWithTag("Brody");
        buttonPosition = gameObject.transform.position;
        Brody.transform.position = (buttonPosition + new Vector3(0, 100f, 0));
    }
}
