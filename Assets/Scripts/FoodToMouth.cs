using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodToMouth : MonoBehaviour {

    private Vector3 mamaMouth = new Vector3(295f, 500.5f, 0);
    public float speed = 1f;
    private float fraction = 0;
    private bool move = false;

    public Button button;
    

    public void createDuplicate()
    {
        move = true;
        
    }
    private void Update()
    {
        if (move)
        {
            button = gameObject.GetComponent<Button>();
            button.interactable = false;
            if (fraction < 1)
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
