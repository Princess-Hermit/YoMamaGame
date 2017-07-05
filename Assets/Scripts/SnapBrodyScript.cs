using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapBrodyScript : MonoBehaviour {

    private Vector3 buttonPosition;

    public void Snap()
    {
        GameObject Brody = GameObject.FindGameObjectWithTag("Brody");
        buttonPosition = gameObject.transform.position;
<<<<<<< HEAD
        Brody.transform.position = (buttonPosition + new Vector3(20f, 36f));
=======
        Brody.transform.position = (buttonPosition + new Vector3(75f, -5f));
>>>>>>> origin/master
    }
}
