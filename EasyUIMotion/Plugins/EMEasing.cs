using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EMEasing : MonoBehaviour {

	#region Enumeration
	public enum EaseType {Linear,CubicIn, CubicOut,CubicInOut, BounceIn, BounceOut, BounceInOut, ElasticIn, ElasticOut }
	private enum VariableType {Float,V3,V2, Color};
	#endregion
	
	#region Member
	public string id;
	
	public GameObject target;
	public EaseType easeType;
	
	public float delayToStart;
	public float duration;
	
	public bool isStart = false;
	
	public string startCallBack;
	public string updateCallBack;
	public string endCallBack;

	private string motionId;
	private float startValue1;
	private float startValue2;
	private float startValue3;
	private float startValue4;
	private float endValue1; 
	private float endValue2;
	private float endValue3;
	private float endValue4;
	
	private float startTime;
	
	private VariableType variableType;
	private static List<EMEasing> tweens= new List<EMEasing>();
	#endregion
	
	private void Update(){
		
		if (isStart){
			
			float localTime = Time.realtimeSinceStartup-startTime;
			float currentValue1 =0;
			float currentValue2 =0;
			float currentValue3 =0;
			float currentValue4 =0;
			
			if (localTime<duration){
				switch ( variableType){
				case VariableType.Float:
					currentValue1 = UpdateTween(startValue1, endValue1, localTime);
					break;
				case VariableType.V2:
					currentValue1 = UpdateTween(startValue1, endValue1, localTime);
					currentValue2 = UpdateTween(startValue2, endValue2, localTime);
					break;
				case VariableType.V3:
					currentValue1 = UpdateTween(startValue1, endValue1, localTime);
					currentValue2 = UpdateTween(startValue2, endValue2, localTime);	
					currentValue3 = UpdateTween(startValue3, endValue3, localTime);	
					break;
				case VariableType.Color:
					currentValue1 = UpdateTween(startValue1, endValue1, localTime);
					currentValue2 = UpdateTween(startValue2, endValue2, localTime);	
					currentValue3 = UpdateTween(startValue3, endValue3, localTime);	
					currentValue4 = UpdateTween(startValue4, endValue4, localTime);
					break;
				}
				SendUpdate( currentValue1,currentValue2,currentValue3,currentValue4);
				
			}
			else{
				SendUpdate( endValue1,endValue2,endValue3,endValue4);
				if (!string.IsNullOrEmpty(endCallBack)){
					target.SendMessage( endCallBack,motionId,SendMessageOptions.DontRequireReceiver);
					
				}	
				tweens.Remove(this);
				Destroy(this);
			}
		}
	}
	
	private float UpdateTween(float start, float end,float time){
		float returnValue=0;
		
		switch (easeType){
			// Linear
		case EaseType.Linear:
			returnValue= Linear(time, start,end,duration);
			break;
			// Bounce In
		case EaseType.BounceIn:
			returnValue = BounceIn(time, start,end,duration);
			break;
			// Bounce Out
		case EaseType.BounceOut:
			returnValue = BounceOut(time, start,end,duration);
			break;
			// case Bounce In Out
		case EaseType.BounceInOut:
			returnValue = BounceInOut(time, start,end,duration);
			break;
			// Cubic In
		case EaseType.CubicIn:
			returnValue = CubicIn(time, start,end,duration);
			break;
			// Cubic Out
		case EaseType.CubicOut:
			returnValue = CubicOut(time, start,end,duration);
			break;
			// Cubic In Out
		case EaseType.CubicInOut:
			returnValue = CubicInOut(time, start,end,duration);
			break;
			// ElasticIn
		case EaseType.ElasticIn:
			returnValue = ElasticIn(time, start,end,duration);
			break;
			// Elastic Out
		case EaseType.ElasticOut:
			returnValue = ElasticOut(time, start,end,duration);
			break;
			
		}
		
		return returnValue;
	}
	
	private void SendUpdate(float v1, float v2, float v3,float v4){

		EMEasingCallback value = new EMEasingCallback();
		value.id = motionId;

		switch ( variableType){
			// float	
		case VariableType.Float:
			if (!string.IsNullOrEmpty(updateCallBack)){
				value.floatValue = v1;
				target.SendMessage( updateCallBack,value,SendMessageOptions.DontRequireReceiver);
			}
			break;
			// Vector2
		case VariableType.V2:
			if (!string.IsNullOrEmpty(updateCallBack)){
				value.vector2Value = new Vector2(v1,v2);
				target.SendMessage( updateCallBack,value,SendMessageOptions.DontRequireReceiver);
			}
			break;
			// Vector3
		case VariableType.V3:
			if (!string.IsNullOrEmpty(updateCallBack)){
				value.vector3Value = new Vector3(v1,v2,v3);
				target.SendMessage( updateCallBack,value,SendMessageOptions.DontRequireReceiver);
			}	
			break;
			// Color
		case VariableType.Color:
			if (!string.IsNullOrEmpty(updateCallBack)){
				value.colorValue = new Color(v1,v2,v3,v4);
				target.SendMessage( updateCallBack,value,SendMessageOptions.DontRequireReceiver);
			}	
			break;
		}
		
	}
	
	private IEnumerator LaunchEase(){
		yield return new WaitForSeconds (delayToStart);
		
		isStart = true;
		startTime = Time.realtimeSinceStartup;
		if (!string.IsNullOrEmpty(startCallBack)){
			target.SendMessage( startCallBack,motionId,SendMessageOptions.DontRequireReceiver);	
		}
	}
	
	
	#region Ease function
	// Linear
	private float Linear(float t, float start, float end, float d){
		return (end-start)*t/d+start;	
	}
	
	// Bounce
	private float BounceIn( float t, float start, float end, float d){
		end -= start;
		return end - BounceOut(d-t,0, end, d) + start;
	}
	
	private float BounceOut( float t, float start, float end, float d){
		
		float bounce = 7.5625f;
		
		t /= d;
		end -= start;
		if (t < (1 / 2.75f)){
			return end * (bounce * t * t) + start;
		}else if (t < (2 / 2.75f)){
			t -= (1.5f / 2.75f);
			return end * (bounce * (t) * t + .75f) + start;
		}else if (t < (2.5 / 2.75)){
			t -= (2.25f / 2.75f);
			return end * (bounce * (t) * t + .9375f) + start;
		}else{
			t -= (2.625f / 2.75f);
			return end * (bounce * (t) * t + .984375f) + start;
		}
		
		
	}	
	
	private float BounceInOut(float t, float start, float end, float d){
		
		end -= start;
		
		if (t < d/2f) return BounceIn (t*2, 0, end, d)*0.5f + start;
		
		return BounceOut (t*2-d, 0, end, d)*0.5f +  end*0.5f + start; 
	}
	
	
	// Cubic
	private float CubicIn( float t, float start, float end, float d){
		t /= d;
		end -= start;
		
		return end*t*t*t+start;
	}
	
	private float CubicOut( float t, float start, float end, float d){
		t /= d;
		t--;
		end -= start;
		return end*(t*t*t + 1) + start;
	}
	
	private float CubicInOut( float t, float start, float end, float d){
		t /= d/2;
		end -= start;
		
		if (t < 1) return end/2*t*t*t + start;
		t -= 2;
		return end/2*(t*t*t + 2) + start;
	}
	
	// Elastic
	private float ElasticIn(float t, float start, float end, float d){
		end -= start;
		
		float p = d * .3f;
		float s = 0;
		float a = 0;
		
		if (t == 0) return start;
		
		if ((t /= d) == 1) return start + end;
		
		if (a == 0f || a < Mathf.Abs(end)){
			a = end;
			s = p / 4f;
		}
		else{
			s = p / (2 * Mathf.PI) * Mathf.Asin(end / a);
		}
		
		return -(a * Mathf.Pow(2, 10 * (t-=1)) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p)) + start;
	}
	
	private float ElasticOut( float t, float start, float end, float d){
		
		end -= start;
		
		float p = d * 0.3f;
		float s = 0;
		float a = 0;
		
		if (t == 0) return start;
		
		if ((t /= d) == 1) return start + end;
		
		if (a == 0f || a < Mathf.Abs(end)){
			a = end;
			s = p * 0.25f;
		}
		else{
			s = p / (2 * Mathf.PI) * Mathf.Asin(end / a);
		}
		
		return (a * Mathf.Pow(2, -10 * t) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p) + end + start);
	}
	#endregion
	
	private void StartEase(){
		
		StartCoroutine( "LaunchEase");	
	}
	
	public static string ValueTo( GameObject obj,string id,EaseType easeType,object startValue,object endValue,float duration,float delaytToStart=0,string startCallBack="",string updateCallBack="", string endCallBack=""){
		
		EMEasing ee = obj.AddComponent<EMEasing>();
		ee.hideFlags = HideFlags.HideInInspector;
		ee.target = obj;
		ee.easeType = easeType;
		ee.delayToStart = delaytToStart;
		ee.duration = duration;
		ee.isStart = false;
		
		ee.startCallBack = startCallBack;
		ee.updateCallBack = updateCallBack;
		ee.endCallBack = endCallBack;
		
		ee.id = System.Guid.NewGuid().ToString();

		ee.motionId = id;

		if (startValue.GetType() == typeof(float)){
			ee.variableType = VariableType.Float;
			ee.startValue1 = (float)startValue;
			ee.endValue1 = (float)endValue;
		}else if ( startValue.GetType() == typeof(Vector2)){
			ee.variableType = VariableType.V2;
			ee.startValue1 = ((Vector2)startValue).x;
			ee.startValue2 = ((Vector2)startValue).y;
			ee.endValue1 = ((Vector2)endValue).x;
			ee.endValue2 = ((Vector2)endValue).y;
		}else if ( startValue.GetType() == typeof(Vector3)){
			ee.variableType = VariableType.V3;
			ee.startValue1 = ((Vector3)startValue).x;
			ee.startValue2 = ((Vector3)startValue).y;
			ee.startValue3 = ((Vector3)startValue).z;
			ee.endValue1 = ((Vector3)endValue).x;
			ee.endValue2 = ((Vector3)endValue).y;		
			ee.endValue3 = ((Vector3)endValue).z;
		}else if ( startValue.GetType() == typeof(Color)){
			ee.variableType = VariableType.Color;
			ee.startValue1 = ((Color)startValue).r;
			ee.startValue2 = ((Color)startValue).g;
			ee.startValue3 = ((Color)startValue).b;
			ee.startValue4 = ((Color)startValue).a;
			ee.endValue1 = ((Color)endValue).r;
			ee.endValue2 = ((Color)endValue).g;		
			ee.endValue3 = ((Color)endValue).b;	
			ee.endValue4 = ((Color)endValue).a;
		}
		
		tweens.Add(ee);
		
		if (delaytToStart>0){
			ee.StartEase();
		}else{
			ee.isStart = true;
			ee.startTime = Time.realtimeSinceStartup;
			if (!string.IsNullOrEmpty(startCallBack)){
				ee.target.SendMessage( startCallBack,ee.motionId,SendMessageOptions.DontRequireReceiver);	
			}
		}
		
		return ee.id;
	}
	
	public static void UpdateEndValue( string tweenId, object endValue){
		
		int result = tweens.FindIndex(
			delegate(EMEasing t)
			{
			return t.id == tweenId;
		}
		);
		
		if (result>-1){
			if (endValue.GetType() == typeof(float)){
				tweens[result].endValue1 = (float)endValue;
			}else if ( endValue.GetType() == typeof(Vector2)){
				tweens[result].endValue1 = ((Vector2)endValue).x;
				tweens[result].endValue2 = ((Vector2)endValue).y;
			}else if ( endValue.GetType() == typeof(Vector3)){
				tweens[result].endValue1 = ((Vector3)endValue).x;
				tweens[result].endValue2 = ((Vector3)endValue).y;		
				tweens[result].endValue3 = ((Vector3)endValue).z;
			}else if ( endValue.GetType() == typeof(Color)){
				tweens[result].endValue1 = ((Color)endValue).r;
				tweens[result].endValue2 = ((Color)endValue).g;		
				tweens[result].endValue3 = ((Color)endValue).b;
				tweens[result].endValue4 = ((Color)endValue).a;	
			}
		}
	}
	
	public static void StopTween(GameObject obj){
		
		for (int i=0;i<tweens.Count;i++){
			if (tweens[i].target == obj){
				tweens[i].StopAllCoroutines();
				Destroy( tweens[i]);
				tweens.RemoveAt(i);
				i--;
			}
		}
	}
}
