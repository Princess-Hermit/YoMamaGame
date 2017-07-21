using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MamaMouthPosition : MonoBehaviour {

    GameObject mama;
    GameObject mamaMouth;
    Vector3 mamaPos;
    Vector3 mamaScale;

    // Use this for initialization
    void Start () {
        float x = 0;
        float y = 0;
        mamaPos = new Vector3(x, y);
        gameObject.transform.Translate(mamaPos);

        mama = GameObject.FindGameObjectWithTag("Mama");

        mamaMouth = GameObject.FindGameObjectWithTag("MamaMouth");
        mamaScale = mama.transform.localScale;

        mamaMouth.transform.Translate(mamaPos + new Vector3((Screen.width / 100), mamaScale.y * 20f));
        print(mamaScale.y * 20f);
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void moveMamaMouth()
    {
        mamaMouth.transform.Translate(mamaPos + new Vector3((Screen.width / 6), mamaScale.y * 20f));
    }
}
