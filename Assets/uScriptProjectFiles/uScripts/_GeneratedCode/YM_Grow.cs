//uScript Generated Code - Build 1.0.3055
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class YM_Grow : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   UnityEngine.GameObject local_1_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_1_UnityEngine_GameObject_previous = null;
   System.Int32 local_12_System_Int32 = (int) 0;
   System.String local_15_System_String = "GROW!";
   System.String local_16_System_String = "YUM!";
   UnityEngine.Vector3 local_19_UnityEngine_Vector3 = new Vector3( (float)0.5, (float)0.5, (float)0.5 );
   System.String local_2_System_String = "";
   System.Int32 local_21_System_Int32 = (int) 0;
   UnityEngine.Vector3 local_23_UnityEngine_Vector3 = new Vector3( (float)0.6, (float)0.6, (float)0.6 );
   System.String local_26_System_String = "YUM!";
   UnityEngine.Vector3 local_28_UnityEngine_Vector3 = new Vector3( (float)0.7, (float)0.7, (float)0.7 );
   System.Int32 local_30_System_Int32 = (int) 0;
   System.String local_35_System_String = "YUM!";
   UnityEngine.Vector3 local_36_UnityEngine_Vector3 = new Vector3( (float)0.8, (float)0.8, (float)0.8 );
   System.Int32 local_38_System_Int32 = (int) 0;
   System.String local_4_System_String = "GotFood";
   System.String local_43_System_String = "YUM!";
   System.String local_44_System_String = "YUM!";
   UnityEngine.Vector3 local_46_UnityEngine_Vector3 = new Vector3( (float)0.9, (float)0.9, (float)0.9 );
   System.Int32 local_51_System_Int32 = (int) 0;
   System.String local_52_System_String = "YUM!";
   UnityEngine.Vector3 local_54_UnityEngine_Vector3 = new Vector3( (float)1, (float)1, (float)1 );
   System.Int32 local_59_System_Int32 = (int) 0;
   System.String local_6_System_String = "";
   System.String local_8_System_String = "GotNotFood";
   UnityEngine.GameObject local_9_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_9_UnityEngine_GameObject_previous = null;
   System.Int32 local_IntFoodAte_System_Int32 = (int) 0;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_18 = null;
   UnityEngine.GameObject owner_Connection_24 = null;
   UnityEngine.GameObject owner_Connection_32 = null;
   UnityEngine.GameObject owner_Connection_40 = null;
   UnityEngine.GameObject owner_Connection_47 = null;
   UnityEngine.GameObject owner_Connection_55 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_3 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_3 = "";
   System.String logic_uScriptCon_CompareString_B_3 = "";
   bool logic_uScriptCon_CompareString_Same_3 = true;
   bool logic_uScriptCon_CompareString_Different_3 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_7 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_7 = "";
   System.String logic_uScriptCon_CompareString_B_7 = "";
   bool logic_uScriptCon_CompareString_Same_7 = true;
   bool logic_uScriptCon_CompareString_Different_7 = true;
   //pointer to script instanced logic node
   uScriptCon_IntCounter logic_uScriptCon_IntCounter_uScriptCon_IntCounter_10 = new uScriptCon_IntCounter( );
   System.Int32 logic_uScriptCon_IntCounter_A_10 = (int) 0;
   System.Int32 logic_uScriptCon_IntCounter_B_10 = (int) 10;
   System.Int32 logic_uScriptCon_IntCounter_currentValue_10;
   bool logic_uScriptCon_IntCounter_GreaterThan_10 = true;
   bool logic_uScriptCon_IntCounter_GreaterThanOrEqualTo_10 = true;
   bool logic_uScriptCon_IntCounter_EqualTo_10 = true;
   bool logic_uScriptCon_IntCounter_LessThanOrEqualTo_10 = true;
   bool logic_uScriptCon_IntCounter_LessThan_10 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_13 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_13 = "";
   System.Object[] logic_uScriptAct_Log_Target_13 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_13 = "";
   bool logic_uScriptAct_Log_Out_13 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_14 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_14 = "";
   System.Object[] logic_uScriptAct_Log_Target_14 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_14 = "";
   bool logic_uScriptAct_Log_Out_14 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectScale logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_17 = new uScriptAct_SetGameObjectScale( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectScale_Target_17 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectScale_Scale_17 = new Vector3( );
   bool logic_uScriptAct_SetGameObjectScale_Out_17 = true;
   //pointer to script instanced logic node
   uScriptCon_IntCounter logic_uScriptCon_IntCounter_uScriptCon_IntCounter_20 = new uScriptCon_IntCounter( );
   System.Int32 logic_uScriptCon_IntCounter_A_20 = (int) 0;
   System.Int32 logic_uScriptCon_IntCounter_B_20 = (int) 10;
   System.Int32 logic_uScriptCon_IntCounter_currentValue_20;
   bool logic_uScriptCon_IntCounter_GreaterThan_20 = true;
   bool logic_uScriptCon_IntCounter_GreaterThanOrEqualTo_20 = true;
   bool logic_uScriptCon_IntCounter_EqualTo_20 = true;
   bool logic_uScriptCon_IntCounter_LessThanOrEqualTo_20 = true;
   bool logic_uScriptCon_IntCounter_LessThan_20 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectScale logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_25 = new uScriptAct_SetGameObjectScale( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectScale_Target_25 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectScale_Scale_25 = new Vector3( );
   bool logic_uScriptAct_SetGameObjectScale_Out_25 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_27 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_27 = "";
   System.Object[] logic_uScriptAct_Log_Target_27 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_27 = "";
   bool logic_uScriptAct_Log_Out_27 = true;
   //pointer to script instanced logic node
   uScriptCon_IntCounter logic_uScriptCon_IntCounter_uScriptCon_IntCounter_29 = new uScriptCon_IntCounter( );
   System.Int32 logic_uScriptCon_IntCounter_A_29 = (int) 0;
   System.Int32 logic_uScriptCon_IntCounter_B_29 = (int) 10;
   System.Int32 logic_uScriptCon_IntCounter_currentValue_29;
   bool logic_uScriptCon_IntCounter_GreaterThan_29 = true;
   bool logic_uScriptCon_IntCounter_GreaterThanOrEqualTo_29 = true;
   bool logic_uScriptCon_IntCounter_EqualTo_29 = true;
   bool logic_uScriptCon_IntCounter_LessThanOrEqualTo_29 = true;
   bool logic_uScriptCon_IntCounter_LessThan_29 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_31 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_31 = "";
   System.Object[] logic_uScriptAct_Log_Target_31 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_31 = "";
   bool logic_uScriptAct_Log_Out_31 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectScale logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_34 = new uScriptAct_SetGameObjectScale( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectScale_Target_34 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectScale_Scale_34 = new Vector3( );
   bool logic_uScriptAct_SetGameObjectScale_Out_34 = true;
   //pointer to script instanced logic node
   uScriptCon_IntCounter logic_uScriptCon_IntCounter_uScriptCon_IntCounter_37 = new uScriptCon_IntCounter( );
   System.Int32 logic_uScriptCon_IntCounter_A_37 = (int) 0;
   System.Int32 logic_uScriptCon_IntCounter_B_37 = (int) 10;
   System.Int32 logic_uScriptCon_IntCounter_currentValue_37;
   bool logic_uScriptCon_IntCounter_GreaterThan_37 = true;
   bool logic_uScriptCon_IntCounter_GreaterThanOrEqualTo_37 = true;
   bool logic_uScriptCon_IntCounter_EqualTo_37 = true;
   bool logic_uScriptCon_IntCounter_LessThanOrEqualTo_37 = true;
   bool logic_uScriptCon_IntCounter_LessThan_37 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_39 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_39 = "";
   System.Object[] logic_uScriptAct_Log_Target_39 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_39 = "";
   bool logic_uScriptAct_Log_Out_39 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectScale logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_42 = new uScriptAct_SetGameObjectScale( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectScale_Target_42 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectScale_Scale_42 = new Vector3( );
   bool logic_uScriptAct_SetGameObjectScale_Out_42 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_48 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_48 = "";
   System.Object[] logic_uScriptAct_Log_Target_48 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_48 = "";
   bool logic_uScriptAct_Log_Out_48 = true;
   //pointer to script instanced logic node
   uScriptCon_IntCounter logic_uScriptCon_IntCounter_uScriptCon_IntCounter_49 = new uScriptCon_IntCounter( );
   System.Int32 logic_uScriptCon_IntCounter_A_49 = (int) 0;
   System.Int32 logic_uScriptCon_IntCounter_B_49 = (int) 10;
   System.Int32 logic_uScriptCon_IntCounter_currentValue_49;
   bool logic_uScriptCon_IntCounter_GreaterThan_49 = true;
   bool logic_uScriptCon_IntCounter_GreaterThanOrEqualTo_49 = true;
   bool logic_uScriptCon_IntCounter_EqualTo_49 = true;
   bool logic_uScriptCon_IntCounter_LessThanOrEqualTo_49 = true;
   bool logic_uScriptCon_IntCounter_LessThan_49 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectScale logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_50 = new uScriptAct_SetGameObjectScale( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectScale_Target_50 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectScale_Scale_50 = new Vector3( );
   bool logic_uScriptAct_SetGameObjectScale_Out_50 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_56 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_56 = "";
   System.Object[] logic_uScriptAct_Log_Target_56 = new System.Object[] {};
   System.Object logic_uScriptAct_Log_Postfix_56 = "";
   bool logic_uScriptAct_Log_Out_56 = true;
   //pointer to script instanced logic node
   uScriptCon_IntCounter logic_uScriptCon_IntCounter_uScriptCon_IntCounter_57 = new uScriptCon_IntCounter( );
   System.Int32 logic_uScriptCon_IntCounter_A_57 = (int) 0;
   System.Int32 logic_uScriptCon_IntCounter_B_57 = (int) 10;
   System.Int32 logic_uScriptCon_IntCounter_currentValue_57;
   bool logic_uScriptCon_IntCounter_GreaterThan_57 = true;
   bool logic_uScriptCon_IntCounter_GreaterThanOrEqualTo_57 = true;
   bool logic_uScriptCon_IntCounter_EqualTo_57 = true;
   bool logic_uScriptCon_IntCounter_LessThanOrEqualTo_57 = true;
   bool logic_uScriptCon_IntCounter_LessThan_57 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectScale logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_58 = new uScriptAct_SetGameObjectScale( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectScale_Target_58 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectScale_Scale_58 = new Vector3( );
   bool logic_uScriptAct_SetGameObjectScale_Out_58 = true;
   
   //event nodes
   System.String event_UnityEngine_GameObject_Signal_0 = "";
   System.String event_UnityEngine_GameObject_Signal_5 = "";
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_1_UnityEngine_GameObject = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_1_UnityEngine_GameObject_previous )
         {
            {
               uScript_ReceiveSignal component = local_1_UnityEngine_GameObject_previous.GetComponent<uScript_ReceiveSignal>();
               if ( null != component )
               {
                  component.OnReceiveSignal -= Instance_OnReceiveSignal_0;
               }
            }
         }
         
         local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_1_UnityEngine_GameObject )
         {
            {
               uScript_ReceiveSignal component = local_1_UnityEngine_GameObject.GetComponent<uScript_ReceiveSignal>();
               if ( null == component )
               {
                  component = local_1_UnityEngine_GameObject.AddComponent<uScript_ReceiveSignal>();
               }
               if ( null != component )
               {
                  component.OnReceiveSignal += Instance_OnReceiveSignal_0;
               }
            }
         }
      }
      if ( null == local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_9_UnityEngine_GameObject = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_9_UnityEngine_GameObject_previous )
         {
            {
               uScript_ReceiveSignal component = local_9_UnityEngine_GameObject_previous.GetComponent<uScript_ReceiveSignal>();
               if ( null != component )
               {
                  component.OnReceiveSignal -= Instance_OnReceiveSignal_5;
               }
            }
         }
         
         local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_9_UnityEngine_GameObject )
         {
            {
               uScript_ReceiveSignal component = local_9_UnityEngine_GameObject.GetComponent<uScript_ReceiveSignal>();
               if ( null == component )
               {
                  component = local_9_UnityEngine_GameObject.AddComponent<uScript_ReceiveSignal>();
               }
               if ( null != component )
               {
                  component.OnReceiveSignal += Instance_OnReceiveSignal_5;
               }
            }
         }
      }
      if ( null == owner_Connection_18 || false == m_RegisteredForEvents )
      {
         owner_Connection_18 = parentGameObject;
      }
      if ( null == owner_Connection_24 || false == m_RegisteredForEvents )
      {
         owner_Connection_24 = parentGameObject;
      }
      if ( null == owner_Connection_32 || false == m_RegisteredForEvents )
      {
         owner_Connection_32 = parentGameObject;
      }
      if ( null == owner_Connection_40 || false == m_RegisteredForEvents )
      {
         owner_Connection_40 = parentGameObject;
      }
      if ( null == owner_Connection_47 || false == m_RegisteredForEvents )
      {
         owner_Connection_47 = parentGameObject;
      }
      if ( null == owner_Connection_55 || false == m_RegisteredForEvents )
      {
         owner_Connection_55 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_1_UnityEngine_GameObject_previous )
         {
            {
               uScript_ReceiveSignal component = local_1_UnityEngine_GameObject_previous.GetComponent<uScript_ReceiveSignal>();
               if ( null != component )
               {
                  component.OnReceiveSignal -= Instance_OnReceiveSignal_0;
               }
            }
         }
         
         local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_1_UnityEngine_GameObject )
         {
            {
               uScript_ReceiveSignal component = local_1_UnityEngine_GameObject.GetComponent<uScript_ReceiveSignal>();
               if ( null == component )
               {
                  component = local_1_UnityEngine_GameObject.AddComponent<uScript_ReceiveSignal>();
               }
               if ( null != component )
               {
                  component.OnReceiveSignal += Instance_OnReceiveSignal_0;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_9_UnityEngine_GameObject_previous )
         {
            {
               uScript_ReceiveSignal component = local_9_UnityEngine_GameObject_previous.GetComponent<uScript_ReceiveSignal>();
               if ( null != component )
               {
                  component.OnReceiveSignal -= Instance_OnReceiveSignal_5;
               }
            }
         }
         
         local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_9_UnityEngine_GameObject )
         {
            {
               uScript_ReceiveSignal component = local_9_UnityEngine_GameObject.GetComponent<uScript_ReceiveSignal>();
               if ( null == component )
               {
                  component = local_9_UnityEngine_GameObject.AddComponent<uScript_ReceiveSignal>();
               }
               if ( null != component )
               {
                  component.OnReceiveSignal += Instance_OnReceiveSignal_5;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != local_1_UnityEngine_GameObject )
      {
         {
            uScript_ReceiveSignal component = local_1_UnityEngine_GameObject.GetComponent<uScript_ReceiveSignal>();
            if ( null != component )
            {
               component.OnReceiveSignal -= Instance_OnReceiveSignal_0;
            }
         }
      }
      if ( null != local_9_UnityEngine_GameObject )
      {
         {
            uScript_ReceiveSignal component = local_9_UnityEngine_GameObject.GetComponent<uScript_ReceiveSignal>();
            if ( null != component )
            {
               component.OnReceiveSignal -= Instance_OnReceiveSignal_5;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareString_uScriptCon_CompareString_3.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_7.SetParent(g);
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_10.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_13.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_14.SetParent(g);
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_17.SetParent(g);
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_20.SetParent(g);
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_25.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_27.SetParent(g);
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_29.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_31.SetParent(g);
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_34.SetParent(g);
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_37.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_39.SetParent(g);
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_42.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_48.SetParent(g);
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_49.SetParent(g);
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_50.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_56.SetParent(g);
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_57.SetParent(g);
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_58.SetParent(g);
      owner_Connection_18 = parentGameObject;
      owner_Connection_24 = parentGameObject;
      owner_Connection_32 = parentGameObject;
      owner_Connection_40 = parentGameObject;
      owner_Connection_47 = parentGameObject;
      owner_Connection_55 = parentGameObject;
   }
   public void Awake()
   {
      
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
      
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnReceiveSignal_0(object o, uScript_ReceiveSignal.ReceiveSignalEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_Signal_0 = e.Signal;
      //relay event to nodes
      Relay_OnReceiveSignal_0( );
   }
   
   void Instance_OnReceiveSignal_5(object o, uScript_ReceiveSignal.ReceiveSignalEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_Signal_5 = e.Signal;
      //relay event to nodes
      Relay_OnReceiveSignal_5( );
   }
   
   void Relay_OnReceiveSignal_0()
   {
      local_2_System_String = event_UnityEngine_GameObject_Signal_0;
      Relay_In_3();
   }
   
   void Relay_In_3()
   {
      {
         {
            logic_uScriptCon_CompareString_A_3 = local_2_System_String;
            
         }
         {
            logic_uScriptCon_CompareString_B_3 = local_4_System_String;
            
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_3.In(logic_uScriptCon_CompareString_A_3, logic_uScriptCon_CompareString_B_3);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_3.Same;
      
      if ( test_0 == true )
      {
         Relay_In_10();
      }
   }
   
   void Relay_OnReceiveSignal_5()
   {
      local_6_System_String = event_UnityEngine_GameObject_Signal_5;
   }
   
   void Relay_In_7()
   {
      {
         {
            logic_uScriptCon_CompareString_A_7 = local_6_System_String;
            
         }
         {
            logic_uScriptCon_CompareString_B_7 = local_8_System_String;
            
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_7.In(logic_uScriptCon_CompareString_A_7, logic_uScriptCon_CompareString_B_7);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_10()
   {
      {
         {
            logic_uScriptCon_IntCounter_A_10 = local_IntFoodAte_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_10.In(logic_uScriptCon_IntCounter_A_10, logic_uScriptCon_IntCounter_B_10, out logic_uScriptCon_IntCounter_currentValue_10);
      local_12_System_Int32 = logic_uScriptCon_IntCounter_currentValue_10;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_10.GreaterThan;
      bool test_1 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_10.EqualTo;
      bool test_2 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_10.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_20();
      }
      if ( test_1 == true )
      {
         Relay_In_14();
      }
      if ( test_2 == true )
      {
         Relay_In_13();
      }
   }
   
   void Relay_Reset_10()
   {
      {
         {
            logic_uScriptCon_IntCounter_A_10 = local_IntFoodAte_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_10.Reset(logic_uScriptCon_IntCounter_A_10, logic_uScriptCon_IntCounter_B_10, out logic_uScriptCon_IntCounter_currentValue_10);
      local_12_System_Int32 = logic_uScriptCon_IntCounter_currentValue_10;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_10.GreaterThan;
      bool test_1 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_10.EqualTo;
      bool test_2 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_10.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_20();
      }
      if ( test_1 == true )
      {
         Relay_In_14();
      }
      if ( test_2 == true )
      {
         Relay_In_13();
      }
   }
   
   void Relay_In_13()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_13.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_13, index + 1);
            }
            logic_uScriptAct_Log_Target_13[ index++ ] = local_16_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_13.In(logic_uScriptAct_Log_Prefix_13, logic_uScriptAct_Log_Target_13, logic_uScriptAct_Log_Postfix_13);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_14()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_14.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_14, index + 1);
            }
            logic_uScriptAct_Log_Target_14[ index++ ] = local_15_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_14.In(logic_uScriptAct_Log_Prefix_14, logic_uScriptAct_Log_Target_14, logic_uScriptAct_Log_Postfix_14);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_14.Out;
      
      if ( test_0 == true )
      {
         Relay_In_17();
      }
   }
   
   void Relay_In_17()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_SetGameObjectScale_Target_17.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectScale_Target_17, index + 1);
            }
            logic_uScriptAct_SetGameObjectScale_Target_17[ index++ ] = owner_Connection_18;
            
         }
         {
            logic_uScriptAct_SetGameObjectScale_Scale_17 = local_19_UnityEngine_Vector3;
            
         }
      }
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_17.In(logic_uScriptAct_SetGameObjectScale_Target_17, logic_uScriptAct_SetGameObjectScale_Scale_17);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_20()
   {
      {
         {
            logic_uScriptCon_IntCounter_A_20 = local_IntFoodAte_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_20.In(logic_uScriptCon_IntCounter_A_20, logic_uScriptCon_IntCounter_B_20, out logic_uScriptCon_IntCounter_currentValue_20);
      local_21_System_Int32 = logic_uScriptCon_IntCounter_currentValue_20;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_20.GreaterThan;
      bool test_1 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_20.EqualTo;
      bool test_2 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_20.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_29();
      }
      if ( test_1 == true )
      {
         Relay_In_25();
      }
      if ( test_2 == true )
      {
         Relay_In_27();
      }
   }
   
   void Relay_Reset_20()
   {
      {
         {
            logic_uScriptCon_IntCounter_A_20 = local_IntFoodAte_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_20.Reset(logic_uScriptCon_IntCounter_A_20, logic_uScriptCon_IntCounter_B_20, out logic_uScriptCon_IntCounter_currentValue_20);
      local_21_System_Int32 = logic_uScriptCon_IntCounter_currentValue_20;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_20.GreaterThan;
      bool test_1 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_20.EqualTo;
      bool test_2 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_20.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_29();
      }
      if ( test_1 == true )
      {
         Relay_In_25();
      }
      if ( test_2 == true )
      {
         Relay_In_27();
      }
   }
   
   void Relay_In_25()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_SetGameObjectScale_Target_25.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectScale_Target_25, index + 1);
            }
            logic_uScriptAct_SetGameObjectScale_Target_25[ index++ ] = owner_Connection_24;
            
         }
         {
            logic_uScriptAct_SetGameObjectScale_Scale_25 = local_23_UnityEngine_Vector3;
            
         }
      }
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_25.In(logic_uScriptAct_SetGameObjectScale_Target_25, logic_uScriptAct_SetGameObjectScale_Scale_25);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_27()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_27.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_27, index + 1);
            }
            logic_uScriptAct_Log_Target_27[ index++ ] = local_26_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_27.In(logic_uScriptAct_Log_Prefix_27, logic_uScriptAct_Log_Target_27, logic_uScriptAct_Log_Postfix_27);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_29()
   {
      {
         {
            logic_uScriptCon_IntCounter_A_29 = local_IntFoodAte_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_29.In(logic_uScriptCon_IntCounter_A_29, logic_uScriptCon_IntCounter_B_29, out logic_uScriptCon_IntCounter_currentValue_29);
      local_30_System_Int32 = logic_uScriptCon_IntCounter_currentValue_29;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_29.GreaterThan;
      bool test_1 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_29.EqualTo;
      bool test_2 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_29.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_37();
      }
      if ( test_1 == true )
      {
         Relay_In_34();
      }
      if ( test_2 == true )
      {
         Relay_In_31();
      }
   }
   
   void Relay_Reset_29()
   {
      {
         {
            logic_uScriptCon_IntCounter_A_29 = local_IntFoodAte_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_29.Reset(logic_uScriptCon_IntCounter_A_29, logic_uScriptCon_IntCounter_B_29, out logic_uScriptCon_IntCounter_currentValue_29);
      local_30_System_Int32 = logic_uScriptCon_IntCounter_currentValue_29;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_29.GreaterThan;
      bool test_1 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_29.EqualTo;
      bool test_2 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_29.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_37();
      }
      if ( test_1 == true )
      {
         Relay_In_34();
      }
      if ( test_2 == true )
      {
         Relay_In_31();
      }
   }
   
   void Relay_In_31()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_31.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_31, index + 1);
            }
            logic_uScriptAct_Log_Target_31[ index++ ] = local_35_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_31.In(logic_uScriptAct_Log_Prefix_31, logic_uScriptAct_Log_Target_31, logic_uScriptAct_Log_Postfix_31);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_34()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_SetGameObjectScale_Target_34.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectScale_Target_34, index + 1);
            }
            logic_uScriptAct_SetGameObjectScale_Target_34[ index++ ] = owner_Connection_32;
            
         }
         {
            logic_uScriptAct_SetGameObjectScale_Scale_34 = local_28_UnityEngine_Vector3;
            
         }
      }
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_34.In(logic_uScriptAct_SetGameObjectScale_Target_34, logic_uScriptAct_SetGameObjectScale_Scale_34);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_37()
   {
      {
         {
            logic_uScriptCon_IntCounter_A_37 = local_IntFoodAte_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_37.In(logic_uScriptCon_IntCounter_A_37, logic_uScriptCon_IntCounter_B_37, out logic_uScriptCon_IntCounter_currentValue_37);
      local_38_System_Int32 = logic_uScriptCon_IntCounter_currentValue_37;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_37.GreaterThan;
      bool test_1 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_37.EqualTo;
      bool test_2 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_37.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_49();
      }
      if ( test_1 == true )
      {
         Relay_In_42();
      }
      if ( test_2 == true )
      {
         Relay_In_39();
      }
   }
   
   void Relay_Reset_37()
   {
      {
         {
            logic_uScriptCon_IntCounter_A_37 = local_IntFoodAte_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_37.Reset(logic_uScriptCon_IntCounter_A_37, logic_uScriptCon_IntCounter_B_37, out logic_uScriptCon_IntCounter_currentValue_37);
      local_38_System_Int32 = logic_uScriptCon_IntCounter_currentValue_37;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_37.GreaterThan;
      bool test_1 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_37.EqualTo;
      bool test_2 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_37.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_49();
      }
      if ( test_1 == true )
      {
         Relay_In_42();
      }
      if ( test_2 == true )
      {
         Relay_In_39();
      }
   }
   
   void Relay_In_39()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_39.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_39, index + 1);
            }
            logic_uScriptAct_Log_Target_39[ index++ ] = local_43_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_39.In(logic_uScriptAct_Log_Prefix_39, logic_uScriptAct_Log_Target_39, logic_uScriptAct_Log_Postfix_39);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_42()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_SetGameObjectScale_Target_42.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectScale_Target_42, index + 1);
            }
            logic_uScriptAct_SetGameObjectScale_Target_42[ index++ ] = owner_Connection_40;
            
         }
         {
            logic_uScriptAct_SetGameObjectScale_Scale_42 = local_36_UnityEngine_Vector3;
            
         }
      }
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_42.In(logic_uScriptAct_SetGameObjectScale_Target_42, logic_uScriptAct_SetGameObjectScale_Scale_42);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_48()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_48.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_48, index + 1);
            }
            logic_uScriptAct_Log_Target_48[ index++ ] = local_44_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_48.In(logic_uScriptAct_Log_Prefix_48, logic_uScriptAct_Log_Target_48, logic_uScriptAct_Log_Postfix_48);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_49()
   {
      {
         {
            logic_uScriptCon_IntCounter_A_49 = local_IntFoodAte_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_49.In(logic_uScriptCon_IntCounter_A_49, logic_uScriptCon_IntCounter_B_49, out logic_uScriptCon_IntCounter_currentValue_49);
      local_51_System_Int32 = logic_uScriptCon_IntCounter_currentValue_49;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_49.GreaterThan;
      bool test_1 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_49.EqualTo;
      bool test_2 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_49.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_57();
      }
      if ( test_1 == true )
      {
         Relay_In_50();
      }
      if ( test_2 == true )
      {
         Relay_In_48();
      }
   }
   
   void Relay_Reset_49()
   {
      {
         {
            logic_uScriptCon_IntCounter_A_49 = local_IntFoodAte_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_49.Reset(logic_uScriptCon_IntCounter_A_49, logic_uScriptCon_IntCounter_B_49, out logic_uScriptCon_IntCounter_currentValue_49);
      local_51_System_Int32 = logic_uScriptCon_IntCounter_currentValue_49;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_49.GreaterThan;
      bool test_1 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_49.EqualTo;
      bool test_2 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_49.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_57();
      }
      if ( test_1 == true )
      {
         Relay_In_50();
      }
      if ( test_2 == true )
      {
         Relay_In_48();
      }
   }
   
   void Relay_In_50()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_SetGameObjectScale_Target_50.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectScale_Target_50, index + 1);
            }
            logic_uScriptAct_SetGameObjectScale_Target_50[ index++ ] = owner_Connection_47;
            
         }
         {
            logic_uScriptAct_SetGameObjectScale_Scale_50 = local_46_UnityEngine_Vector3;
            
         }
      }
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_50.In(logic_uScriptAct_SetGameObjectScale_Target_50, logic_uScriptAct_SetGameObjectScale_Scale_50);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_56()
   {
      {
         {
         }
         {
            int index = 0;
            if ( logic_uScriptAct_Log_Target_56.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Log_Target_56, index + 1);
            }
            logic_uScriptAct_Log_Target_56[ index++ ] = local_52_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_Log_uScriptAct_Log_56.In(logic_uScriptAct_Log_Prefix_56, logic_uScriptAct_Log_Target_56, logic_uScriptAct_Log_Postfix_56);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_57()
   {
      {
         {
            logic_uScriptCon_IntCounter_A_57 = local_IntFoodAte_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_57.In(logic_uScriptCon_IntCounter_A_57, logic_uScriptCon_IntCounter_B_57, out logic_uScriptCon_IntCounter_currentValue_57);
      local_59_System_Int32 = logic_uScriptCon_IntCounter_currentValue_57;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_57.EqualTo;
      bool test_1 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_57.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_58();
      }
      if ( test_1 == true )
      {
         Relay_In_56();
      }
   }
   
   void Relay_Reset_57()
   {
      {
         {
            logic_uScriptCon_IntCounter_A_57 = local_IntFoodAte_System_Int32;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_IntCounter_uScriptCon_IntCounter_57.Reset(logic_uScriptCon_IntCounter_A_57, logic_uScriptCon_IntCounter_B_57, out logic_uScriptCon_IntCounter_currentValue_57);
      local_59_System_Int32 = logic_uScriptCon_IntCounter_currentValue_57;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_57.EqualTo;
      bool test_1 = logic_uScriptCon_IntCounter_uScriptCon_IntCounter_57.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_58();
      }
      if ( test_1 == true )
      {
         Relay_In_56();
      }
   }
   
   void Relay_In_58()
   {
      {
         {
            int index = 0;
            if ( logic_uScriptAct_SetGameObjectScale_Target_58.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetGameObjectScale_Target_58, index + 1);
            }
            logic_uScriptAct_SetGameObjectScale_Target_58[ index++ ] = owner_Connection_55;
            
         }
         {
            logic_uScriptAct_SetGameObjectScale_Scale_58 = local_54_UnityEngine_Vector3;
            
         }
      }
      logic_uScriptAct_SetGameObjectScale_uScriptAct_SetGameObjectScale_58.In(logic_uScriptAct_SetGameObjectScale_Target_58, logic_uScriptAct_SetGameObjectScale_Scale_58);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
