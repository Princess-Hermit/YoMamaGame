using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(EMSimpleMotion))]
public class EmSimpleMotionInspector : Editor {

	private bool inRec= false;
	private EMTransform startRect;

	void OnEnable(){
		inRec = false;
		startRect =  new EMTransform();
	}

	void OnDisable(){
		if (inRec){
			EMSimpleMotion t = (EMSimpleMotion)target;
			EndRecord(t.simpleProp, t.rectTransform());
		}

	}

	public override void OnInspectorGUI(){
		
		EMSimpleMotion t = (EMSimpleMotion)target;

		EditorGUILayout.Space();
		
		t.motionName = EditorGUILayout.TextField("Motion name",t.motionName);
		
		EditorGUILayout.Space();

		t.simpleProp.sound = (AudioClip)EditorGUILayout.ObjectField("Sound",t.simpleProp.sound,typeof(AudioClip),false);
		t.simpleProp.volume = EditorGUILayout.Slider("Volume",t.simpleProp.volume,0f,1f);
		t.playSoundRewind = EMGuiTools.Toggle("Play sound at rewind",t.playSoundRewind,true);

		#region Motion
		t.showMotionInspector = EMGuiTools.BeginFoldOut( "Motion",t.showMotionInspector);
		if (t.showMotionInspector){
			EMGuiTools.BeginGroup();{
				MotionInspector( t);

			}EMGuiTools.EndGroup();
			
		}
		#endregion

		#region Events
		t.showEventInspector = EMGuiTools.BeginFoldOut( "Events",t.showEventInspector);
		if (t.showEventInspector){
			EMGuiTools.BeginGroup();{
				serializedObject.Update();
				SerializedProperty openStart = serializedObject.FindProperty("onPlayStart");
				EditorGUILayout.PropertyField(openStart, true, null);
				serializedObject.ApplyModifiedProperties();
				
				serializedObject.Update();
				SerializedProperty openEnd = serializedObject.FindProperty("onPlayEnd");
				EditorGUILayout.PropertyField(openEnd, true, null);
				serializedObject.ApplyModifiedProperties();
				
				serializedObject.Update();
				SerializedProperty closeStart = serializedObject.FindProperty("onRewindStart");
				EditorGUILayout.PropertyField(closeStart, true, null);
				serializedObject.ApplyModifiedProperties();
				
				serializedObject.Update();
				SerializedProperty closeend = serializedObject.FindProperty("onRewindEnd");
				EditorGUILayout.PropertyField(closeend, true, null);
				serializedObject.ApplyModifiedProperties();
			}EMGuiTools.EndGroup();
			
		}
		#endregion

	}

	private void MotionInspector(EMSimpleMotion simpleMotion){

		Record( simpleMotion);

		EMMotionProperties motion = simpleMotion.simpleProp;

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
	
					motion.moveDirection = (EMMotionProperties.MotionDirection)EditorGUILayout.EnumPopup("To",motion.moveDirection);
					if (motion.moveDirection == EMMotionProperties.MotionDirection.UserDefined){
						if (inRec){
							motion.transform.position = simpleMotion.rectTransform().anchoredPosition ;
							motion.transform.anchorMin = simpleMotion.rectTransform().anchorMin;
							motion.transform.anchorMax = simpleMotion.rectTransform().anchorMax;
						}
						EditorGUILayout.Vector3Field("Position",motion.transform.position);
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

					if (inRec){
						motion.transform.rotation = simpleMotion.rectTransform().localRotation.eulerAngles ;
					}
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

					if (inRec){
						motion.transform.scale = simpleMotion.rectTransform().localScale;
					}
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

					if (inRec){
						simpleMotion.rectTransform().GetComponentInParent<CanvasGroup>().alpha = motion.transform.alpha ;
					}
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

	void Record(EMSimpleMotion motion){

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

				startRect.InitAllFromRectTransform(motion.rectTransform(),motion.GetComponentInParent<CanvasGroup>().alpha);

				if ( motion.simpleProp.isMove && motion.simpleProp.moveDirection == EMMotionProperties.MotionDirection.UserDefined){
					motion.rectTransform().anchorMin = motion.simpleProp.transform.anchorMin;
					motion.rectTransform().anchorMax = motion.simpleProp.transform.anchorMax;
					motion.rectTransform().anchoredPosition = motion.simpleProp.transform.position;
				}

				if (motion.simpleProp.isRotate){
					motion.rectTransform().localRotation =  Quaternion.Euler( motion.simpleProp.transform.rotation);
				}

				if (motion.simpleProp.isScale){
					motion.rectTransform().localScale = motion.simpleProp.transform.scale;
				}

				if (motion.simpleProp.isAlpha){
					motion.rectTransform().GetComponentInParent<CanvasGroup>().alpha = motion.simpleProp.transform.alpha;
				}
			}
			else{
				startRect.ApplyAllToRectTransform( motion.rectTransform(),motion.rectTransform().GetComponentInParent<CanvasGroup>());
			}
			inRec = !inRec;
		}
		GUI.backgroundColor = Color.white;
		
		EditorGUILayout.EndHorizontal();
		
		EditorGUILayout.Space();
	}

	void EndRecord(EMMotionProperties motion,RectTransform rect){

		startRect.ApplyAllToRectTransform( rect, rect.GetComponentInParent<CanvasGroup>() );
	}

	void UIEaseInspector(EMEasingParameter t){
		t.easeType = (EMEasing.EaseType)EditorGUILayout.EnumPopup("Ease",t.easeType);
		t.time = EditorGUILayout.FloatField("Ease time",t.time);
		t.delay = EditorGUILayout.FloatField("Delay to start",t.delay);		
	}



}
