using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BrodyScript : MonoBehaviour {

    private UnityAction greatScoreListener;
    private UnityAction goodScoreListener;
    private UnityAction badScoreListener;
    private UnityAction veryBadScoreListener;

    public Animator anim;
    private float wait = 0.03f;

    void Awake()
    {
        greatScoreListener = new UnityAction(brodyThrow);
        goodScoreListener = new UnityAction(brodyThrow);
        badScoreListener = new UnityAction(brodyThrow);
        veryBadScoreListener = new UnityAction(brodyThrow);
    }
    void OnEnable()
    {
        EventManager.StartListening("greatTrigger", greatScoreListener);
        EventManager.StartListening("goodTrigger", goodScoreListener);
        EventManager.StartListening("badTrigger", badScoreListener);
        EventManager.StartListening("veryBadTrigger", veryBadScoreListener);
    }
    void OnDisable()
    {
        EventManager.StopListening("greatTrigger", greatScoreListener);
        EventManager.StopListening("goodTrigger", goodScoreListener);
        EventManager.StopListening("badTrigger", badScoreListener);
        EventManager.StopListening("veryBadTrigger", veryBadScoreListener);
    }

        void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        
        if (anim.GetBool("Throw") == true)
        {
            if (wait > 0)
            {
                wait -= Time.deltaTime;
                return;
            }
            if (wait <= 0)
            {
                anim.SetBool("Throw", false);
                wait = 0.03f;
            }
            
        }
    }

    void brodyThrow()
    {
        //anim.SetBool("Throw", true);
        anim.Play("Brody Throw anim");
    }
        
	
}
