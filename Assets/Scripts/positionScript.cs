using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionScript : MonoBehaviour {

    public int position;

	// Use this for initialization
	void Awake () {
        position = Gvar.position;
	}
	
	
}
