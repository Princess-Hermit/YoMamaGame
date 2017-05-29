using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodToMouth : MonoBehaviour {

    private Vector3 mamaMouth = new Vector3(295f, 500.5f, 0);
    public float speed = 1f;
    private float fraction = 0;
    private bool move = false;

    public void createDuplicate()
    {
        move = true;
        
    }
    private void Update()
    {
        if (move)
        {
            if (fraction < 0.95)
            {
                fraction += Time.deltaTime * speed;
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, mamaMouth, fraction);
            }
            else
            {
                Destroy(gameObject);
            }
        }

    }
    
}
