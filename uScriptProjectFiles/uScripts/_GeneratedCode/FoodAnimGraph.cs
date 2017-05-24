//uScript Generated Code - Build 1.0.3055
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class FoodAnimGraph : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   UnityEngine.GameObject local_10_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_10_UnityEngine_GameObject_previous = null;
   System.String[] local_13_System_StringArray = new System.String[] {"Food"};
   UnityEngine.GameObject local_15_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_15_UnityEngine_GameObject_previous = null;
   System.String local_16_System_String = "GotFood";
   UnityEngine.Vector3 local_4_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject local_47_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_47_UnityEngine_GameObject_previous = null;
   System.String local_7_System_String = "FoodGraph";
   System.String local_8_System_String = "GotNotFood";
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_2 = null;
   UnityEngine.GameObject owner_Connection_12 = null;
   UnityEngine.GameObject owner_Connection_19 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_0 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_0 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_0 = (bool) true;
   bool logic_uScriptAct_Delay_Immediate_0 = true;
   bool logic_uScriptAct_Delay_AfterDelay_0 = true;
   bool logic_uScriptAct_Delay_Stopped_0 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_0 = false;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocation logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_1 = new uScriptAct_MoveToLocation( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocation_targetArray_1 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocation_location_1 = new Vector3( );
   System.Boolean logic_uScriptAct_MoveToLocation_asOffset_1 = (bool) false;
   System.Single logic_uScriptAct_MoveToLocation_totalTime_1 = (float) 0.4;
   bool logic_uScriptAct_MoveToLocation_Out_1 = true;
   bool logic_uScriptAct_MoveToLocation_Cancelled_1 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPositionAndRotation logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_3 = new uScriptAct_GetPositionAndRotation( );
   UnityEngine.GameObject logic_uScriptAct_GetPositionAndRotation_Target_3 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_GetPositionAndRotation_GetLocal_3 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Position_3;
   UnityEngine.Quaternion logic_uScriptAct_GetPositionAndRotation_Rotation_3;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_EulerAngles_3;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Forward_3;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Up_3;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Right_3;
   bool logic_uScriptAct_GetPositionAndRotation_Out_3 = true;
   //pointer to script instanced logic node
   uScript_GraphEvents logic_uScript_GraphEvents_uScript_GraphEvents_5 = new uScript_GraphEvents( );
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_6 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_6 = "";
   System.Object[] logic_uScriptAct_Log_Target_6 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_6 = "";
   bool logic_uScriptAct_Log_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_SendSignal logic_uScriptAct_SendSignal_uScriptAct_SendSignal_9 = new uScriptAct_SendSignal( );
   UnityEngine.GameObject logic_uScriptAct_SendSignal_objectToSignal_9 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_SendSignal_signalName_9 = "";
   bool logic_uScriptAct_SendSignal_Out_9 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_11 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_11 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_11 = new System.String[] {};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_11 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_11 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_11 = true;
   //pointer to script instanced logic node
   uScriptAct_SendSignal logic_uScriptAct_SendSignal_uScriptAct_SendSignal_14 = new uScriptAct_SendSignal( );
   UnityEngine.GameObject logic_uScriptAct_SendSignal_objectToSignal_14 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_SendSignal_signalName_14 = "";
   bool logic_uScriptAct_SendSignal_Out_14 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_17 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_17 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_17 = (bool) true;
   bool logic_uScriptAct_Delay_Immediate_17 = true;
   bool logic_uScriptAct_Delay_AfterDelay_17 = true;
   bool logic_uScriptAct_Delay_Stopped_17 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_17 = false;
   //pointer to script instanced logic node
   uScriptAct_Destroy logic_uScriptAct_Destroy_uScriptAct_Destroy_18 = new uScriptAct_Destroy( );
   UnityEngine.GameObject[] logic_uScriptAct_Destroy_Target_18 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_Destroy_DelayTime_18 = (float) 0;
   bool logic_uScriptAct_Destroy_Out_18 = true;
   bool logic_uScriptAct_Destroy_ObjectsDestroyed_18 = true;
   bool logic_uScriptAct_Destroy_WaitOneTick_18 = false;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_20 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_20 = "";
   System.Object[] logic_uScriptAct_Log_Target_20 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_20 = "";
   bool logic_uScriptAct_Log_Out_20 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_21 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_21 = "";
   System.Object[] logic_uScriptAct_Log_Target_21 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_21 = "";
   bool logic_uScriptAct_Log_Out_21 = true;
   
   //event nodes
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_10_UnityEngine_GameObject = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_15_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_15_UnityEngine_GameObject = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_15_UnityEngine_GameObject_previous != local_15_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_15_UnityEngine_GameObject_previous = local_15_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_47_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_47_UnityEngine_GameObject = GameObject.Find( "YoMamaMouth" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_47_UnityEngine_GameObject_previous != local_47_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_47_UnityEngine_GameObject_previous = local_47_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == owner_Connection_2 || false == m_RegisteredForEvents )
      {
         owner_Connection_2 = parentGameObject;
      }
      if ( null == owner_Connection_12 || false == m_RegisteredForEvents )
      {
         owner_Connection_12 = parentGameObject;
      }
      if ( null == owner_Connection_19 || false == m_RegisteredForEvents )
      {
         owner_Connection_19 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_15_UnityEngine_GameObject_previous != local_15_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_15_UnityEngine_GameObject_previous = local_15_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_47_UnityEngine_GameObject_previous != local_47_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_47_UnityEngine_GameObject_previous = local_47_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_Delay_uScriptAct_Delay_0.SetParent(g);
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_1.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_3.SetParent(g);
      logic_uScript_GraphEvents_uScript_GraphEvents_5.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_6.SetParent(g);
      logic_uScriptAct_SendSignal_uScriptAct_SendSignal_9.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_11.SetParent(g);
      logic_uScriptAct_SendSignal_uScriptAct_SendSignal_14.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_17.SetParent(g);
      logic_uScriptAct_Destroy_uScriptAct_Destroy_18.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_20.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_21.SetParent(g);
      owner_Connection_2 = parentGameObject;
      owner_Connection_12 = parentGameObject;
      owner_Connection_19 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_1.Finished += uScriptAct_MoveToLocation_Finished_1;
      logic_uScript_GraphEvents_uScript_GraphEvents_5.uScriptEnable += uScript_GraphEvents_uScriptEnable_5;
      logic_uScript_GraphEvents_uScript_GraphEvents_5.uScriptDisable += uScript_GraphEvents_uScriptDisable_5;
      logic_uScript_GraphEvents_uScript_GraphEvents_5.uScriptDestroy += uScript_GraphEvents_uScriptDestroy_5;
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
      logic_uScript_GraphEvents_uScript_GraphEvents_5.OnEnable( );
   }
   
   public void OnDisable()
   {
      logic_uScript_GraphEvents_uScript_GraphEvents_5.OnDisable( );
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_1.Update( );
      if (true == logic_uScriptAct_Delay_DrivenDelay_0)
      {
         Relay_DrivenDelay_0();
      }
      if (true == logic_uScriptAct_Delay_DrivenDelay_17)
      {
         Relay_DrivenDelay_17();
      }
      if (true == logic_uScriptAct_Destroy_WaitOneTick_18)
      {
         Relay_WaitOneTick_18();
      }
   }
   
   public void OnDestroy()
   {
      logic_uScript_GraphEvents_uScript_GraphEvents_5.OnDestroy( );
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_1.Finished -= uScriptAct_MoveToLocation_Finished_1;
      logic_uScript_GraphEvents_uScript_GraphEvents_5.uScriptEnable -= uScript_GraphEvents_uScriptEnable_5;
      logic_uScript_GraphEvents_uScript_GraphEvents_5.uScriptDisable -= uScript_GraphEvents_uScriptDisable_5;
      logic_uScript_GraphEvents_uScript_GraphEvents_5.uScriptDestroy -= uScript_GraphEvents_uScriptDestroy_5;
   }
   
   void uScriptAct_MoveToLocation_Finished_1(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_1( );
   }
   
   void uScript_GraphEvents_uScriptEnable_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptEnable_5( );
   }
   
   void uScript_GraphEvents_uScriptDisable_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptDisable_5( );
   }
   
   void uScript_GraphEvents_uScriptDestroy_5(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptDestroy_5( );
   }
   
   void Relay_In_0()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_0.In(logic_uScriptAct_Delay_Duration_0, logic_uScriptAct_Delay_SingleFrame_0);
      logic_uScriptAct_Delay_DrivenDelay_0 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_0.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_6();
      }
   }
   
   void Relay_Stop_0()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_0.Stop(logic_uScriptAct_Delay_Duration_0, logic_uScriptAct_Delay_SingleFrame_0);
      logic_uScriptAct_Delay_DrivenDelay_0 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_0.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_6();
      }
   }
   
   void Relay_DrivenDelay_0( )
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_0 = logic_uScriptAct_Delay_uScriptAct_Delay_0.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_0 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_0.AfterDelay == true )
         {
            Relay_In_6();
         }
      }
   }
   void Relay_Finished_1()
   {
      Relay_In_11();
   }
   
   void Relay_In_1()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_MoveToLocation_targetArray_1.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocation_targetArray_1, index + 1);
            }
            logic_uScriptAct_MoveToLocation_targetArray_1[ index++ ] = owner_Connection_2;
            
         }
         {
            logic_uScriptAct_MoveToLocation_location_1 = local_4_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_1.In(logic_uScriptAct_MoveToLocation_targetArray_1, logic_uScriptAct_MoveToLocation_location_1, logic_uScriptAct_MoveToLocation_asOffset_1, logic_uScriptAct_MoveToLocation_totalTime_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Cancel_1()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_MoveToLocation_targetArray_1.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_MoveToLocation_targetArray_1, index + 1);
            }
            logic_uScriptAct_MoveToLocation_targetArray_1[ index++ ] = owner_Connection_2;
            
         }
         {
            logic_uScriptAct_MoveToLocation_location_1 = local_4_UnityEngine_Vector3;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_1.Cancel(logic_uScriptAct_MoveToLocation_targetArray_1, logic_uScriptAct_MoveToLocation_location_1, logic_uScriptAct_MoveToLocation_asOffset_1, logic_uScriptAct_MoveToLocation_totalTime_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_3()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_47_UnityEngine_GameObject_previous != local_47_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_47_UnityEngine_GameObject_previous = local_47_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetPositionAndRotation_Target_3 = local_47_UnityEngine_GameObject;
            
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
         {
         }
      }
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_3.In(logic_uScriptAct_GetPositionAndRotation_Target_3, logic_uScriptAct_GetPositionAndRotation_GetLocal_3, out logic_uScriptAct_GetPositionAndRotation_Position_3, out logic_uScriptAct_GetPositionAndRotation_Rotation_3, out logic_uScriptAct_GetPositionAndRotation_EulerAngles_3, out logic_uScriptAct_GetPositionAndRotation_Forward_3, out logic_uScriptAct_GetPositionAndRotation_Up_3, out logic_uScriptAct_GetPositionAndRotation_Right_3);
      local_4_UnityEngine_Vector3 = logic_uScriptAct_GetPositionAndRotation_Position_3;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_3.Out;
      
      if ( test_0 == true )
      {
         Relay_In_1();
      }
   }
   
   void Relay_uScriptEnable_5()
   {
      Relay_In_0();
   }
   
   void Relay_uScriptDisable_5()
   {
   }
   
   void Relay_uScriptDestroy_5()
   {
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
         Relay_In_3();
      }
   }
   
   void Relay_SendSignal_9()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_SendSignal_objectToSignal_9 = local_10_UnityEngine_GameObject;
            
         }
         {
            logic_uScriptAct_SendSignal_signalName_9 = local_8_System_String;
            
         }
      }
      logic_uScriptAct_SendSignal_uScriptAct_SendSignal_9.SendSignal(logic_uScriptAct_SendSignal_objectToSignal_9, logic_uScriptAct_SendSignal_signalName_9);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SendSignal_uScriptAct_SendSignal_9.Out;
      
      if ( test_0 == true )
      {
         Relay_In_21();
      }
   }
   
   void Relay_In_11()
   {
      {
         {
            logic_uScriptCon_GameObjectHasTag_GameObject_11 = owner_Connection_12;
            
         }
         {
            System.Array properties;
            int index = 0;
            properties = local_13_System_StringArray;
            if ( logic_uScriptCon_GameObjectHasTag_Tag_11.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptCon_GameObjectHasTag_Tag_11, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptCon_GameObjectHasTag_Tag_11, index, properties.Length);
            index += properties.Length;
            
         }
      }
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_11.In(logic_uScriptCon_GameObjectHasTag_GameObject_11, logic_uScriptCon_GameObjectHasTag_Tag_11);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_11.HasTag;
      bool test_1 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_11.MissingTags;
      
      if ( test_0 == true )
      {
         Relay_SendSignal_14();
      }
      if ( test_1 == true )
      {
         Relay_SendSignal_9();
      }
   }
   
   void Relay_SendSignal_14()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_15_UnityEngine_GameObject_previous != local_15_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_15_UnityEngine_GameObject_previous = local_15_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_SendSignal_objectToSignal_14 = local_15_UnityEngine_GameObject;
            
         }
         {
            logic_uScriptAct_SendSignal_signalName_14 = local_16_System_String;
            
         }
      }
      logic_uScriptAct_SendSignal_uScriptAct_SendSignal_14.SendSignal(logic_uScriptAct_SendSignal_objectToSignal_14, logic_uScriptAct_SendSignal_signalName_14);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SendSignal_uScriptAct_SendSignal_14.Out;
      
      if ( test_0 == true )
      {
         Relay_In_20();
      }
   }
   
   void Relay_In_17()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_17.In(logic_uScriptAct_Delay_Duration_17, logic_uScriptAct_Delay_SingleFrame_17);
      logic_uScriptAct_Delay_DrivenDelay_17 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_17.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_18();
      }
   }
   
   void Relay_Stop_17()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_17.Stop(logic_uScriptAct_Delay_Duration_17, logic_uScriptAct_Delay_SingleFrame_17);
      logic_uScriptAct_Delay_DrivenDelay_17 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_17.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_18();
      }
   }
   
   void Relay_DrivenDelay_17( )
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_17 = logic_uScriptAct_Delay_uScriptAct_Delay_17.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_17 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_17.AfterDelay == true )
         {
            Relay_In_18();
         }
      }
   }
   void Relay_In_18()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_Destroy_Target_18.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Destroy_Target_18, index + 1);
            }
            logic_uScriptAct_Destroy_Target_18[ index++ ] = owner_Connection_19;
            
         }
         {
         }
      }
      logic_uScriptAct_Destroy_uScriptAct_Destroy_18.In(logic_uScriptAct_Destroy_Target_18, logic_uScriptAct_Destroy_DelayTime_18);
      logic_uScriptAct_Destroy_WaitOneTick_18 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_WaitOneTick_18( )
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_Destroy_Target_18.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Destroy_Target_18, index + 1);
            }
            logic_uScriptAct_Destroy_Target_18[ index++ ] = owner_Connection_19;
            
         }
         {
         }
      }
      logic_uScriptAct_Destroy_WaitOneTick_18 = logic_uScriptAct_Destroy_uScriptAct_Destroy_18.WaitOneTick();
      if ( true == logic_uScriptAct_Destroy_WaitOneTick_18 )
      {
      }
   }
   void Relay_In_20()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_20.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_20, index + 1);
            }
            logic_uScriptAct_Log_Target_20[ index++ ] = local_16_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_20.In(logic_uScriptAct_Log_Prefix_20, logic_uScriptAct_Log_Target_20, logic_uScriptAct_Log_Postfix_20);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_20.Out;
      
      if ( test_0 == true )
      {
         Relay_In_17();
      }
   }
   
   void Relay_In_21()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_21.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_21, index + 1);
            }
            logic_uScriptAct_Log_Target_21[ index++ ] = local_8_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_21.In(logic_uScriptAct_Log_Prefix_21, logic_uScriptAct_Log_Target_21, logic_uScriptAct_Log_Postfix_21);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_21.Out;
      
      if ( test_0 == true )
      {
         Relay_In_17();
      }
   }
   
}
