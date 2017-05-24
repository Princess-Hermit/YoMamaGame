//uScript Generated Code - Build 1.0.3055
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class YM_Scoring : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   UnityEngine.GameObject local_0_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_0_UnityEngine_GameObject_previous = null;
   System.String local_3_System_String = "GotFood";
   UnityEngine.GameObject local_4_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_4_UnityEngine_GameObject_previous = null;
   System.String local_5_System_String = "GotNotFood";
   System.String local_7_System_String = "";
   System.String local_8_System_String = "";
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_1 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_1 = "";
   System.String logic_uScriptCon_CompareString_B_1 = "";
   bool logic_uScriptCon_CompareString_Same_1 = true;
   bool logic_uScriptCon_CompareString_Different_1 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_6 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_6 = "";
   System.String logic_uScriptCon_CompareString_B_6 = "";
   bool logic_uScriptCon_CompareString_Same_6 = true;
   bool logic_uScriptCon_CompareString_Different_6 = true;
   
   //event nodes
   System.String event_UnityEngine_GameObject_Signal_2 = "";
   System.String event_UnityEngine_GameObject_Signal_9 = "";
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_0_UnityEngine_GameObject = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_0_UnityEngine_GameObject_previous != local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_0_UnityEngine_GameObject_previous )
         {
            {
               uScript_ReceiveSignal component = local_0_UnityEngine_GameObject_previous.GetComponent<uScript_ReceiveSignal>();
               if ( null != component )
               {
                  component.OnReceiveSignal -= Instance_OnReceiveSignal_9;
               }
            }
         }
         
         local_0_UnityEngine_GameObject_previous = local_0_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_0_UnityEngine_GameObject )
         {
            {
               uScript_ReceiveSignal component = local_0_UnityEngine_GameObject.GetComponent<uScript_ReceiveSignal>();
               if ( null == component )
               {
                  component = local_0_UnityEngine_GameObject.AddComponent<uScript_ReceiveSignal>();
               }
               if ( null != component )
               {
                  component.OnReceiveSignal += Instance_OnReceiveSignal_9;
               }
            }
         }
      }
      if ( null == local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_4_UnityEngine_GameObject = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_4_UnityEngine_GameObject_previous )
         {
            {
               uScript_ReceiveSignal component = local_4_UnityEngine_GameObject_previous.GetComponent<uScript_ReceiveSignal>();
               if ( null != component )
               {
                  component.OnReceiveSignal -= Instance_OnReceiveSignal_2;
               }
            }
         }
         
         local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_4_UnityEngine_GameObject )
         {
            {
               uScript_ReceiveSignal component = local_4_UnityEngine_GameObject.GetComponent<uScript_ReceiveSignal>();
               if ( null == component )
               {
                  component = local_4_UnityEngine_GameObject.AddComponent<uScript_ReceiveSignal>();
               }
               if ( null != component )
               {
                  component.OnReceiveSignal += Instance_OnReceiveSignal_2;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_0_UnityEngine_GameObject_previous != local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_0_UnityEngine_GameObject_previous )
         {
            {
               uScript_ReceiveSignal component = local_0_UnityEngine_GameObject_previous.GetComponent<uScript_ReceiveSignal>();
               if ( null != component )
               {
                  component.OnReceiveSignal -= Instance_OnReceiveSignal_9;
               }
            }
         }
         
         local_0_UnityEngine_GameObject_previous = local_0_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_0_UnityEngine_GameObject )
         {
            {
               uScript_ReceiveSignal component = local_0_UnityEngine_GameObject.GetComponent<uScript_ReceiveSignal>();
               if ( null == component )
               {
                  component = local_0_UnityEngine_GameObject.AddComponent<uScript_ReceiveSignal>();
               }
               if ( null != component )
               {
                  component.OnReceiveSignal += Instance_OnReceiveSignal_9;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_4_UnityEngine_GameObject_previous )
         {
            {
               uScript_ReceiveSignal component = local_4_UnityEngine_GameObject_previous.GetComponent<uScript_ReceiveSignal>();
               if ( null != component )
               {
                  component.OnReceiveSignal -= Instance_OnReceiveSignal_2;
               }
            }
         }
         
         local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_4_UnityEngine_GameObject )
         {
            {
               uScript_ReceiveSignal component = local_4_UnityEngine_GameObject.GetComponent<uScript_ReceiveSignal>();
               if ( null == component )
               {
                  component = local_4_UnityEngine_GameObject.AddComponent<uScript_ReceiveSignal>();
               }
               if ( null != component )
               {
                  component.OnReceiveSignal += Instance_OnReceiveSignal_2;
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
      if ( null != local_0_UnityEngine_GameObject )
      {
         {
            uScript_ReceiveSignal component = local_0_UnityEngine_GameObject.GetComponent<uScript_ReceiveSignal>();
            if ( null != component )
            {
               component.OnReceiveSignal -= Instance_OnReceiveSignal_9;
            }
         }
      }
      if ( null != local_4_UnityEngine_GameObject )
      {
         {
            uScript_ReceiveSignal component = local_4_UnityEngine_GameObject.GetComponent<uScript_ReceiveSignal>();
            if ( null != component )
            {
               component.OnReceiveSignal -= Instance_OnReceiveSignal_2;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareString_uScriptCon_CompareString_1.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_6.SetParent(g);
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
   
   void Instance_OnReceiveSignal_2(object o, uScript_ReceiveSignal.ReceiveSignalEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_Signal_2 = e.Signal;
      //relay event to nodes
      Relay_OnReceiveSignal_2( );
   }
   
   void Instance_OnReceiveSignal_9(object o, uScript_ReceiveSignal.ReceiveSignalEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_Signal_9 = e.Signal;
      //relay event to nodes
      Relay_OnReceiveSignal_9( );
   }
   
   void Relay_In_1()
   {
      {
         {
            logic_uScriptCon_CompareString_A_1 = local_8_System_String;
            
         }
         {
            logic_uScriptCon_CompareString_B_1 = local_5_System_String;
            
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_1.In(logic_uScriptCon_CompareString_A_1, logic_uScriptCon_CompareString_B_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnReceiveSignal_2()
   {
      local_7_System_String = event_UnityEngine_GameObject_Signal_2;
      Relay_In_6();
   }
   
   void Relay_In_6()
   {
      {
         {
            logic_uScriptCon_CompareString_A_6 = local_7_System_String;
            
         }
         {
            logic_uScriptCon_CompareString_B_6 = local_3_System_String;
            
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_6.In(logic_uScriptCon_CompareString_A_6, logic_uScriptCon_CompareString_B_6);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnReceiveSignal_9()
   {
      local_8_System_String = event_UnityEngine_GameObject_Signal_9;
   }
   
}
