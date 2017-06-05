﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodToMouth : MonoBehaviour {

    private Vector3 mamaMouth = new Vector3(295f, 500.5f, 0);
    private float speed = 7f;
    private bool move = false;
    private int position;
    private Vector3 pos;
    private Vector3 arc1;
    private Vector3 arc2;
    private Vector3 arc3;
    private Vector3 arc4;

    int i = 0;
    float moveTime = 0f;

    public Button button;

    private void Start()
    {
        position = gameObject.GetComponent<positionScript>().position;
        arc1 = gameObject.transform.position + new Vector3(150f, 550f);
        arc2 = gameObject.transform.position + new Vector3(50f, 550f);
        arc3 = gameObject.transform.position + new Vector3(-50f, 550f);
        arc4 = gameObject.transform.position + new Vector3(-150f, 550f);
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
