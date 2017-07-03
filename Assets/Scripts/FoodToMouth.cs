using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodToMouth : MonoBehaviour {

	private GameObject g_mouth; //= GameObject.Find ("MamaMouth");


    private float speed = 7f;
    private bool move = false;
    private int position;
	private Vector3 mamaMouth;
    private Vector3 pos;
    private Vector3 arc1;
    private Vector3 arc2;
    private Vector3 arc3;
    private Vector3 arc4;

    int i = 0;
    float moveTime = 0f;
    float wait = 0.05f;

    public Button button;

    private void Start()
    {
		g_mouth = GameObject.Find ("MamaMouth");
		mamaMouth = g_mouth.transform.position;
        position = gameObject.GetComponent<positionScript>().position;
		arc1 = mamaMouth + new Vector3(-30f, 16f);
		arc2 = mamaMouth + new Vector3(-15f, 16f);
		arc3 = mamaMouth + new Vector3( 15f, 16f);
		arc4 = mamaMouth + new Vector3( 30f, 16f);
        pos = gameObject.transform.position;
    }

    public void createDuplicate()
    {
        move = true;
    }
    private void Update()
    {
        
        if (move)
        {
            if (wait > 0)
            {
                wait -= Time.deltaTime;
                return;
            }
            button = gameObject.GetComponent<Button>();
            button.interactable = false;
            
//pos 1
            if (position == 0)
            {
                if (i == 0)
                {
                    moveTime += Time.deltaTime * speed;
                    gameObject.transform.position = Vector3.Lerp(pos, arc1, moveTime);
                    if (Vector3.SqrMagnitude(gameObject.transform.position - arc1) < 0.0001)
                    {
                        pos = gameObject.transform.position;
                        moveTime = 0f;
                        i++;
                    }
                }
                if (i == 1)
                {
                    moveTime += Time.deltaTime * speed;
                    gameObject.transform.position = Vector3.Lerp(pos, mamaMouth, moveTime);
                    if (Vector3.SqrMagnitude(gameObject.transform.position - mamaMouth) < 0.0001)
                    {
                        i++;
                    }
                }
                if (i == 2)
                {
                    Destroy(gameObject);
                }
            }
//pos 2
            if (position == 1)
            {
                if (i == 0)
                {
                    moveTime += Time.deltaTime * speed;
                    gameObject.transform.position = Vector3.Lerp(pos, arc2, moveTime);
                    if (Vector3.SqrMagnitude(gameObject.transform.position - arc2) < 0.0001)
                    {
                        pos = gameObject.transform.position;
                        moveTime = 0f;
                        i++;
                    }
                }
                if (i == 1)
                {
                    moveTime += Time.deltaTime * speed;
                    gameObject.transform.position = Vector3.Lerp(pos, mamaMouth, moveTime);
                    if (Vector3.SqrMagnitude(gameObject.transform.position - mamaMouth) < 0.0001)
                    {
                        i++;
                    }
                }
                if (i == 2)
                {
                    Destroy(gameObject);
                }
            }
//pos 3
            if (position == 2)
            {
                if (i == 0)
                {
                    moveTime += Time.deltaTime * speed;
                    gameObject.transform.position = Vector3.Lerp(pos, arc3, moveTime);
                    if (Vector3.SqrMagnitude(gameObject.transform.position - arc3) < 0.0001)
                    {
                        pos = gameObject.transform.position;
                        moveTime = 0f;
                        i++;
                    }
                }
                if (i == 1)
                {
                    moveTime += Time.deltaTime * speed;
                    gameObject.transform.position = Vector3.Lerp(pos, mamaMouth, moveTime);
                    if (Vector3.SqrMagnitude(gameObject.transform.position - mamaMouth) < 0.0001)
                    {
                        i++;
                    }
                }
                if (i == 2)
                {
                    Destroy(gameObject);
                }
            }
// pos 4
            if (position == 3)
            {
                if (i == 0)
                {
                    moveTime += Time.deltaTime * speed;
                    gameObject.transform.position = Vector3.Lerp(pos, arc4, moveTime);
                    if (Vector3.SqrMagnitude(gameObject.transform.position - arc4) < 0.0001)
                    {
                        pos = gameObject.transform.position;
                        moveTime = 0f;
                        i++;
                    }
                }
                if (i == 1)
                {
                    moveTime += Time.deltaTime * speed;
                    gameObject.transform.position = Vector3.Lerp(pos, mamaMouth, moveTime);
                    if (Vector3.SqrMagnitude(gameObject.transform.position - mamaMouth) < 0.0001)
                    {
                        i++;
                    }
                }
                if (i == 2)
                {
                    Destroy(gameObject);
                }
            }

        }

    }
    
}
