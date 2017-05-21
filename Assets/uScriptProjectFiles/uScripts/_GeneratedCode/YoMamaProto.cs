//uScript Generated Code - Build 1.0.3055
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class YoMamaProto : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject[] FoodList = new UnityEngine.GameObject[] {};
   public System.Boolean FoodPressed01 = (bool) false;
   public System.Boolean FoodPressed02 = (bool) false;
   public System.Boolean FoodPressed03 = (bool) false;
   public System.Boolean FoodPressed04 = (bool) false;
   System.String local_10_System_String = "Button 01 False";
   System.String local_12_System_String = "Button 02 True";
   System.String local_18_System_String = "Button 02 False";
   System.String local_19_System_String = "Button 03 True";
   System.String local_25_System_String = "Button 03 False";
   System.String local_26_System_String = "Button 04 True";
   System.String local_32_System_String = "Button 04 False";
   UnityEngine.GameObject local_38_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_38_UnityEngine_GameObject_previous = null;
   System.String local_41_System_String = "";
   System.String local_42_System_String = "";
   UnityEngine.GameObject local_44_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_44_UnityEngine_GameObject_previous = null;
   System.String local_48_System_String = "";
   UnityEngine.GameObject local_50_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_50_UnityEngine_GameObject_previous = null;
   System.String local_54_System_String = "";
   UnityEngine.GameObject local_56_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_56_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_61_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_61_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_62_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_62_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_64_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_64_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_66_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_66_UnityEngine_GameObject_previous = null;
   System.String local_7_System_String = "Button 01 True";
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareBoolState logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_5 = new uScriptCon_CompareBoolState( );
   System.Boolean logic_uScriptCon_CompareBoolState_target_5 = (bool) false;
   System.Boolean logic_uScriptCon_CompareBoolState_previousState_5 = (bool) false;
   bool logic_uScriptCon_CompareBoolState_Out_5 = true;
   bool logic_uScriptCon_CompareBoolState_IsTrue_5 = true;
   bool logic_uScriptCon_CompareBoolState_IsFalse_5 = true;
   bool logic_uScriptCon_CompareBoolState_WasTrue_5 = true;
   bool logic_uScriptCon_CompareBoolState_WasFalse_5 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_6 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_6 = "";
   System.Object[] logic_uScriptAct_Log_Target_6 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_6 = "";
   bool logic_uScriptAct_Log_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_8 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_8;
   bool logic_uScriptAct_SetBool_Out_8 = true;
   bool logic_uScriptAct_SetBool_SetTrue_8 = true;
   bool logic_uScriptAct_SetBool_SetFalse_8 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_11 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_11 = "";
   System.Object[] logic_uScriptAct_Log_Target_11 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_11 = "";
   bool logic_uScriptAct_Log_Out_11 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBoolState logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_14 = new uScriptCon_CompareBoolState( );
   System.Boolean logic_uScriptCon_CompareBoolState_target_14 = (bool) false;
   System.Boolean logic_uScriptCon_CompareBoolState_previousState_14 = (bool) false;
   bool logic_uScriptCon_CompareBoolState_Out_14 = true;
   bool logic_uScriptCon_CompareBoolState_IsTrue_14 = true;
   bool logic_uScriptCon_CompareBoolState_IsFalse_14 = true;
   bool logic_uScriptCon_CompareBoolState_WasTrue_14 = true;
   bool logic_uScriptCon_CompareBoolState_WasFalse_14 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_15 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_15 = "";
   System.Object[] logic_uScriptAct_Log_Target_15 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_15 = "";
   bool logic_uScriptAct_Log_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_16 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_16 = "";
   System.Object[] logic_uScriptAct_Log_Target_16 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_16 = "";
   bool logic_uScriptAct_Log_Out_16 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_17 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_17;
   bool logic_uScriptAct_SetBool_Out_17 = true;
   bool logic_uScriptAct_SetBool_SetTrue_17 = true;
   bool logic_uScriptAct_SetBool_SetFalse_17 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBoolState logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_21 = new uScriptCon_CompareBoolState( );
   System.Boolean logic_uScriptCon_CompareBoolState_target_21 = (bool) false;
   System.Boolean logic_uScriptCon_CompareBoolState_previousState_21 = (bool) false;
   bool logic_uScriptCon_CompareBoolState_Out_21 = true;
   bool logic_uScriptCon_CompareBoolState_IsTrue_21 = true;
   bool logic_uScriptCon_CompareBoolState_IsFalse_21 = true;
   bool logic_uScriptCon_CompareBoolState_WasTrue_21 = true;
   bool logic_uScriptCon_CompareBoolState_WasFalse_21 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_22 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_22 = "";
   System.Object[] logic_uScriptAct_Log_Target_22 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_22 = "";
   bool logic_uScriptAct_Log_Out_22 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_23 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_23 = "";
   System.Object[] logic_uScriptAct_Log_Target_23 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_23 = "";
   bool logic_uScriptAct_Log_Out_23 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_24 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_24;
   bool logic_uScriptAct_SetBool_Out_24 = true;
   bool logic_uScriptAct_SetBool_SetTrue_24 = true;
   bool logic_uScriptAct_SetBool_SetFalse_24 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBoolState logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_28 = new uScriptCon_CompareBoolState( );
   System.Boolean logic_uScriptCon_CompareBoolState_target_28 = (bool) false;
   System.Boolean logic_uScriptCon_CompareBoolState_previousState_28 = (bool) false;
   bool logic_uScriptCon_CompareBoolState_Out_28 = true;
   bool logic_uScriptCon_CompareBoolState_IsTrue_28 = true;
   bool logic_uScriptCon_CompareBoolState_IsFalse_28 = true;
   bool logic_uScriptCon_CompareBoolState_WasTrue_28 = true;
   bool logic_uScriptCon_CompareBoolState_WasFalse_28 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_29 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_29 = "";
   System.Object[] logic_uScriptAct_Log_Target_29 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_29 = "";
   bool logic_uScriptAct_Log_Out_29 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_30 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_30 = "";
   System.Object[] logic_uScriptAct_Log_Target_30 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_30 = "";
   bool logic_uScriptAct_Log_Out_30 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_31 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_31;
   bool logic_uScriptAct_SetBool_Out_31 = true;
   bool logic_uScriptAct_SetBool_SetTrue_31 = true;
   bool logic_uScriptAct_SetBool_SetFalse_31 = true;
   //pointer to script instanced logic node
   uScriptAct_AccessListGameObject logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_36 = new uScriptAct_AccessListGameObject( );
   UnityEngine.GameObject[] logic_uScriptAct_AccessListGameObject_GameObjectList_36 = new UnityEngine.GameObject[] {};
   System.Int32 logic_uScriptAct_AccessListGameObject_Index_36 = (int) 0;
   UnityEngine.GameObject logic_uScriptAct_AccessListGameObject_GameObj_36;
   bool logic_uScriptAct_AccessListGameObject_Out_36 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnPrefabAtLocation logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_39 = new uScriptAct_SpawnPrefabAtLocation( );
   System.String logic_uScriptAct_SpawnPrefabAtLocation_PrefabName_39 = "";
   System.String logic_uScriptAct_SpawnPrefabAtLocation_ResourcePath_39 = "";
   UnityEngine.Vector3 logic_uScriptAct_SpawnPrefabAtLocation_SpawnPosition_39 = new Vector3( (float)-2, (float)-4, (float)0 );
   UnityEngine.Quaternion logic_uScriptAct_SpawnPrefabAtLocation_SpawnRotation_39 = new Quaternion( (float)0, (float)0, (float)0, (float)0 );
   System.String logic_uScriptAct_SpawnPrefabAtLocation_SpawnedName_39 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnPrefabAtLocation_SpawnedGameObject_39;
   System.Int32 logic_uScriptAct_SpawnPrefabAtLocation_SpawnedInstancedID_39;
   bool logic_uScriptAct_SpawnPrefabAtLocation_Immediate_39 = true;
   //pointer to script instanced logic node
   uScriptAct_GetGameObjectName logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_40 = new uScriptAct_GetGameObjectName( );
   UnityEngine.GameObject logic_uScriptAct_GetGameObjectName_gameObject_40 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetGameObjectName_name_40;
   bool logic_uScriptAct_GetGameObjectName_Out_40 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnPrefabAtLocation logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_43 = new uScriptAct_SpawnPrefabAtLocation( );
   System.String logic_uScriptAct_SpawnPrefabAtLocation_PrefabName_43 = "";
   System.String logic_uScriptAct_SpawnPrefabAtLocation_ResourcePath_43 = "";
   UnityEngine.Vector3 logic_uScriptAct_SpawnPrefabAtLocation_SpawnPosition_43 = new Vector3( (float)-1, (float)-4, (float)0 );
   UnityEngine.Quaternion logic_uScriptAct_SpawnPrefabAtLocation_SpawnRotation_43 = new Quaternion( (float)0, (float)0, (float)0, (float)0 );
   System.String logic_uScriptAct_SpawnPrefabAtLocation_SpawnedName_43 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnPrefabAtLocation_SpawnedGameObject_43;
   System.Int32 logic_uScriptAct_SpawnPrefabAtLocation_SpawnedInstancedID_43;
   bool logic_uScriptAct_SpawnPrefabAtLocation_Immediate_43 = true;
   //pointer to script instanced logic node
   uScriptAct_AccessListGameObject logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_45 = new uScriptAct_AccessListGameObject( );
   UnityEngine.GameObject[] logic_uScriptAct_AccessListGameObject_GameObjectList_45 = new UnityEngine.GameObject[] {};
   System.Int32 logic_uScriptAct_AccessListGameObject_Index_45 = (int) 0;
   UnityEngine.GameObject logic_uScriptAct_AccessListGameObject_GameObj_45;
   bool logic_uScriptAct_AccessListGameObject_Out_45 = true;
   //pointer to script instanced logic node
   uScriptAct_GetGameObjectName logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_47 = new uScriptAct_GetGameObjectName( );
   UnityEngine.GameObject logic_uScriptAct_GetGameObjectName_gameObject_47 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetGameObjectName_name_47;
   bool logic_uScriptAct_GetGameObjectName_Out_47 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnPrefabAtLocation logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_49 = new uScriptAct_SpawnPrefabAtLocation( );
   System.String logic_uScriptAct_SpawnPrefabAtLocation_PrefabName_49 = "";
   System.String logic_uScriptAct_SpawnPrefabAtLocation_ResourcePath_49 = "";
   UnityEngine.Vector3 logic_uScriptAct_SpawnPrefabAtLocation_SpawnPosition_49 = new Vector3( (float)1, (float)-4, (float)0 );
   UnityEngine.Quaternion logic_uScriptAct_SpawnPrefabAtLocation_SpawnRotation_49 = new Quaternion( (float)0, (float)0, (float)0, (float)0 );
   System.String logic_uScriptAct_SpawnPrefabAtLocation_SpawnedName_49 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnPrefabAtLocation_SpawnedGameObject_49;
   System.Int32 logic_uScriptAct_SpawnPrefabAtLocation_SpawnedInstancedID_49;
   bool logic_uScriptAct_SpawnPrefabAtLocation_Immediate_49 = true;
   //pointer to script instanced logic node
   uScriptAct_AccessListGameObject logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_51 = new uScriptAct_AccessListGameObject( );
   UnityEngine.GameObject[] logic_uScriptAct_AccessListGameObject_GameObjectList_51 = new UnityEngine.GameObject[] {};
   System.Int32 logic_uScriptAct_AccessListGameObject_Index_51 = (int) 0;
   UnityEngine.GameObject logic_uScriptAct_AccessListGameObject_GameObj_51;
   bool logic_uScriptAct_AccessListGameObject_Out_51 = true;
   //pointer to script instanced logic node
   uScriptAct_GetGameObjectName logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_53 = new uScriptAct_GetGameObjectName( );
   UnityEngine.GameObject logic_uScriptAct_GetGameObjectName_gameObject_53 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetGameObjectName_name_53;
   bool logic_uScriptAct_GetGameObjectName_Out_53 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnPrefabAtLocation logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_55 = new uScriptAct_SpawnPrefabAtLocation( );
   System.String logic_uScriptAct_SpawnPrefabAtLocation_PrefabName_55 = "";
   System.String logic_uScriptAct_SpawnPrefabAtLocation_ResourcePath_55 = "";
   UnityEngine.Vector3 logic_uScriptAct_SpawnPrefabAtLocation_SpawnPosition_55 = new Vector3( (float)2, (float)-4, (float)0 );
   UnityEngine.Quaternion logic_uScriptAct_SpawnPrefabAtLocation_SpawnRotation_55 = new Quaternion( (float)0, (float)0, (float)0, (float)0 );
   System.String logic_uScriptAct_SpawnPrefabAtLocation_SpawnedName_55 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnPrefabAtLocation_SpawnedGameObject_55;
   System.Int32 logic_uScriptAct_SpawnPrefabAtLocation_SpawnedInstancedID_55;
   bool logic_uScriptAct_SpawnPrefabAtLocation_Immediate_55 = true;
   //pointer to script instanced logic node
   uScriptAct_AccessListGameObject logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_57 = new uScriptAct_AccessListGameObject( );
   UnityEngine.GameObject[] logic_uScriptAct_AccessListGameObject_GameObjectList_57 = new UnityEngine.GameObject[] {};
   System.Int32 logic_uScriptAct_AccessListGameObject_Index_57 = (int) 0;
   UnityEngine.GameObject logic_uScriptAct_AccessListGameObject_GameObj_57;
   bool logic_uScriptAct_AccessListGameObject_Out_57 = true;
   //pointer to script instanced logic node
   uScriptAct_GetGameObjectName logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_59 = new uScriptAct_GetGameObjectName( );
   UnityEngine.GameObject logic_uScriptAct_GetGameObjectName_gameObject_59 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_GetGameObjectName_name_59;
   bool logic_uScriptAct_GetGameObjectName_Out_59 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectPosition logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_60 = new uScriptAct_SetGameObjectPosition( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectPosition_Target_60 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectPosition_Position_60 = new Vector3( (float)-2, (float)-3.4, (float)0 );
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsOffset_60 = (bool) false;
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsLocal_60 = (bool) false;
   bool logic_uScriptAct_SetGameObjectPosition_Out_60 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectPosition logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_63 = new uScriptAct_SetGameObjectPosition( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectPosition_Target_63 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectPosition_Position_63 = new Vector3( (float)-1, (float)-3.4, (float)0 );
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsOffset_63 = (bool) false;
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsLocal_63 = (bool) false;
   bool logic_uScriptAct_SetGameObjectPosition_Out_63 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectPosition logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_65 = new uScriptAct_SetGameObjectPosition( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectPosition_Target_65 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectPosition_Position_65 = new Vector3( (float)1, (float)-3.4, (float)0 );
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsOffset_65 = (bool) false;
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsLocal_65 = (bool) false;
   bool logic_uScriptAct_SetGameObjectPosition_Out_65 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectPosition logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_67 = new uScriptAct_SetGameObjectPosition( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectPosition_Target_67 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectPosition_Position_67 = new Vector3( (float)2, (float)-3.4, (float)0 );
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsOffset_67 = (bool) false;
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsLocal_67 = (bool) false;
   bool logic_uScriptAct_SetGameObjectPosition_Out_67 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_4 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_13 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_20 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_27 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_38_UnityEngine_GameObject_previous != local_38_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_38_UnityEngine_GameObject_previous = local_38_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_44_UnityEngine_GameObject_previous != local_44_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_44_UnityEngine_GameObject_previous = local_44_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_50_UnityEngine_GameObject_previous != local_50_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_50_UnityEngine_GameObject_previous = local_50_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_56_UnityEngine_GameObject_previous != local_56_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_56_UnityEngine_GameObject_previous = local_56_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_61_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_61_UnityEngine_GameObject = GameObject.Find( "Brody" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_61_UnityEngine_GameObject_previous != local_61_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_61_UnityEngine_GameObject_previous = local_61_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_62_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_62_UnityEngine_GameObject = GameObject.Find( "Brody" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_62_UnityEngine_GameObject_previous != local_62_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_62_UnityEngine_GameObject_previous = local_62_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_64_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_64_UnityEngine_GameObject = GameObject.Find( "Brody" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_64_UnityEngine_GameObject_previous != local_64_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_64_UnityEngine_GameObject_previous = local_64_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_66_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_66_UnityEngine_GameObject = GameObject.Find( "Brody" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_66_UnityEngine_GameObject_previous != local_66_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_66_UnityEngine_GameObject_previous = local_66_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_38_UnityEngine_GameObject_previous != local_38_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_38_UnityEngine_GameObject_previous = local_38_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_44_UnityEngine_GameObject_previous != local_44_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_44_UnityEngine_GameObject_previous = local_44_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_50_UnityEngine_GameObject_previous != local_50_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_50_UnityEngine_GameObject_previous = local_50_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_56_UnityEngine_GameObject_previous != local_56_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_56_UnityEngine_GameObject_previous = local_56_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_61_UnityEngine_GameObject_previous != local_61_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_61_UnityEngine_GameObject_previous = local_61_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_62_UnityEngine_GameObject_previous != local_62_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_62_UnityEngine_GameObject_previous = local_62_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_64_UnityEngine_GameObject_previous != local_64_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_64_UnityEngine_GameObject_previous = local_64_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_66_UnityEngine_GameObject_previous != local_66_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_66_UnityEngine_GameObject_previous = local_66_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_4 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_4 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_4 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_4.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_4.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_4;
                  component.OnLateUpdate += Instance_OnLateUpdate_4;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_4;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_13 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_13 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_13 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_13.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_13.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_13;
                  component.OnLateUpdate += Instance_OnLateUpdate_13;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_13;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_20 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_20 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_20 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_20.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_20.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_20;
                  component.OnLateUpdate += Instance_OnLateUpdate_20;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_20;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_27 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_27 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_27 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_27.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_27.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_27;
                  component.OnLateUpdate += Instance_OnLateUpdate_27;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_27;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_4 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_4.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_4;
               component.OnLateUpdate -= Instance_OnLateUpdate_4;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_4;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_13 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_13.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_13;
               component.OnLateUpdate -= Instance_OnLateUpdate_13;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_13;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_20 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_20.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_20;
               component.OnLateUpdate -= Instance_OnLateUpdate_20;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_20;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_27 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_27.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_27;
               component.OnLateUpdate -= Instance_OnLateUpdate_27;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_27;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_5.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_6.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_8.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_11.SetParent(g);
      logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_14.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_15.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_16.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_17.SetParent(g);
      logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_21.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_22.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_23.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_24.SetParent(g);
      logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_28.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_29.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_30.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_31.SetParent(g);
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_36.SetParent(g);
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_39.SetParent(g);
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_40.SetParent(g);
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_43.SetParent(g);
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_45.SetParent(g);
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_47.SetParent(g);
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_49.SetParent(g);
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_51.SetParent(g);
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_53.SetParent(g);
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_55.SetParent(g);
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_57.SetParent(g);
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_59.SetParent(g);
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_60.SetParent(g);
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_63.SetParent(g);
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_65.SetParent(g);
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_67.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_39.FinishedSpawning += uScriptAct_SpawnPrefabAtLocation_FinishedSpawning_39;
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_43.FinishedSpawning += uScriptAct_SpawnPrefabAtLocation_FinishedSpawning_43;
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_49.FinishedSpawning += uScriptAct_SpawnPrefabAtLocation_FinishedSpawning_49;
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_55.FinishedSpawning += uScriptAct_SpawnPrefabAtLocation_FinishedSpawning_55;
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_39.Update( );
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_43.Update( );
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_49.Update( );
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_55.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_39.FinishedSpawning -= uScriptAct_SpawnPrefabAtLocation_FinishedSpawning_39;
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_43.FinishedSpawning -= uScriptAct_SpawnPrefabAtLocation_FinishedSpawning_43;
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_49.FinishedSpawning -= uScriptAct_SpawnPrefabAtLocation_FinishedSpawning_49;
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_55.FinishedSpawning -= uScriptAct_SpawnPrefabAtLocation_FinishedSpawning_55;
   }
   
   void Instance_OnUpdate_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_4( );
   }
   
   void Instance_OnLateUpdate_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_4( );
   }
   
   void Instance_OnFixedUpdate_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_4( );
   }
   
   void Instance_OnUpdate_13(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_13( );
   }
   
   void Instance_OnLateUpdate_13(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_13( );
   }
   
   void Instance_OnFixedUpdate_13(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_13( );
   }
   
   void Instance_OnUpdate_20(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_20( );
   }
   
   void Instance_OnLateUpdate_20(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_20( );
   }
   
   void Instance_OnFixedUpdate_20(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_20( );
   }
   
   void Instance_OnUpdate_27(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_27( );
   }
   
   void Instance_OnLateUpdate_27(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_27( );
   }
   
   void Instance_OnFixedUpdate_27(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_27( );
   }
   
   void uScriptAct_SpawnPrefabAtLocation_FinishedSpawning_39(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 0
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_39( );
   }
   
   void uScriptAct_SpawnPrefabAtLocation_FinishedSpawning_43(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 0
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_43( );
   }
   
   void uScriptAct_SpawnPrefabAtLocation_FinishedSpawning_49(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 0
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_49( );
   }
   
   void uScriptAct_SpawnPrefabAtLocation_FinishedSpawning_55(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 0
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_55( );
   }
   
   void Relay_OnUpdate_4()
   {
      Relay_In_5();
   }
   
   void Relay_OnLateUpdate_4()
   {
   }
   
   void Relay_OnFixedUpdate_4()
   {
   }
   
   void Relay_In_5()
   {
      {
         {
            logic_uScriptCon_CompareBoolState_target_5 = FoodPressed01;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_5.In(logic_uScriptCon_CompareBoolState_target_5, ref logic_uScriptCon_CompareBoolState_previousState_5);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_5.IsTrue;
      
      if ( test_0 == true )
      {
         Relay_In_6();
      }
   }
   
   void Relay_In_6()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_6.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_6, index + 1);
            }
            logic_uScriptAct_Log_Target_6[ index++ ] = local_7_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_6.In(logic_uScriptAct_Log_Prefix_6, logic_uScriptAct_Log_Target_6, logic_uScriptAct_Log_Postfix_6);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_6.Out;
      
      if ( test_0 == true )
      {
         Relay_False_8();
      }
   }
   
   void Relay_True_8()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_8.True(out logic_uScriptAct_SetBool_Target_8);
      FoodPressed01 = logic_uScriptAct_SetBool_Target_8;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_8.SetFalse;
      
      if ( test_0 == true )
      {
         Relay_In_11();
      }
   }
   
   void Relay_False_8()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_8.False(out logic_uScriptAct_SetBool_Target_8);
      FoodPressed01 = logic_uScriptAct_SetBool_Target_8;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_8.SetFalse;
      
      if ( test_0 == true )
      {
         Relay_In_11();
      }
   }
   
   void Relay_In_11()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_11.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_11, index + 1);
            }
            logic_uScriptAct_Log_Target_11[ index++ ] = local_10_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_11.In(logic_uScriptAct_Log_Prefix_11, logic_uScriptAct_Log_Target_11, logic_uScriptAct_Log_Postfix_11);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_11.Out;
      
      if ( test_0 == true )
      {
         Relay_Random_36();
      }
   }
   
   void Relay_OnUpdate_13()
   {
      Relay_In_14();
   }
   
   void Relay_OnLateUpdate_13()
   {
   }
   
   void Relay_OnFixedUpdate_13()
   {
   }
   
   void Relay_In_14()
   {
      {
         {
            logic_uScriptCon_CompareBoolState_target_14 = FoodPressed02;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_14.In(logic_uScriptCon_CompareBoolState_target_14, ref logic_uScriptCon_CompareBoolState_previousState_14);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_14.IsTrue;
      
      if ( test_0 == true )
      {
         Relay_In_15();
      }
   }
   
   void Relay_In_15()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_15.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_15, index + 1);
            }
            logic_uScriptAct_Log_Target_15[ index++ ] = local_12_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_15.In(logic_uScriptAct_Log_Prefix_15, logic_uScriptAct_Log_Target_15, logic_uScriptAct_Log_Postfix_15);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_15.Out;
      
      if ( test_0 == true )
      {
         Relay_False_17();
      }
   }
   
   void Relay_In_16()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_16.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_16, index + 1);
            }
            logic_uScriptAct_Log_Target_16[ index++ ] = local_18_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_16.In(logic_uScriptAct_Log_Prefix_16, logic_uScriptAct_Log_Target_16, logic_uScriptAct_Log_Postfix_16);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_16.Out;
      
      if ( test_0 == true )
      {
         Relay_Random_45();
      }
   }
   
   void Relay_True_17()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_17.True(out logic_uScriptAct_SetBool_Target_17);
      FoodPressed02 = logic_uScriptAct_SetBool_Target_17;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_17.SetFalse;
      
      if ( test_0 == true )
      {
         Relay_In_16();
      }
   }
   
   void Relay_False_17()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_17.False(out logic_uScriptAct_SetBool_Target_17);
      FoodPressed02 = logic_uScriptAct_SetBool_Target_17;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_17.SetFalse;
      
      if ( test_0 == true )
      {
         Relay_In_16();
      }
   }
   
   void Relay_OnUpdate_20()
   {
      Relay_In_21();
   }
   
   void Relay_OnLateUpdate_20()
   {
   }
   
   void Relay_OnFixedUpdate_20()
   {
   }
   
   void Relay_In_21()
   {
      {
         {
            logic_uScriptCon_CompareBoolState_target_21 = FoodPressed03;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_21.In(logic_uScriptCon_CompareBoolState_target_21, ref logic_uScriptCon_CompareBoolState_previousState_21);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_21.IsTrue;
      
      if ( test_0 == true )
      {
         Relay_In_22();
      }
   }
   
   void Relay_In_22()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_22.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_22, index + 1);
            }
            logic_uScriptAct_Log_Target_22[ index++ ] = local_19_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_22.In(logic_uScriptAct_Log_Prefix_22, logic_uScriptAct_Log_Target_22, logic_uScriptAct_Log_Postfix_22);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_22.Out;
      
      if ( test_0 == true )
      {
         Relay_False_24();
      }
   }
   
   void Relay_In_23()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_23.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_23, index + 1);
            }
            logic_uScriptAct_Log_Target_23[ index++ ] = local_25_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_23.In(logic_uScriptAct_Log_Prefix_23, logic_uScriptAct_Log_Target_23, logic_uScriptAct_Log_Postfix_23);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_23.Out;
      
      if ( test_0 == true )
      {
         Relay_Random_51();
      }
   }
   
   void Relay_True_24()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_24.True(out logic_uScriptAct_SetBool_Target_24);
      FoodPressed03 = logic_uScriptAct_SetBool_Target_24;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_24.SetFalse;
      
      if ( test_0 == true )
      {
         Relay_In_23();
      }
   }
   
   void Relay_False_24()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_24.False(out logic_uScriptAct_SetBool_Target_24);
      FoodPressed03 = logic_uScriptAct_SetBool_Target_24;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_24.SetFalse;
      
      if ( test_0 == true )
      {
         Relay_In_23();
      }
   }
   
   void Relay_OnUpdate_27()
   {
      Relay_In_28();
   }
   
   void Relay_OnLateUpdate_27()
   {
   }
   
   void Relay_OnFixedUpdate_27()
   {
   }
   
   void Relay_In_28()
   {
      {
         {
            logic_uScriptCon_CompareBoolState_target_28 = FoodPressed04;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_28.In(logic_uScriptCon_CompareBoolState_target_28, ref logic_uScriptCon_CompareBoolState_previousState_28);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_28.IsTrue;
      
      if ( test_0 == true )
      {
         Relay_In_29();
      }
   }
   
   void Relay_In_29()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_29.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_29, index + 1);
            }
            logic_uScriptAct_Log_Target_29[ index++ ] = local_26_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_29.In(logic_uScriptAct_Log_Prefix_29, logic_uScriptAct_Log_Target_29, logic_uScriptAct_Log_Postfix_29);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_29.Out;
      
      if ( test_0 == true )
      {
         Relay_False_31();
      }
   }
   
   void Relay_In_30()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_30.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_30, index + 1);
            }
            logic_uScriptAct_Log_Target_30[ index++ ] = local_32_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_30.In(logic_uScriptAct_Log_Prefix_30, logic_uScriptAct_Log_Target_30, logic_uScriptAct_Log_Postfix_30);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_30.Out;
      
      if ( test_0 == true )
      {
         Relay_Random_57();
      }
   }
   
   void Relay_True_31()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_31.True(out logic_uScriptAct_SetBool_Target_31);
      FoodPressed04 = logic_uScriptAct_SetBool_Target_31;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_31.SetFalse;
      
      if ( test_0 == true )
      {
         Relay_In_30();
      }
   }
   
   void Relay_False_31()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_31.False(out logic_uScriptAct_SetBool_Target_31);
      FoodPressed04 = logic_uScriptAct_SetBool_Target_31;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_31.SetFalse;
      
      if ( test_0 == true )
      {
         Relay_In_30();
      }
   }
   
   void Relay_First_36()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_36.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_36, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_36, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_36.First(logic_uScriptAct_AccessListGameObject_GameObjectList_36, logic_uScriptAct_AccessListGameObject_Index_36, out logic_uScriptAct_AccessListGameObject_GameObj_36);
      local_38_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_36;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_38_UnityEngine_GameObject_previous != local_38_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_38_UnityEngine_GameObject_previous = local_38_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_36.Out;
      
      if ( test_0 == true )
      {
         Relay_In_40();
      }
   }
   
   void Relay_Last_36()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_36.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_36, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_36, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_36.Last(logic_uScriptAct_AccessListGameObject_GameObjectList_36, logic_uScriptAct_AccessListGameObject_Index_36, out logic_uScriptAct_AccessListGameObject_GameObj_36);
      local_38_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_36;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_38_UnityEngine_GameObject_previous != local_38_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_38_UnityEngine_GameObject_previous = local_38_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_36.Out;
      
      if ( test_0 == true )
      {
         Relay_In_40();
      }
   }
   
   void Relay_Random_36()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_36.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_36, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_36, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_36.Random(logic_uScriptAct_AccessListGameObject_GameObjectList_36, logic_uScriptAct_AccessListGameObject_Index_36, out logic_uScriptAct_AccessListGameObject_GameObj_36);
      local_38_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_36;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_38_UnityEngine_GameObject_previous != local_38_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_38_UnityEngine_GameObject_previous = local_38_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_36.Out;
      
      if ( test_0 == true )
      {
         Relay_In_40();
      }
   }
   
   void Relay_AtIndex_36()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_36.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_36, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_36, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_36.AtIndex(logic_uScriptAct_AccessListGameObject_GameObjectList_36, logic_uScriptAct_AccessListGameObject_Index_36, out logic_uScriptAct_AccessListGameObject_GameObj_36);
      local_38_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_36;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_38_UnityEngine_GameObject_previous != local_38_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_38_UnityEngine_GameObject_previous = local_38_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_36.Out;
      
      if ( test_0 == true )
      {
         Relay_In_40();
      }
   }
   
   void Relay_FinishedSpawning_39()
   {
      Relay_In_60();
   }
   
   void Relay_In_39()
   {
      {
         {
            logic_uScriptAct_SpawnPrefabAtLocation_PrefabName_39 = local_41_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_39.In(logic_uScriptAct_SpawnPrefabAtLocation_PrefabName_39, logic_uScriptAct_SpawnPrefabAtLocation_ResourcePath_39, logic_uScriptAct_SpawnPrefabAtLocation_SpawnPosition_39, logic_uScriptAct_SpawnPrefabAtLocation_SpawnRotation_39, logic_uScriptAct_SpawnPrefabAtLocation_SpawnedName_39, out logic_uScriptAct_SpawnPrefabAtLocation_SpawnedGameObject_39, out logic_uScriptAct_SpawnPrefabAtLocation_SpawnedInstancedID_39);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_40()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_38_UnityEngine_GameObject_previous != local_38_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_38_UnityEngine_GameObject_previous = local_38_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetGameObjectName_gameObject_40 = local_38_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_40.In(logic_uScriptAct_GetGameObjectName_gameObject_40, out logic_uScriptAct_GetGameObjectName_name_40);
      local_41_System_String = logic_uScriptAct_GetGameObjectName_name_40;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_40.Out;
      
      if ( test_0 == true )
      {
         Relay_In_39();
      }
   }
   
   void Relay_FinishedSpawning_43()
   {
      Relay_In_63();
   }
   
   void Relay_In_43()
   {
      {
         {
            logic_uScriptAct_SpawnPrefabAtLocation_PrefabName_43 = local_42_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_43.In(logic_uScriptAct_SpawnPrefabAtLocation_PrefabName_43, logic_uScriptAct_SpawnPrefabAtLocation_ResourcePath_43, logic_uScriptAct_SpawnPrefabAtLocation_SpawnPosition_43, logic_uScriptAct_SpawnPrefabAtLocation_SpawnRotation_43, logic_uScriptAct_SpawnPrefabAtLocation_SpawnedName_43, out logic_uScriptAct_SpawnPrefabAtLocation_SpawnedGameObject_43, out logic_uScriptAct_SpawnPrefabAtLocation_SpawnedInstancedID_43);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_First_45()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_45.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_45, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_45, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_45.First(logic_uScriptAct_AccessListGameObject_GameObjectList_45, logic_uScriptAct_AccessListGameObject_Index_45, out logic_uScriptAct_AccessListGameObject_GameObj_45);
      local_44_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_45;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_44_UnityEngine_GameObject_previous != local_44_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_44_UnityEngine_GameObject_previous = local_44_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_45.Out;
      
      if ( test_0 == true )
      {
         Relay_In_47();
      }
   }
   
   void Relay_Last_45()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_45.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_45, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_45, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_45.Last(logic_uScriptAct_AccessListGameObject_GameObjectList_45, logic_uScriptAct_AccessListGameObject_Index_45, out logic_uScriptAct_AccessListGameObject_GameObj_45);
      local_44_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_45;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_44_UnityEngine_GameObject_previous != local_44_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_44_UnityEngine_GameObject_previous = local_44_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_45.Out;
      
      if ( test_0 == true )
      {
         Relay_In_47();
      }
   }
   
   void Relay_Random_45()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_45.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_45, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_45, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_45.Random(logic_uScriptAct_AccessListGameObject_GameObjectList_45, logic_uScriptAct_AccessListGameObject_Index_45, out logic_uScriptAct_AccessListGameObject_GameObj_45);
      local_44_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_45;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_44_UnityEngine_GameObject_previous != local_44_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_44_UnityEngine_GameObject_previous = local_44_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_45.Out;
      
      if ( test_0 == true )
      {
         Relay_In_47();
      }
   }
   
   void Relay_AtIndex_45()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_45.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_45, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_45, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_45.AtIndex(logic_uScriptAct_AccessListGameObject_GameObjectList_45, logic_uScriptAct_AccessListGameObject_Index_45, out logic_uScriptAct_AccessListGameObject_GameObj_45);
      local_44_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_45;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_44_UnityEngine_GameObject_previous != local_44_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_44_UnityEngine_GameObject_previous = local_44_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_45.Out;
      
      if ( test_0 == true )
      {
         Relay_In_47();
      }
   }
   
   void Relay_In_47()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_44_UnityEngine_GameObject_previous != local_44_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_44_UnityEngine_GameObject_previous = local_44_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetGameObjectName_gameObject_47 = local_44_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_47.In(logic_uScriptAct_GetGameObjectName_gameObject_47, out logic_uScriptAct_GetGameObjectName_name_47);
      local_42_System_String = logic_uScriptAct_GetGameObjectName_name_47;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_47.Out;
      
      if ( test_0 == true )
      {
         Relay_In_43();
      }
   }
   
   void Relay_FinishedSpawning_49()
   {
      Relay_In_65();
   }
   
   void Relay_In_49()
   {
      {
         {
            logic_uScriptAct_SpawnPrefabAtLocation_PrefabName_49 = local_48_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_49.In(logic_uScriptAct_SpawnPrefabAtLocation_PrefabName_49, logic_uScriptAct_SpawnPrefabAtLocation_ResourcePath_49, logic_uScriptAct_SpawnPrefabAtLocation_SpawnPosition_49, logic_uScriptAct_SpawnPrefabAtLocation_SpawnRotation_49, logic_uScriptAct_SpawnPrefabAtLocation_SpawnedName_49, out logic_uScriptAct_SpawnPrefabAtLocation_SpawnedGameObject_49, out logic_uScriptAct_SpawnPrefabAtLocation_SpawnedInstancedID_49);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_First_51()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_51.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_51, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_51, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_51.First(logic_uScriptAct_AccessListGameObject_GameObjectList_51, logic_uScriptAct_AccessListGameObject_Index_51, out logic_uScriptAct_AccessListGameObject_GameObj_51);
      local_50_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_51;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_50_UnityEngine_GameObject_previous != local_50_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_50_UnityEngine_GameObject_previous = local_50_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_51.Out;
      
      if ( test_0 == true )
      {
         Relay_In_53();
      }
   }
   
   void Relay_Last_51()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_51.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_51, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_51, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_51.Last(logic_uScriptAct_AccessListGameObject_GameObjectList_51, logic_uScriptAct_AccessListGameObject_Index_51, out logic_uScriptAct_AccessListGameObject_GameObj_51);
      local_50_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_51;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_50_UnityEngine_GameObject_previous != local_50_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_50_UnityEngine_GameObject_previous = local_50_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_51.Out;
      
      if ( test_0 == true )
      {
         Relay_In_53();
      }
   }
   
   void Relay_Random_51()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_51.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_51, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_51, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_51.Random(logic_uScriptAct_AccessListGameObject_GameObjectList_51, logic_uScriptAct_AccessListGameObject_Index_51, out logic_uScriptAct_AccessListGameObject_GameObj_51);
      local_50_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_51;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_50_UnityEngine_GameObject_previous != local_50_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_50_UnityEngine_GameObject_previous = local_50_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_51.Out;
      
      if ( test_0 == true )
      {
         Relay_In_53();
      }
   }
   
   void Relay_AtIndex_51()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_51.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_51, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_51, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_51.AtIndex(logic_uScriptAct_AccessListGameObject_GameObjectList_51, logic_uScriptAct_AccessListGameObject_Index_51, out logic_uScriptAct_AccessListGameObject_GameObj_51);
      local_50_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_51;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_50_UnityEngine_GameObject_previous != local_50_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_50_UnityEngine_GameObject_previous = local_50_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_51.Out;
      
      if ( test_0 == true )
      {
         Relay_In_53();
      }
   }
   
   void Relay_In_53()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_50_UnityEngine_GameObject_previous != local_50_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_50_UnityEngine_GameObject_previous = local_50_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetGameObjectName_gameObject_53 = local_50_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_53.In(logic_uScriptAct_GetGameObjectName_gameObject_53, out logic_uScriptAct_GetGameObjectName_name_53);
      local_48_System_String = logic_uScriptAct_GetGameObjectName_name_53;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_53.Out;
      
      if ( test_0 == true )
      {
         Relay_In_49();
      }
   }
   
   void Relay_FinishedSpawning_55()
   {
      Relay_In_67();
   }
   
   void Relay_In_55()
   {
      {
         {
            logic_uScriptAct_SpawnPrefabAtLocation_PrefabName_55 = local_54_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SpawnPrefabAtLocation_uScriptAct_SpawnPrefabAtLocation_55.In(logic_uScriptAct_SpawnPrefabAtLocation_PrefabName_55, logic_uScriptAct_SpawnPrefabAtLocation_ResourcePath_55, logic_uScriptAct_SpawnPrefabAtLocation_SpawnPosition_55, logic_uScriptAct_SpawnPrefabAtLocation_SpawnRotation_55, logic_uScriptAct_SpawnPrefabAtLocation_SpawnedName_55, out logic_uScriptAct_SpawnPrefabAtLocation_SpawnedGameObject_55, out logic_uScriptAct_SpawnPrefabAtLocation_SpawnedInstancedID_55);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_First_57()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_57.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_57, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_57, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_57.First(logic_uScriptAct_AccessListGameObject_GameObjectList_57, logic_uScriptAct_AccessListGameObject_Index_57, out logic_uScriptAct_AccessListGameObject_GameObj_57);
      local_56_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_57;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_56_UnityEngine_GameObject_previous != local_56_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_56_UnityEngine_GameObject_previous = local_56_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_57.Out;
      
      if ( test_0 == true )
      {
         Relay_In_59();
      }
   }
   
   void Relay_Last_57()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_57.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_57, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_57, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_57.Last(logic_uScriptAct_AccessListGameObject_GameObjectList_57, logic_uScriptAct_AccessListGameObject_Index_57, out logic_uScriptAct_AccessListGameObject_GameObj_57);
      local_56_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_57;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_56_UnityEngine_GameObject_previous != local_56_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_56_UnityEngine_GameObject_previous = local_56_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_57.Out;
      
      if ( test_0 == true )
      {
         Relay_In_59();
      }
   }
   
   void Relay_Random_57()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_57.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_57, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_57, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_57.Random(logic_uScriptAct_AccessListGameObject_GameObjectList_57, logic_uScriptAct_AccessListGameObject_Index_57, out logic_uScriptAct_AccessListGameObject_GameObj_57);
      local_56_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_57;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_56_UnityEngine_GameObject_previous != local_56_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_56_UnityEngine_GameObject_previous = local_56_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_57.Out;
      
      if ( test_0 == true )
      {
         Relay_In_59();
      }
   }
   
   void Relay_AtIndex_57()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = FoodList;
            if ( logic_uScriptAct_AccessListGameObject_GameObjectList_57.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_AccessListGameObject_GameObjectList_57, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_AccessListGameObject_GameObjectList_57, index, properties.Length);
            index += properties.Length;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_57.AtIndex(logic_uScriptAct_AccessListGameObject_GameObjectList_57, logic_uScriptAct_AccessListGameObject_Index_57, out logic_uScriptAct_AccessListGameObject_GameObj_57);
      local_56_UnityEngine_GameObject = logic_uScriptAct_AccessListGameObject_GameObj_57;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_56_UnityEngine_GameObject_previous != local_56_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_56_UnityEngine_GameObject_previous = local_56_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AccessListGameObject_uScriptAct_AccessListGameObject_57.Out;
      
      if ( test_0 == true )
      {
         Relay_In_59();
      }
   }
   
   void Relay_In_59()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_56_UnityEngine_GameObject_previous != local_56_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_56_UnityEngine_GameObject_previous = local_56_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetGameObjectName_gameObject_59 = local_56_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_59.In(logic_uScriptAct_GetGameObjectName_gameObject_59, out logic_uScriptAct_GetGameObjectName_name_59);
      local_54_System_String = logic_uScriptAct_GetGameObjectName_name_59;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetGameObjectName_uScriptAct_GetGameObjectName_59.Out;
      
      if ( test_0 == true )
      {
         Relay_In_55();
      }
   }
   
   void Relay_In_60()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_61_UnityEngine_GameObject_previous != local_61_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_61_UnityEngine_GameObject_previous = local_61_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_SetGameObjectPosition_Target_60.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectPosition_Target_60, index + 1);
            }
            logic_uScriptAct_SetGameObjectPosition_Target_60[ index++ ] = local_61_UnityEngine_GameObject;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_60.In(logic_uScriptAct_SetGameObjectPosition_Target_60, logic_uScriptAct_SetGameObjectPosition_Position_60, logic_uScriptAct_SetGameObjectPosition_AsOffset_60, logic_uScriptAct_SetGameObjectPosition_AsLocal_60);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_63()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_62_UnityEngine_GameObject_previous != local_62_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_62_UnityEngine_GameObject_previous = local_62_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_SetGameObjectPosition_Target_63.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectPosition_Target_63, index + 1);
            }
            logic_uScriptAct_SetGameObjectPosition_Target_63[ index++ ] = local_62_UnityEngine_GameObject;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_63.In(logic_uScriptAct_SetGameObjectPosition_Target_63, logic_uScriptAct_SetGameObjectPosition_Position_63, logic_uScriptAct_SetGameObjectPosition_AsOffset_63, logic_uScriptAct_SetGameObjectPosition_AsLocal_63);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_65()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_64_UnityEngine_GameObject_previous != local_64_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_64_UnityEngine_GameObject_previous = local_64_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_SetGameObjectPosition_Target_65.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectPosition_Target_65, index + 1);
            }
            logic_uScriptAct_SetGameObjectPosition_Target_65[ index++ ] = local_64_UnityEngine_GameObject;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_65.In(logic_uScriptAct_SetGameObjectPosition_Target_65, logic_uScriptAct_SetGameObjectPosition_Position_65, logic_uScriptAct_SetGameObjectPosition_AsOffset_65, logic_uScriptAct_SetGameObjectPosition_AsLocal_65);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_67()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_66_UnityEngine_GameObject_previous != local_66_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_66_UnityEngine_GameObject_previous = local_66_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_SetGameObjectPosition_Target_67.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectPosition_Target_67, index + 1);
            }
            logic_uScriptAct_SetGameObjectPosition_Target_67[ index++ ] = local_66_UnityEngine_GameObject;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_67.In(logic_uScriptAct_SetGameObjectPosition_Target_67, logic_uScriptAct_SetGameObjectPosition_Position_67, logic_uScriptAct_SetGameObjectPosition_AsOffset_67, logic_uScriptAct_SetGameObjectPosition_AsLocal_67);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
