using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof (CanvasGroup))]
public class EMBaseMotion : MonoBehaviour {

	public enum MotionState {Open, Opening,Closed,Closing};

	public string motionName;
	protected string motionId;

	public MotionState motionState;

	[SerializeField]
	protected EMTransform startTransform;

	protected EMMotionProperties currentProp;
	protected int currentPropertiesCounter;
	protected int propertiesCounter;

	//private Vector2 pivotOffset;
	private Vector3 originOffset;

	protected RectTransform cachedTransform;
	protected CanvasGroup cachedCanvasGroup;
	protected CanvasScaler cachedCanvasScaler;

	[SerializeField]
	protected float _alpha;
	public float alpha {
		get {
			return _alpha;
		}
		set {
			if (value != alpha){
				_alpha = value;
				GetComponent<CanvasGroup>().alpha = value;
			}
		}
	}

	protected bool isShuttingDown;

	#region Constructor
	public EMBaseMotion(){
		_alpha =1;
		motionName = "Motion" + System.Guid.NewGuid().ToString().Substring(0,5);
		motionId = System.Guid.NewGuid().ToString();
	}
	#endregion

	#region Monobehaviour Callback
	public virtual void Awake(){

		cachedTransform = this.rectTransform();
		cachedCanvasGroup = GetComponent<CanvasGroup>();
		cachedCanvasScaler = GetComponentInParent<CanvasScaler>();
		if (cachedCanvasScaler!=null){
			//Debug.LogWarning("Canvas scaler is missing");

			startTransform.InitAllFromRectTransform( cachedTransform, alpha);

			// Helper
			originOffset = GetOriginOffset(startTransform.anchorMin);

			EMMotionManager.instance.RegisterMotion( this);
		}
	}	

	public virtual void OnDestroy(){

		if (!isShuttingDown && !Application.isLoadingLevel){
			EMMotionManager.instance.UnRegisterMotion( this );
		}
	}

	void OnApplicationQuit(){
		isShuttingDown = true;
	}

	protected void DoAwake(){

		Debug.Log("ok");

		cachedTransform = this.rectTransform();
		cachedCanvasGroup = GetComponent<CanvasGroup>();
		cachedCanvasScaler = GetComponentInParent<CanvasScaler>();
		if (cachedCanvasScaler==null){
			Debug.LogWarning("Canvas scaler is missing");
		}
		
		startTransform.InitAllFromRectTransform( cachedTransform, alpha);
		
		// Helper
		originOffset = GetOriginOffset(startTransform.anchorMin);
		
		EMMotionManager.instance.RegisterMotion( this);
	}

	#endregion

	#region Motion
	protected void LaunchMotionSequence(EMMotionProperties properties,bool useCurrentState,bool reverse){
		
		currentPropertiesCounter =0;
		propertiesCounter=0;

		currentProp = properties;
		
		// Move
		if (properties.isMove){
			LaunchMoveProperty( properties,useCurrentState, reverse );
			propertiesCounter++;
		}

		// Rotate
		if (properties.isRotate){
			LaunchRotateProperty( properties,useCurrentState,reverse);
			propertiesCounter++;
		}

		// Scale
		if (properties.isScale){
			LaunchScaleProperty(  properties,useCurrentState,reverse);
			propertiesCounter++;
		}

		if (properties.isAlpha){
			LaunchAlphaProperty(  properties,useCurrentState,reverse);
			propertiesCounter++;
		}

		// No Effect
		if (propertiesCounter ==0){
			On_StartMotion(motionId);
			On_EndMotion(motionId);
		}

	}

	private void LaunchMoveProperty( EMMotionProperties properties, bool useCurrentState,bool reverse){

		EMTransform transform = GetTransformFromProperties( properties,useCurrentState);

		Vector3 start = Vector3.zero;
		Vector3 end = Vector3.zero;
		float delay = 0;

		if (!useCurrentState) delay = properties.moveEasing.delay;

		if (reverse){
			start = transform.position;
			end = startTransform.position;

			if (useCurrentState) start= cachedTransform.anchoredPosition;

			if (properties.moveDirection == EMMotionProperties.MotionDirection.UserDefined && !useCurrentState){
				start = GetPosition2NewAnchor( start,transform.anchorMin,startTransform.anchorMin );
				cachedTransform.anchorMin = startTransform.anchorMin;
				cachedTransform.anchorMax = startTransform.anchorMax;
			}
			else if ( useCurrentState){
				start = GetPosition2NewAnchor( start,cachedTransform.anchorMin,startTransform.anchorMin );

				cachedTransform.anchorMin = startTransform.anchorMin;
				cachedTransform.anchorMax = startTransform.anchorMax;
			}


		}
		else{

			start = startTransform.position;
			end = transform.position;

			if (useCurrentState) start = cachedTransform.anchoredPosition;

			if (cachedTransform.anchorMin != properties.transform.anchorMin && properties.moveDirection == EMMotionProperties.MotionDirection.UserDefined){
				start = GetPosition2NewAnchor( start,cachedTransform.anchorMin,properties.transform.anchorMin );
				cachedTransform.anchorMin = properties.transform.anchorMin;
				cachedTransform.anchorMax = properties.transform.anchorMax;
			}
		}


		EMEasing.ValueTo( gameObject, motionId, properties.moveEasing.easeType, start, end, properties.moveEasing.time,delay,"On_StartMotion","On_MoveUI","On_EndMotion");
		cachedTransform.anchoredPosition = start;

	}

	private void LaunchRotateProperty(EMMotionProperties properties, bool useCurrentState,bool reverse){

		Vector3 start=startTransform.rotation;
		Vector3 end=properties.transform.rotation;
		float delay=0;
		
		if (reverse){
			start=end;
			end=startTransform.rotation;
		}
		

		if (useCurrentState){
			start = cachedTransform.localRotation.eulerAngles;
		}
		else{
			delay = properties.rotateEasing.delay;
		}
		
		EMEasing.ValueTo( gameObject,motionId,properties.rotateEasing.easeType, start, end,properties.rotateEasing.time,delay,"On_StartMotion","On_RotateUI","On_EndMotion");

		cachedTransform.localRotation = Quaternion.Euler( start);

	}

	private void LaunchScaleProperty(EMMotionProperties properties, bool useCurrentState,bool reverse){

		Vector3 start = startTransform.scale;
		Vector3 end = properties.transform.scale;
		float delay = 0;
		
		if (reverse){
			start=end;
			end=startTransform.scale;
		}
			
		if (useCurrentState){
			start = cachedTransform.localScale;
		}
		else{
			delay = properties.scaleEasing.delay;
		}
		
		EMEasing.ValueTo( gameObject,motionId,properties.scaleEasing.easeType, start, end,properties.scaleEasing.time,delay,"On_StartMotion","On_ScaleUI","On_EndMotion");

		cachedTransform.localScale = start;
	}

	private void LaunchAlphaProperty(EMMotionProperties properties, bool useCurrentState,bool reverse){

		float start=startTransform.alpha;
		float end=properties.transform.alpha;
		float delay=0;
		
		if (reverse){
			start=end;
			end=startTransform.alpha;
		}
		
		if (useCurrentState){
			start = cachedCanvasGroup.alpha;	
		}
		else{
			delay = properties.alphaEasing.delay;
		}
		
		EMEasing.ValueTo( gameObject,motionId,properties.alphaEasing.easeType, start, end,properties.alphaEasing.time,delay,"On_StartMotion","On_AlphaUI","On_EndMotion");

		cachedCanvasGroup.alpha = start;
	}

	protected void StopMotion(){
		EMEasing.StopTween( gameObject);
		currentPropertiesCounter = propertiesCounter;
	}
	#endregion

	#region UI handle
	public void DisableUIElement(string motionName){
		if (this.motionName == motionId)
			DisableUIElement();
	}

	public void DisableUIElement(){
		cachedCanvasGroup.blocksRaycasts = false;
	}

	public void EnableUIElement(string motionName){
		if (this.motionName == motionId)
			EnableUIElement();
	}

	public void EnableUIElement(){
		cachedCanvasGroup.blocksRaycasts = true;
	}

	public void showUIElement(string motionName){
		if (this.motionName == motionId)
			showUIElement();
	}

	public void showUIElement(){
		cachedCanvasGroup.alpha = startTransform.alpha;
		cachedCanvasGroup.interactable = true;
		cachedCanvasGroup.blocksRaycasts = true;
	}

	public void HideUIElement(string motionName){
		if (this.motionName == motionId)
			HideUIElement();
	}

	public void HideUIElement(){
		cachedCanvasGroup.alpha =0;
		cachedCanvasGroup.interactable = false;
		cachedCanvasGroup.blocksRaycasts = false;
	}

	protected Vector3 ComputePosition(Vector3 anchoredPosition,EMMotionProperties.MotionDirection direction, Vector3 scale, bool inside){

		Vector2 pivotOffset = new Vector2(cachedTransform.sizeDelta.x * cachedTransform.pivot.x * scale.x, cachedTransform.sizeDelta.y * cachedTransform.pivot.y * scale.y);
		Vector3 position = anchoredPosition;

		switch (direction){
			case EMMotionProperties.MotionDirection.Top:
				if (!inside)
					position.y = originOffset.y + GetScalerResolution().y + pivotOffset.y;
				else
					position.y = originOffset.y + GetScalerResolution().y - pivotOffset.y;
				break;
			case EMMotionProperties.MotionDirection.Right:
				if (!inside)
					position.x = originOffset.x + GetScalerResolution().x + pivotOffset.x;
				else
					position.x = originOffset.x + GetScalerResolution().x - pivotOffset.x;
				break;
			case EMMotionProperties.MotionDirection.Bottom:
				if (!inside)
					position.y = originOffset.y -  pivotOffset.y;
				else
					position.y = originOffset.y + pivotOffset.y;
				break;
			case EMMotionProperties.MotionDirection.Left:
				if (!inside)
					position.x = originOffset.x - pivotOffset.x;
				else
					position.x = originOffset.x + pivotOffset.x;
				break;
		}
		
		return position;
		
	}

	protected EMTransform GetTransformFromProperties(EMMotionProperties prop, bool useCurrent){

		EMTransform transform = new EMTransform();

		if (prop.isMove){

			if (prop.moveDirection != EMMotionProperties.MotionDirection.UserDefined){
				transform.anchorMin = startTransform.anchorMin;
				transform.anchorMax = startTransform.anchorMax;

				Vector3 scale = startTransform.scale;
				if (useCurrent){
					scale = cachedTransform.localScale;
				}
				if (prop.isScale){
					scale = prop.transform.scale;
				}

				if (useCurrent){
					transform.position = ComputePosition(cachedTransform.anchoredPosition, prop.moveDirection,scale, prop.isInside);
				}
				else{
					transform.position = ComputePosition(startTransform.position, prop.moveDirection,scale, prop.isInside);
				}
			}
			else{
				transform.anchorMin = prop.transform.anchorMin;
				transform.anchorMax = prop.transform.anchorMax;
				transform.position = prop.transform.position;
			}
		}
		else{
			transform.position = startTransform.position;
			transform.anchorMin = startTransform.anchorMin;
			transform.anchorMax = startTransform.anchorMax;

		}

		if (prop.isRotate){
			transform.rotation = prop.transform.rotation;
		}
		else{
			transform.rotation = startTransform.rotation;
		}

		if (prop.isScale){
			transform.scale = prop.transform.scale;
		}
		else{
			transform.scale = startTransform.scale;
		}

		if (prop.isAlpha){
			transform.alpha = prop.transform.alpha;
		}
		else{
			transform.alpha = startTransform.alpha;
		}

		return transform;
	}
	#endregion

	#region Tween callback
	protected virtual void On_StartMotion(string id){

	}
	
	protected virtual void On_EndMotion(string id){
	}
	
	private void On_MoveUI( EMEasingCallback p){
		if (p.id == motionId){
			cachedTransform.anchoredPosition = p.vector3Value;
		}
	}
	
	private void On_RotateUI(EMEasingCallback p){
		if (p.id == motionId){
			cachedTransform.localRotation = Quaternion.Euler(p.vector3Value);
		}
	}
	
	private void On_ScaleUI(EMEasingCallback p){

		if (p.id == motionId){
			cachedTransform.localScale = p.vector3Value;
		}
	}
	
	private void On_AlphaUI(EMEasingCallback p){
		if (p.id == motionId){
			cachedCanvasGroup.alpha = p.floatValue;
		}
	}
	#endregion

	#region Screen / Canvas helper
	protected Vector2 GetScalerResolution(){
		
		float ratio =(float)Screen.width / (float)Screen.height;
		float x = cachedCanvasScaler.referenceResolution.x + (( cachedCanvasScaler.referenceResolution.y * ratio)-cachedCanvasScaler.referenceResolution.x) * cachedCanvasScaler.matchWidthOrHeight;
		float y = cachedCanvasScaler.referenceResolution.y + (( cachedCanvasScaler.referenceResolution.x / ratio)-cachedCanvasScaler.referenceResolution.y) * (1-cachedCanvasScaler.matchWidthOrHeight);
		
		return new Vector2(x,y);
	}
	
	protected Vector2 GetOriginOffset(Vector2 minAnchor){
		Vector2 resolution = GetScalerResolution();
		return new Vector2(-resolution.x * minAnchor.x, -resolution.y * minAnchor.y);

	}
	
	protected Vector3 GetOriginPosition(Vector3 position,Vector2 anchor){
		Vector2 originOffect = GetOriginOffset( anchor);
		return new Vector3( position.x - originOffect.x , position.y - originOffect.y , position.z);
	}
	
	protected Vector3 GetPosition2NewAnchor( Vector3 position, Vector2 currentAnchor, Vector2 newAnchor){

		Vector2 newOffset = GetOriginOffset( newAnchor);
		
		Vector3 originPosition = GetOriginPosition( position, currentAnchor );
		
		return new Vector3( newOffset.x + originPosition.x, newOffset.y + originPosition.y, position.z);
		
	}
	#endregion
}
