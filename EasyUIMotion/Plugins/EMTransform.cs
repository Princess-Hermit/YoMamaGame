using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]
public class EMTransform {

	public Vector3 position;
	public Vector3 rotation;
	public Vector3 scale;
	public Vector2 anchorMin;
	public Vector2 anchorMax;
	public float alpha;



	public void InitAllFromRectTransform(RectTransform source,float alpha){
		position = source.anchoredPosition;
		anchorMin = source.anchorMin;
		anchorMax = source.anchorMax;
		rotation = source.localRotation.eulerAngles;
		scale = source.localScale;
		this.alpha = alpha;
	}

	public void InitPositionFromRectTransform(RectTransform source){
		position = source.anchoredPosition;
		anchorMin = source.anchorMin;
		anchorMax = source.anchorMax;
	}

	public void ApplyAllToRectTransform( RectTransform destination, CanvasGroup canvasGroup){

		destination.anchoredPosition = position;
		destination.anchorMin = anchorMin;
		destination.anchorMax = anchorMax;
		destination.localRotation = Quaternion.Euler(rotation);
		destination.localScale = scale;

		if (canvasGroup!=null){
			canvasGroup.alpha = alpha;
		}
	}

	public void ApplyPositionToRectTransform( RectTransform destination){
		destination.anchoredPosition = position;
		destination.anchorMin = anchorMin;
		destination.anchorMax = anchorMax;
	}

}
