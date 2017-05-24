using UnityEngine;
using System.Collections;

public static class ComponentExtensions{

	public static RectTransform rectTransform(this Component cp){
		return cp.transform as RectTransform;
	}
	
}
