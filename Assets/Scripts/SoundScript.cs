﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoundScript : MonoBehaviour {

	public AudioClip goodEat;
	public AudioClip vGoodEat;
	public AudioClip badEat;
	public AudioClip vBadEat;

	public AudioClip throwSound;
	public AudioClip throwSound2;
	public AudioClip throwSound3;
	public AudioClip throwSound4;

	//Declares listeners
	private UnityAction foodThrownListener;

	private UnityAction goodFoodEatenListener;
	private UnityAction vGoodFoodEatenListener;
	private UnityAction badFoodEatenListener;
	private UnityAction vBadFoodEatenListener;

	private AudioSource source;

	void Awake()
	{
		//instantiates listeners
		foodThrownListener = new UnityAction(foodThrown);

		goodFoodEatenListener = new UnityAction (goodFoodEaten);
		vGoodFoodEatenListener = new UnityAction (vGoodFoodEaten);
		badFoodEatenListener = new UnityAction (badFoodEaten);
		vBadFoodEatenListener = new UnityAction (vBadFoodEaten);

		//instantiates AudioSource
		source = GetComponent<AudioSource>();
	}

	// Use this for initialization
	void Start () {
		//triggers the sound of food being thrown, no matter what type of food
		EventManager.StartListening("greatTrigger", foodThrownListener);
		EventManager.StartListening("goodTrigger", foodThrownListener);
		EventManager.StartListening("badTrigger", foodThrownListener);
		EventManager.StartListening("veryBadTrigger", foodThrownListener);

		EventManager.StartListening ("goodFoodEatenTrigger", goodFoodEaten);
		EventManager.StartListening ("vGoodFoodEatenTrigger", vGoodFoodEaten);
		EventManager.StartListening ("badFoodEatenTrigger", badFoodEaten);
		EventManager.StartListening ("vBadFoodEatenTrigger", vBadFoodEaten);
	}

	void foodThrown(){
		int soundToPlay = Random.Range (0, 4);
		switch (soundToPlay) {
			case 0:
				source.PlayOneShot (throwSound);
				break;
			case 1:
				source.PlayOneShot (throwSound2);
				break;
			case 2:
				source.PlayOneShot (throwSound3);
				break;
			case 3:
				source.PlayOneShot (throwSound4);
				break;
			default:
				source.PlayOneShot (throwSound);
				break;
		}
	}

	void goodFoodEaten(){
		source.PlayOneShot (goodEat);
	}
	void vGoodFoodEaten(){
		source.PlayOneShot (vGoodEat);
	}
	void badFoodEaten(){
		source.PlayOneShot (badEat);
	}
	void vBadFoodEaten(){
		source.PlayOneShot (vBadEat);
	}
}