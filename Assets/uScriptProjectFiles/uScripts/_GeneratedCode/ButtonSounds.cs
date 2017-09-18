//uScript Generated Code - Build 1.0.3073
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class ButtonSounds : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.AudioClip[] ButtonSFX = new UnityEngine.AudioClip[ 0 ];
   UnityEngine.GameObject local_4_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_4_UnityEngine_GameObject_previous = null;
   System.Single local_SFX_Volume_System_Single = (float) 1;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_1 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_PlaySoundRandom logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2 = new uScriptAct_PlaySoundRandom( );
   UnityEngine.AudioClip[] logic_uScriptAct_PlaySoundRandom_audioClips_2 = new UnityEngine.AudioClip[ 0 ];
   UnityEngine.GameObject[] logic_uScriptAct_PlaySoundRandom_targets_2 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_PlaySoundRandom_volume_2 = (float) 0;
   System.Boolean logic_uScriptAct_PlaySoundRandom_loop_2 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_PlaySoundRandom_chosenTarget_2;
   UnityEngine.AudioClip logic_uScriptAct_PlaySoundRandom_chosenClip_2;
   bool logic_uScriptAct_PlaySoundRandom_Out_2 = true;
   
   //event nodes
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_4_UnityEngine_GameObject = GameObject.Find( "SFXPlayer" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == owner_Connection_1 || false == m_RegisteredForEvents )
      {
         owner_Connection_1 = parentGameObject;
         if ( null != owner_Connection_1 )
         {
            {
               uScript_Button component = owner_Connection_1.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_0;
                  component.OnButtonDown += Instance_OnButtonDown_0;
                  component.OnButtonUp += Instance_OnButtonUp_0;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_1 )
         {
            {
               uScript_Button component = owner_Connection_1.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = owner_Connection_1.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_0;
                  component.OnButtonDown += Instance_OnButtonDown_0;
                  component.OnButtonUp += Instance_OnButtonUp_0;
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
      if ( null != owner_Connection_1 )
      {
         {
            uScript_Button component = owner_Connection_1.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_0;
               component.OnButtonDown -= Instance_OnButtonDown_0;
               component.OnButtonUp -= Instance_OnButtonUp_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.SetParent(g);
      owner_Connection_1 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.Finished += uScriptAct_PlaySoundRandom_Finished_2;
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
      
      logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.Finished -= uScriptAct_PlaySoundRandom_Finished_2;
   }
   
   void Instance_OnButtonClick_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_0( );
   }
   
   void Instance_OnButtonDown_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_0( );
   }
   
   void Instance_OnButtonUp_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_0( );
   }
   
   void uScriptAct_PlaySoundRandom_Finished_2(object o, System.EventArgs e)
   {
      //fill globals
      //links to chosenTarget = 0
      //links to chosenClip = 0
      //relay event to nodes
      Relay_Finished_2( );
   }
   
   void Relay_OnButtonClick_0()
   {
   }
   
   void Relay_OnButtonDown_0()
   {
   }
   
   void Relay_OnButtonUp_0()
   {
      Relay_Play_2();
   }
   
   void Relay_Finished_2()
   {
   }
   
   void Relay_Play_2()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = ButtonSFX;
            if ( logic_uScriptAct_PlaySoundRandom_audioClips_2.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_PlaySoundRandom_audioClips_2, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_PlaySoundRandom_audioClips_2, index, properties.Length);
            index += properties.Length;
            
         }
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_PlaySoundRandom_targets_2.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_PlaySoundRandom_targets_2, index + 1);
            }
            logic_uScriptAct_PlaySoundRandom_targets_2[ index++ ] = local_4_UnityEngine_GameObject;
            
         }
         {
            logic_uScriptAct_PlaySoundRandom_volume_2 = local_SFX_Volume_System_Single;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.Play(logic_uScriptAct_PlaySoundRandom_audioClips_2, logic_uScriptAct_PlaySoundRandom_targets_2, logic_uScriptAct_PlaySoundRandom_volume_2, logic_uScriptAct_PlaySoundRandom_loop_2, out logic_uScriptAct_PlaySoundRandom_chosenTarget_2, out logic_uScriptAct_PlaySoundRandom_chosenClip_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_UpdateVolume_2()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = ButtonSFX;
            if ( logic_uScriptAct_PlaySoundRandom_audioClips_2.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_PlaySoundRandom_audioClips_2, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_PlaySoundRandom_audioClips_2, index, properties.Length);
            index += properties.Length;
            
         }
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_PlaySoundRandom_targets_2.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_PlaySoundRandom_targets_2, index + 1);
            }
            logic_uScriptAct_PlaySoundRandom_targets_2[ index++ ] = local_4_UnityEngine_GameObject;
            
         }
         {
            logic_uScriptAct_PlaySoundRandom_volume_2 = local_SFX_Volume_System_Single;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.UpdateVolume(logic_uScriptAct_PlaySoundRandom_audioClips_2, logic_uScriptAct_PlaySoundRandom_targets_2, logic_uScriptAct_PlaySoundRandom_volume_2, logic_uScriptAct_PlaySoundRandom_loop_2, out logic_uScriptAct_PlaySoundRandom_chosenTarget_2, out logic_uScriptAct_PlaySoundRandom_chosenClip_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Stop_2()
   {
      {
         {
            System.Array properties;
            int index = 0;
            properties = ButtonSFX;
            if ( logic_uScriptAct_PlaySoundRandom_audioClips_2.Length != index + properties.Length)
            {
               System.Array.Resize(ref logic_uScriptAct_PlaySoundRandom_audioClips_2, index + properties.Length);
            }
            System.Array.Copy(properties, 0, logic_uScriptAct_PlaySoundRandom_audioClips_2, index, properties.Length);
            index += properties.Length;
            
         }
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_4_UnityEngine_GameObject_previous != local_4_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_4_UnityEngine_GameObject_previous = local_4_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_PlaySoundRandom_targets_2.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_PlaySoundRandom_targets_2, index + 1);
            }
            logic_uScriptAct_PlaySoundRandom_targets_2[ index++ ] = local_4_UnityEngine_GameObject;
            
         }
         {
            logic_uScriptAct_PlaySoundRandom_volume_2 = local_SFX_Volume_System_Single;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_PlaySoundRandom_uScriptAct_PlaySoundRandom_2.Stop(logic_uScriptAct_PlaySoundRandom_audioClips_2, logic_uScriptAct_PlaySoundRandom_targets_2, logic_uScriptAct_PlaySoundRandom_volume_2, logic_uScriptAct_PlaySoundRandom_loop_2, out logic_uScriptAct_PlaySoundRandom_chosenTarget_2, out logic_uScriptAct_PlaySoundRandom_chosenClip_2);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
