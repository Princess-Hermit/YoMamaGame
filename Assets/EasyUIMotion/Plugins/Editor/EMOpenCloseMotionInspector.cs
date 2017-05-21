using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(EMOpenCloseMotion))]
public class EMOpenCloseMotionInspector: Editor  {

	private bool inRecOpen;
	private bool inRecClose;

	private EMTransform startRect;

	void OnEnable(){
		inRecOpen = false;
		inRecClose = false;
		startRect =  new EMTransform();
	}


	void OnDisable(){
		EMOpenCloseMotion t = (EMOpenCloseMotion)target;

		if (inRecOpen){
			EndRecord(t.openProp, t.rectTransform());
		}

		if (inRecClose){
			EndRecord(t.closeProp, t.rectTransform());
		}
	}

	public override void OnInspectorGUI(){

		EMOpenCloseMotion t = (EMOpenCloseMotion)target;

		EditorGUILayout.Space();
		t.motionName = EditorGUILayout.TextField("Motion name",t.motionName);

		EditorGUILayout.Space();
		t.OpenAtStart = EMGuiTools.Toggle( "Open at start",t.OpenAtStart,true);

		EditorGUILayout.Space();
		t.alpha = EditorGUILayout.Slider("Alpha",t.alpha,0f,1f);

		EditorGUILayout.Space();

		// open effect
		t.showOpenInspector = EMGuiTools.BeginFoldOut( "Open motion",t.showOpenInspector);
		if (t.showOpenInspector){
			EMGuiTools.BeginGroup();{
				UIEffectInspector( t.openProp, t.rectTransform(), ref inRecOpen);
			}EMGuiTools.EndGroup();
			
		}
		
		// Close Effect
		t.showCloseInspector = EMGuiTools.BeginFoldOut( "Close motion",t.showCloseInspector);
		if (t.showCloseInspector){
			EMGuiTools.BeginGroup();{
				UIEffectInspector( t.closeProp, t.rectTransform(), ref inRecClose);
			}EMGuiTools.EndGroup();
			
		}

		// Events
		t.showEventInspector = EMGuiTools.BeginFoldOut( "Events",t.showEventInspector);
		if (t.showEventInspector){
			EMGuiTools.BeginGroup();{
				serializedObject.Update();
				SerializedProperty openStart = serializedObject.FindProperty("onOpenStart");
				EditorGUILayout.PropertyField(openStart, true, null);
				serializedObject.ApplyModifiedProperties();
				
				serializedObject.Update();
				SerializedProperty openEnd = serializedObject.FindProperty("onOpenEnd");
				EditorGUILayout.PropertyField(openEnd, true, null);
				serializedObject.ApplyModifiedProperties();
				
				serializedObject.Update();
				SerializedProperty closeStart = serializedObject.FindProperty("onCloseStart");
				EditorGUILayout.PropertyField(closeStart, true, null);
				serializedObject.ApplyModifiedProperties();
				
				serializedObject.Update();
				SerializedProperty closeend = serializedObject.FindProperty("onCloseEnd");
				EditorGUILayout.PropertyField(closeend, true, null);
				serializedObject.ApplyModifiedProperties();
				
			}EMGuiTools.EndGroup();
		}
	}

	private void UIEffectInspector( EMMotionProperties motion, RectTransform rect, ref bool inRec){

		motion.sound = (AudioClip)EditorGUILayout.ObjectField("Sound",motion.sound,typeof(AudioClip),false);
		motion.volume = EditorGUILayout.Slider("Volume",motion.volume,0f,1f);
		
		EditorGUILayout.Space();
		
		if (motion.motionType == EMMotionProperties.MotionType.Open){
			motion.autoClose = EMGuiTools.Toggle("Auto close",motion.autoClose,true);
			if (motion.autoClose){
				EditorGUI.indentLevel++;
				motion.autoCloseDelayTime = EditorGUILayout.FloatField("After (in second)",motion.autoCloseDelayTime);
				EditorGUI.indentLevel--;
			}
		}
		
		EditorGUILayout.Space();
		
		#region Move
		EditorGUI.indentLevel++;
		EditorGUILayout.BeginHorizontal ();
		GUILayout.Space(5);
		motion.inspectorShowMove = EMGuiTools.BeginFoldOut( "Move effect",motion.inspectorShowMove);
		EditorGUILayout.EndHorizontal();
		if (motion.inspectorShowMove){
			EMGuiTools.BeginGroup(6);{
				motion.isMove = EMGuiTools.Toggle("Enable move effect",motion.isMove,true);
				if (motion.isMove){
					
					string label = "From";
					if (motion.motionType == EMMotionProperties.MotionType.Close){
						label = "To";
					}
					motion.moveDirection = (EMMotionProperties.MotionDirection)EditorGUILayout.EnumPopup(label,motion.moveDirection);
					if (motion.moveDirection == EMMotionProperties.MotionDirection.UserDefined){
						UserDefinedStartPosition( motion, rect, ref inRec );
					}
					UIEaseInspector( motion.moveEasing);
				}
			}EMGuiTools.EndGroup();
			
		}
		else{
			EditorGUILayout.Space();
		}
		EditorGUI.indentLevel--;
		#endregion

		#region Rotate
		EditorGUI.indentLevel++;
		EditorGUILayout.BeginHorizontal ();
		GUILayout.Space(5);
		motion.inspectorShowRotate = EMGuiTools.BeginFoldOut( "Rotation effect",motion.inspectorShowRotate);
		EditorGUILayout.EndHorizontal();
		if (motion.inspectorShowRotate){
			EMGuiTools.BeginGroup(6);{
				motion.isRotate = EMGuiTools.Toggle("Enable rotation effect",motion.isRotate,true);
				if (motion.isRotate){	
					motion.transform.rotation = EditorGUILayout.Vector3Field("Rotation",motion.transform.rotation);
					UIEaseInspector( motion.rotateEasing);
				}
			}EMGuiTools.EndGroup();
			
		}
		else{
			EditorGUILayout.Space();
		}
		EditorGUI.indentLevel--;
		#endregion

		#region Scale
		EditorGUI.indentLevel++;
		EditorGUILayout.BeginHorizontal ();
		GUILayout.Space(5);
		motion.inspectorShowScale = EMGuiTools.BeginFoldOut( "Scale effect",motion.inspectorShowScale);
		EditorGUILayout.EndHorizontal();
		if (motion.inspectorShowScale){
			EMGuiTools.BeginGroup(6);{
				motion.isScale = EMGuiTools.Toggle("Enable scale effect",motion.isScale,true);
				if (motion.isScale){
					motion.transform.scale = EditorGUILayout.Vector3Field("Scale",motion.transform.scale);
					UIEaseInspector( motion.scaleEasing);
				}
			}EMGuiTools.EndGroup();
			
		}
		else{
			EditorGUILayout.Space();
		}
		EditorGUI.indentLevel--;
		#endregion

		#region Alpha
		EditorGUI.indentLevel++;
		EditorGUILayout.BeginHorizontal ();
		GUILayout.Space(5);
		motion.inspectorShowColor = EMGuiTools.BeginFoldOut( "alpha effect",motion.inspectorShowColor);
		EditorGUILayout.EndHorizontal();
		if (motion.inspectorShowColor){
			EMGuiTools.BeginGroup(6);{
				motion.isAlpha = EMGuiTools.Toggle("Enable alpha effect",motion.isAlpha,true);
				if (motion.isAlpha){
					motion.transform.alpha = EditorGUILayout.Slider("Alpha",motion.transform.alpha,0f,1f);
					UIEaseInspector( motion.alphaEasing);
				}
			}EMGuiTools.EndGroup();
		}
		else{
			EditorGUILayout.Space();
		}
		EditorGUI.indentLevel--;
		#endregion
	}

	void UserDefinedStartPosition(EMMotionProperties motion, RectTransform rect, ref bool inRec){

		if (!inRec)
			GUI.backgroundColor = Color.green;
		else
			GUI.backgroundColor = Color.red;

		EditorGUILayout.BeginHorizontal();
		GUILayout.Space(20);
		string label="Record";
		if (inRec) label ="Stop record";
		if (GUILayout.Button(label, GUILayout.Width(100))){
			if (!inRec){
				startRect.InitPositionFromRectTransform( rect );
				motion.transform.ApplyPositionToRectTransform( rect);
			}
			else{
				EndRecord( motion,rect);
			}
			inRec = !inRec;
		}
		GUI.backgroundColor = Color.white;

		if (inRec)
			EditorGUILayout.Vector3Field( "",rect.anchoredPosition);
		else{
			EditorGUILayout.Vector3Field("", motion.transform.position);
		}
		EditorGUILayout.EndHorizontal();

		EditorGUILayout.Space();
	}

	void EndRecord(EMMotionProperties motion,RectTransform rect){
		motion.transform.InitPositionFromRectTransform( rect );
		startRect.ApplyPositionToRectTransform( rect);

	}

	void UIEaseInspector(EMEasingParameter t){
		t.easeType = (EMEasing.EaseType)EditorGUILayout.EnumPopup("Ease",t.easeType);
		t.time = EditorGUILayout.FloatField("Ease time",t.time);
		t.delay = EditorGUILayout.FloatField("Delay to start",t.delay);		
	}
}
