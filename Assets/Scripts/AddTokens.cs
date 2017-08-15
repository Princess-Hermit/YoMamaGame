using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTokens : MonoBehaviour {

	public void addTokens(){
		TokenManager.tokenManager.tokens += 10;
	}
		
}
