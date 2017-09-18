//uScript Generated Code - Build 1.0.3073
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class NeedTokenPanel : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public System.Int32 AddTokens = (int) 10;
   System.Int32 local_0_System_Int32 = (int) 30;
   System.String local_27_System_String = "";
   UnityEngine.GameObject local_36_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_36_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_7_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_7_UnityEngine_GameObject_previous = null;
   System.Int32 local_AddedInt_System_Int32 = (int) 0;
   public UnityEngine.GameObject needTokensPanel = default(UnityEngine.GameObject);
   UnityEngine.GameObject needTokensPanel_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_ClampInt logic_uScriptAct_ClampInt_uScriptAct_ClampInt_2 = new uScriptAct_ClampInt( );
   System.Int32 logic_uScriptAct_ClampInt_Target_2 = (int) 0;
   System.Int32 logic_uScriptAct_ClampInt_Min_2 = (int) 0;
   System.Int32 logic_uScriptAct_ClampInt_Max_2 = (int) 30;
   System.Int32 logic_uScriptAct_ClampInt_IntResult_2;
   System.Single logic_uScriptAct_ClampInt_FloatResult_2;
   bool logic_uScriptAct_ClampInt_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_SetColor logic_uScriptAct_SetColor_uScriptAct_SetColor_3 = new uScriptAct_SetColor( );
   UnityEngine.Color logic_uScriptAct_SetColor_Value_3 = new UnityEngine.Color( (float)1, (float)0.8902429, (float)0, (float)1 );
   UnityEngine.Color logic_uScriptAct_SetColor_TargetColor_3;
   bool logic_uScriptAct_SetColor_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_SetColor logic_uScriptAct_SetColor_uScriptAct_SetColor_4 = new uScriptAct_SetColor( );
   UnityEngine.Color logic_uScriptAct_SetColor_Value_4 = new UnityEngine.Color( (float)1, (float)0, (float)0, (float)1 );
   UnityEngine.Color logic_uScriptAct_SetColor_TargetColor_4;
   bool logic_uScriptAct_SetColor_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_5 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_5 = (float) 0.1;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_5 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_5 = true;
   bool logic_uScriptAct_Delay_AfterDelay_5 = true;
   bool logic_uScriptAct_Delay_Stopped_5 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_5 = false;
   //pointer to script instanced logic node
   uScriptAct_SetColor logic_uScriptAct_SetColor_uScriptAct_SetColor_8 = new uScriptAct_SetColor( );
   UnityEngine.Color logic_uScriptAct_SetColor_Value_8 = new UnityEngine.Color( (float)1, (float)0.8902429, (float)0, (float)1 );
   UnityEngine.Color logic_uScriptAct_SetColor_TargetColor_8;
   bool logic_uScriptAct_SetColor_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_10 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_10 = (float) 0.1;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_10 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_10 = true;
   bool logic_uScriptAct_Delay_AfterDelay_10 = true;
   bool logic_uScriptAct_Delay_Stopped_10 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_10 = false;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_12 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_12 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_12 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_12 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_12 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_12 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_12 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_12 = true;
   bool logic_uScriptCon_CompareInt_LessThan_12 = true;
   //pointer to script instanced logic node
   uScriptAct_AddInt_v2 logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_13 = new uScriptAct_AddInt_v2( );
   System.Int32 logic_uScriptAct_AddInt_v2_A_13 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_B_13 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_IntResult_13;
   System.Single logic_uScriptAct_AddInt_v2_FloatResult_13;
   bool logic_uScriptAct_AddInt_v2_Out_13 = true;
   //pointer to script instanced logic node
   uScriptAct_SetColor logic_uScriptAct_SetColor_uScriptAct_SetColor_17 = new uScriptAct_SetColor( );
   UnityEngine.Color logic_uScriptAct_SetColor_Value_17 = new UnityEngine.Color( (float)1, (float)0, (float)0, (float)1 );
   UnityEngine.Color logic_uScriptAct_SetColor_TargetColor_17;
   bool logic_uScriptAct_SetColor_Out_17 = true;
   //pointer to script instanced logic node
   uScriptAct_ClampInt logic_uScriptAct_ClampInt_uScriptAct_ClampInt_20 = new uScriptAct_ClampInt( );
   System.Int32 logic_uScriptAct_ClampInt_Target_20 = (int) 0;
   System.Int32 logic_uScriptAct_ClampInt_Min_20 = (int) 0;
   System.Int32 logic_uScriptAct_ClampInt_Max_20 = (int) 30;
   System.Int32 logic_uScriptAct_ClampInt_IntResult_20;
   System.Single logic_uScriptAct_ClampInt_FloatResult_20;
   bool logic_uScriptAct_ClampInt_Out_20 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_23 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_23 = (float) 0.1;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_23 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_23 = true;
   bool logic_uScriptAct_Delay_AfterDelay_23 = true;
   bool logic_uScriptAct_Delay_Stopped_23 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_23 = false;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_25 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_25 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_25 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_25 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_25 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_25;
   bool logic_uScriptAct_SetString_Out_25 = true;
   //pointer to script instanced logic node
   uScriptAct_IntToString logic_uScriptAct_IntToString_uScriptAct_IntToString_26 = new uScriptAct_IntToString( );
   System.Int32 logic_uScriptAct_IntToString_Target_26 = (int) 0;
   uScriptAct_IntToString.FormatType logic_uScriptAct_IntToString_StandardFormat_26 = uScriptAct_IntToString.FormatType.General;
   System.String logic_uScriptAct_IntToString_CustomFormat_26 = "";
   System.String logic_uScriptAct_IntToString_CustomCulture_26 = "";
   System.String logic_uScriptAct_IntToString_Result_26;
   bool logic_uScriptAct_IntToString_Out_26 = true;
   //pointer to script instanced logic node
   uScript_GraphEvents logic_uScript_GraphEvents_uScript_GraphEvents_31 = new uScript_GraphEvents( );
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_32 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_32;
   bool logic_uScriptAct_SetBool_Out_32 = true;
   bool logic_uScriptAct_SetBool_SetTrue_32 = true;
   bool logic_uScriptAct_SetBool_SetFalse_32 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_37 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_37 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_37 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_37 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_37 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_37 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_37 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_37 = true;
   bool logic_uScriptCon_CompareInt_LessThan_37 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_40 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_40;
   bool logic_uScriptAct_SetBool_Out_40 = true;
   bool logic_uScriptAct_SetBool_SetTrue_40 = true;
   bool logic_uScriptAct_SetBool_SetFalse_40 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_41 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_41 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_41 = (bool) true;
   bool logic_uScriptAct_Delay_Immediate_41 = true;
   bool logic_uScriptAct_Delay_AfterDelay_41 = true;
   bool logic_uScriptAct_Delay_Stopped_41 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_41 = false;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_30 = default(UnityEngine.GameObject);
   
   //property nodes
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_1 = UnityEngine.Color.black;
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_1 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_1_previous = null;
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_6 = (int) 0;
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_6 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_6_previous = null;
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_11 = UnityEngine.Color.black;
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_11 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_11_previous = null;
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_14 = (int) 0;
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_14 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_14_previous = null;
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_15 = (int) 0;
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_15 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_15_previous = null;
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_21 = UnityEngine.Color.black;
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_21 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_21_previous = null;
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_24 = UnityEngine.Color.black;
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_24 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_color_Detox_ScriptEditor_Parameter_Instance_24_previous = null;
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_28 = (int) 0;
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_28 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_28_previous = null;
   System.String property_text_Detox_ScriptEditor_Parameter_text_29 = "";
   UnityEngine.GameObject property_text_Detox_ScriptEditor_Parameter_Instance_29 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_text_Detox_ScriptEditor_Parameter_Instance_29_previous = null;
   System.Boolean property_active_Detox_ScriptEditor_Parameter_active_33 = (bool) false;
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_38 = (int) 0;
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_38 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_tokens_Detox_ScriptEditor_Parameter_Instance_38_previous = null;
   System.Boolean property_active_Detox_ScriptEditor_Parameter_active_39 = (bool) false;
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_1_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_1 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_1.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.color;
      }
      else
      {
         return UnityEngine.Color.black;
      }
   }
   
   void property_color_Detox_ScriptEditor_Parameter_color_1_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_1 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_1.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.color = property_color_Detox_ScriptEditor_Parameter_color_1;
      }
   }
   
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_6_Get_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_6 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_6.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         return component.tokens;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_tokens_Detox_ScriptEditor_Parameter_tokens_6_Set_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_6 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_6.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         component.tokens = property_tokens_Detox_ScriptEditor_Parameter_tokens_6;
      }
   }
   
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_11_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_11 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_11.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.color;
      }
      else
      {
         return UnityEngine.Color.black;
      }
   }
   
   void property_color_Detox_ScriptEditor_Parameter_color_11_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_11 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_11.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.color = property_color_Detox_ScriptEditor_Parameter_color_11;
      }
   }
   
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_14_Get_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_14 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_14.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         return component.tokens;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_tokens_Detox_ScriptEditor_Parameter_tokens_14_Set_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_14 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_14.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         component.tokens = property_tokens_Detox_ScriptEditor_Parameter_tokens_14;
      }
   }
   
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_15_Get_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_15 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_15.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         return component.tokens;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_tokens_Detox_ScriptEditor_Parameter_tokens_15_Set_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_15 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_15.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         component.tokens = property_tokens_Detox_ScriptEditor_Parameter_tokens_15;
      }
   }
   
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_21_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_21 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_21.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.color;
      }
      else
      {
         return UnityEngine.Color.black;
      }
   }
   
   void property_color_Detox_ScriptEditor_Parameter_color_21_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_21 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_21.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.color = property_color_Detox_ScriptEditor_Parameter_color_21;
      }
   }
   
   UnityEngine.Color property_color_Detox_ScriptEditor_Parameter_color_24_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_24 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_24.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.color;
      }
      else
      {
         return UnityEngine.Color.black;
      }
   }
   
   void property_color_Detox_ScriptEditor_Parameter_color_24_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_color_Detox_ScriptEditor_Parameter_Instance_24 != null)
      {
         component = property_color_Detox_ScriptEditor_Parameter_Instance_24.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.color = property_color_Detox_ScriptEditor_Parameter_color_24;
      }
   }
   
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_28_Get_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_28 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_28.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         return component.tokens;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_tokens_Detox_ScriptEditor_Parameter_tokens_28_Set_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_28 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_28.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         component.tokens = property_tokens_Detox_ScriptEditor_Parameter_tokens_28;
      }
   }
   
   System.String property_text_Detox_ScriptEditor_Parameter_text_29_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_text_Detox_ScriptEditor_Parameter_Instance_29 != null)
      {
         component = property_text_Detox_ScriptEditor_Parameter_Instance_29.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.text;
      }
      else
      {
         return "";
      }
   }
   
   void property_text_Detox_ScriptEditor_Parameter_text_29_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (property_text_Detox_ScriptEditor_Parameter_Instance_29 != null)
      {
         component = property_text_Detox_ScriptEditor_Parameter_Instance_29.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_29;
      }
   }
   
   System.Boolean property_active_Detox_ScriptEditor_Parameter_active_33_Get_Refresh( )
   {
      UnityEngine.GameObject component = null;
      component = needTokensPanel;
      if ( null != component )
      {
         return component.active;
      }
      else
      {
         return (bool) false;
      }
   }
   
   void property_active_Detox_ScriptEditor_Parameter_active_33_Set_Refresh( )
   {
      UnityEngine.GameObject component = null;
      component = needTokensPanel;
      if ( null != component )
      {
         component.active = property_active_Detox_ScriptEditor_Parameter_active_33;
      }
   }
   
   System.Int32 property_tokens_Detox_ScriptEditor_Parameter_tokens_38_Get_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_38 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_38.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         return component.tokens;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_tokens_Detox_ScriptEditor_Parameter_tokens_38_Set_Refresh( )
   {
      TokenManager component = null;
      if (property_tokens_Detox_ScriptEditor_Parameter_Instance_38 != null)
      {
         component = property_tokens_Detox_ScriptEditor_Parameter_Instance_38.GetComponent<TokenManager>();
      }
      if ( null != component )
      {
         component.tokens = property_tokens_Detox_ScriptEditor_Parameter_tokens_38;
      }
   }
   
   System.Boolean property_active_Detox_ScriptEditor_Parameter_active_39_Get_Refresh( )
   {
      UnityEngine.GameObject component = null;
      component = needTokensPanel;
      if ( null != component )
      {
         return component.active;
      }
      else
      {
         return (bool) false;
      }
   }
   
   void property_active_Detox_ScriptEditor_Parameter_active_39_Set_Refresh( )
   {
      UnityEngine.GameObject component = null;
      component = needTokensPanel;
      if ( null != component )
      {
         component.active = property_active_Detox_ScriptEditor_Parameter_active_39;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      if ( null == property_color_Detox_ScriptEditor_Parameter_Instance_1 || false == m_RegisteredForEvents )
      {
         property_color_Detox_ScriptEditor_Parameter_Instance_1 = GameObject.Find( "Token Total" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_1_previous != property_color_Detox_ScriptEditor_Parameter_Instance_1 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_1_previous = property_color_Detox_ScriptEditor_Parameter_Instance_1;
         
         //setup new listeners
      }
      if ( null == property_tokens_Detox_ScriptEditor_Parameter_Instance_6 || false == m_RegisteredForEvents )
      {
         property_tokens_Detox_ScriptEditor_Parameter_Instance_6 = GameObject.Find( "TokenManager" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_6_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_6 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_6_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_6;
         
         //setup new listeners
      }
      if ( null == property_color_Detox_ScriptEditor_Parameter_Instance_11 || false == m_RegisteredForEvents )
      {
         property_color_Detox_ScriptEditor_Parameter_Instance_11 = GameObject.Find( "Token Total" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_11_previous != property_color_Detox_ScriptEditor_Parameter_Instance_11 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_11_previous = property_color_Detox_ScriptEditor_Parameter_Instance_11;
         
         //setup new listeners
      }
      if ( null == property_tokens_Detox_ScriptEditor_Parameter_Instance_14 || false == m_RegisteredForEvents )
      {
         property_tokens_Detox_ScriptEditor_Parameter_Instance_14 = GameObject.Find( "TokenManager" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_14_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_14 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_14_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_14;
         
         //setup new listeners
      }
      if ( null == property_tokens_Detox_ScriptEditor_Parameter_Instance_15 || false == m_RegisteredForEvents )
      {
         property_tokens_Detox_ScriptEditor_Parameter_Instance_15 = GameObject.Find( "TokenManager" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_15_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_15 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_15_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_15;
         
         //setup new listeners
      }
      if ( null == property_color_Detox_ScriptEditor_Parameter_Instance_21 || false == m_RegisteredForEvents )
      {
         property_color_Detox_ScriptEditor_Parameter_Instance_21 = GameObject.Find( "Token Total" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_21_previous != property_color_Detox_ScriptEditor_Parameter_Instance_21 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_21_previous = property_color_Detox_ScriptEditor_Parameter_Instance_21;
         
         //setup new listeners
      }
      if ( null == property_color_Detox_ScriptEditor_Parameter_Instance_24 || false == m_RegisteredForEvents )
      {
         property_color_Detox_ScriptEditor_Parameter_Instance_24 = GameObject.Find( "Token Total" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_24_previous != property_color_Detox_ScriptEditor_Parameter_Instance_24 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_24_previous = property_color_Detox_ScriptEditor_Parameter_Instance_24;
         
         //setup new listeners
      }
      if ( null == property_tokens_Detox_ScriptEditor_Parameter_Instance_28 || false == m_RegisteredForEvents )
      {
         property_tokens_Detox_ScriptEditor_Parameter_Instance_28 = GameObject.Find( "TokenManager" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_28_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_28 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_28_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_28;
         
         //setup new listeners
      }
      if ( null == property_text_Detox_ScriptEditor_Parameter_Instance_29 || false == m_RegisteredForEvents )
      {
         property_text_Detox_ScriptEditor_Parameter_Instance_29 = GameObject.Find( "Token Current" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_text_Detox_ScriptEditor_Parameter_Instance_29_previous != property_text_Detox_ScriptEditor_Parameter_Instance_29 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_text_Detox_ScriptEditor_Parameter_Instance_29_previous = property_text_Detox_ScriptEditor_Parameter_Instance_29;
         
         //setup new listeners
      }
      if ( null == property_tokens_Detox_ScriptEditor_Parameter_Instance_38 || false == m_RegisteredForEvents )
      {
         property_tokens_Detox_ScriptEditor_Parameter_Instance_38 = GameObject.Find( "TokenManager" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_38_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_38 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_38_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_38;
         
         //setup new listeners
      }
      SyncEventListeners( );
      if ( null == local_7_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_7_UnityEngine_GameObject = GameObject.Find( "/Canvas/needTokensPanel/needTokensText/AddTokens Via Ad" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_7_UnityEngine_GameObject_previous != local_7_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_7_UnityEngine_GameObject_previous )
         {
            {
               uScript_Button component = local_7_UnityEngine_GameObject_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_9;
                  component.OnButtonDown -= Instance_OnButtonDown_9;
                  component.OnButtonUp -= Instance_OnButtonUp_9;
               }
            }
         }
         
         local_7_UnityEngine_GameObject_previous = local_7_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_7_UnityEngine_GameObject )
         {
            {
               uScript_Button component = local_7_UnityEngine_GameObject.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = local_7_UnityEngine_GameObject.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_9;
                  component.OnButtonDown += Instance_OnButtonDown_9;
                  component.OnButtonUp += Instance_OnButtonUp_9;
               }
            }
         }
      }
      if ( null == local_36_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_36_UnityEngine_GameObject = GameObject.Find( "Start Button" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_36_UnityEngine_GameObject_previous != local_36_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_36_UnityEngine_GameObject_previous )
         {
            {
               uScript_Button component = local_36_UnityEngine_GameObject_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_35;
                  component.OnButtonDown -= Instance_OnButtonDown_35;
                  component.OnButtonUp -= Instance_OnButtonUp_35;
               }
            }
         }
         
         local_36_UnityEngine_GameObject_previous = local_36_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_36_UnityEngine_GameObject )
         {
            {
               uScript_Button component = local_36_UnityEngine_GameObject.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = local_36_UnityEngine_GameObject.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_35;
                  component.OnButtonDown += Instance_OnButtonDown_35;
                  component.OnButtonUp += Instance_OnButtonUp_35;
               }
            }
         }
      }
      if ( null == needTokensPanel || false == m_RegisteredForEvents )
      {
         needTokensPanel = GameObject.Find( "/Canvas/needTokensPanel" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( needTokensPanel_previous != needTokensPanel || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         needTokensPanel_previous = needTokensPanel;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_1_previous != property_color_Detox_ScriptEditor_Parameter_Instance_1 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_1_previous = property_color_Detox_ScriptEditor_Parameter_Instance_1;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_6_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_6 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_6_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_6;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_11_previous != property_color_Detox_ScriptEditor_Parameter_Instance_11 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_11_previous = property_color_Detox_ScriptEditor_Parameter_Instance_11;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_14_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_14 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_14_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_14;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_15_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_15 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_15_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_15;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_21_previous != property_color_Detox_ScriptEditor_Parameter_Instance_21 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_21_previous = property_color_Detox_ScriptEditor_Parameter_Instance_21;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_color_Detox_ScriptEditor_Parameter_Instance_24_previous != property_color_Detox_ScriptEditor_Parameter_Instance_24 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_color_Detox_ScriptEditor_Parameter_Instance_24_previous = property_color_Detox_ScriptEditor_Parameter_Instance_24;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_28_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_28 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_28_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_28;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_text_Detox_ScriptEditor_Parameter_Instance_29_previous != property_text_Detox_ScriptEditor_Parameter_Instance_29 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_text_Detox_ScriptEditor_Parameter_Instance_29_previous = property_text_Detox_ScriptEditor_Parameter_Instance_29;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_38_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_38 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_tokens_Detox_ScriptEditor_Parameter_Instance_38_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_38;
         
         //setup new listeners
      }
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_7_UnityEngine_GameObject_previous != local_7_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_7_UnityEngine_GameObject_previous )
         {
            {
               uScript_Button component = local_7_UnityEngine_GameObject_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_9;
                  component.OnButtonDown -= Instance_OnButtonDown_9;
                  component.OnButtonUp -= Instance_OnButtonUp_9;
               }
            }
         }
         
         local_7_UnityEngine_GameObject_previous = local_7_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_7_UnityEngine_GameObject )
         {
            {
               uScript_Button component = local_7_UnityEngine_GameObject.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = local_7_UnityEngine_GameObject.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_9;
                  component.OnButtonDown += Instance_OnButtonDown_9;
                  component.OnButtonUp += Instance_OnButtonUp_9;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_36_UnityEngine_GameObject_previous != local_36_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_36_UnityEngine_GameObject_previous )
         {
            {
               uScript_Button component = local_36_UnityEngine_GameObject_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_35;
                  component.OnButtonDown -= Instance_OnButtonDown_35;
                  component.OnButtonUp -= Instance_OnButtonUp_35;
               }
            }
         }
         
         local_36_UnityEngine_GameObject_previous = local_36_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_36_UnityEngine_GameObject )
         {
            {
               uScript_Button component = local_36_UnityEngine_GameObject.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = local_36_UnityEngine_GameObject.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_35;
                  component.OnButtonDown += Instance_OnButtonDown_35;
                  component.OnButtonUp += Instance_OnButtonUp_35;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( needTokensPanel_previous != needTokensPanel || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         needTokensPanel_previous = needTokensPanel;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_color_Detox_ScriptEditor_Parameter_Instance_1_previous != property_color_Detox_ScriptEditor_Parameter_Instance_1 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_color_Detox_ScriptEditor_Parameter_Instance_1_previous = property_color_Detox_ScriptEditor_Parameter_Instance_1;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_6_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_6 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_tokens_Detox_ScriptEditor_Parameter_Instance_6_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_6;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_color_Detox_ScriptEditor_Parameter_Instance_11_previous != property_color_Detox_ScriptEditor_Parameter_Instance_11 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_color_Detox_ScriptEditor_Parameter_Instance_11_previous = property_color_Detox_ScriptEditor_Parameter_Instance_11;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_14_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_14 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_tokens_Detox_ScriptEditor_Parameter_Instance_14_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_14;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_15_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_15 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_tokens_Detox_ScriptEditor_Parameter_Instance_15_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_15;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_color_Detox_ScriptEditor_Parameter_Instance_21_previous != property_color_Detox_ScriptEditor_Parameter_Instance_21 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_color_Detox_ScriptEditor_Parameter_Instance_21_previous = property_color_Detox_ScriptEditor_Parameter_Instance_21;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_color_Detox_ScriptEditor_Parameter_Instance_24_previous != property_color_Detox_ScriptEditor_Parameter_Instance_24 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_color_Detox_ScriptEditor_Parameter_Instance_24_previous = property_color_Detox_ScriptEditor_Parameter_Instance_24;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_28_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_28 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_tokens_Detox_ScriptEditor_Parameter_Instance_28_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_28;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_text_Detox_ScriptEditor_Parameter_Instance_29_previous != property_text_Detox_ScriptEditor_Parameter_Instance_29 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_text_Detox_ScriptEditor_Parameter_Instance_29_previous = property_text_Detox_ScriptEditor_Parameter_Instance_29;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_tokens_Detox_ScriptEditor_Parameter_Instance_38_previous != property_tokens_Detox_ScriptEditor_Parameter_Instance_38 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_tokens_Detox_ScriptEditor_Parameter_Instance_38_previous = property_tokens_Detox_ScriptEditor_Parameter_Instance_38;
                  
                  //setup new listeners
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_30 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_30 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_30 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_30.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_30.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_30;
                  component.OnLateUpdate += Instance_OnLateUpdate_30;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_30;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != local_7_UnityEngine_GameObject )
      {
         {
            uScript_Button component = local_7_UnityEngine_GameObject.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_9;
               component.OnButtonDown -= Instance_OnButtonDown_9;
               component.OnButtonUp -= Instance_OnButtonUp_9;
            }
         }
      }
      if ( null != local_36_UnityEngine_GameObject )
      {
         {
            uScript_Button component = local_36_UnityEngine_GameObject.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_35;
               component.OnButtonDown -= Instance_OnButtonDown_35;
               component.OnButtonUp -= Instance_OnButtonUp_35;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_30 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_30.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_30;
               component.OnLateUpdate -= Instance_OnLateUpdate_30;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_30;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_ClampInt_uScriptAct_ClampInt_2.SetParent(g);
      logic_uScriptAct_SetColor_uScriptAct_SetColor_3.SetParent(g);
      logic_uScriptAct_SetColor_uScriptAct_SetColor_4.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_5.SetParent(g);
      logic_uScriptAct_SetColor_uScriptAct_SetColor_8.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_10.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_12.SetParent(g);
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_13.SetParent(g);
      logic_uScriptAct_SetColor_uScriptAct_SetColor_17.SetParent(g);
      logic_uScriptAct_ClampInt_uScriptAct_ClampInt_20.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_23.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_25.SetParent(g);
      logic_uScriptAct_IntToString_uScriptAct_IntToString_26.SetParent(g);
      logic_uScript_GraphEvents_uScript_GraphEvents_31.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_32.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_37.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_40.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_41.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScript_GraphEvents_uScript_GraphEvents_31.uScriptEnable += uScript_GraphEvents_uScriptEnable_31;
      logic_uScript_GraphEvents_uScript_GraphEvents_31.uScriptDisable += uScript_GraphEvents_uScriptDisable_31;
      logic_uScript_GraphEvents_uScript_GraphEvents_31.uScriptDestroy += uScript_GraphEvents_uScriptDestroy_31;
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
      logic_uScript_GraphEvents_uScript_GraphEvents_31.OnEnable( );
   }
   
   public void OnDisable()
   {
      logic_uScript_GraphEvents_uScript_GraphEvents_31.OnDisable( );
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      if (true == logic_uScriptAct_Delay_DrivenDelay_5)
      {
         Relay_DrivenDelay_5();
      }
      if (true == logic_uScriptAct_Delay_DrivenDelay_10)
      {
         Relay_DrivenDelay_10();
      }
      if (true == logic_uScriptAct_Delay_DrivenDelay_23)
      {
         Relay_DrivenDelay_23();
      }
      if (true == logic_uScriptAct_Delay_DrivenDelay_41)
      {
         Relay_DrivenDelay_41();
      }
   }
   
   public void OnDestroy()
   {
      logic_uScript_GraphEvents_uScript_GraphEvents_31.OnDestroy( );
      logic_uScript_GraphEvents_uScript_GraphEvents_31.uScriptEnable -= uScript_GraphEvents_uScriptEnable_31;
      logic_uScript_GraphEvents_uScript_GraphEvents_31.uScriptDisable -= uScript_GraphEvents_uScriptDisable_31;
      logic_uScript_GraphEvents_uScript_GraphEvents_31.uScriptDestroy -= uScript_GraphEvents_uScriptDestroy_31;
   }
   
   void Instance_OnButtonClick_9(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_9( );
   }
   
   void Instance_OnButtonDown_9(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_9( );
   }
   
   void Instance_OnButtonUp_9(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_9( );
   }
   
   void Instance_OnUpdate_30(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_30( );
   }
   
   void Instance_OnLateUpdate_30(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_30( );
   }
   
   void Instance_OnFixedUpdate_30(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_30( );
   }
   
   void Instance_OnButtonClick_35(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_35( );
   }
   
   void Instance_OnButtonDown_35(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_35( );
   }
   
   void Instance_OnButtonUp_35(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_35( );
   }
   
   void uScript_GraphEvents_uScriptEnable_31(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptEnable_31( );
   }
   
   void uScript_GraphEvents_uScriptDisable_31(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptDisable_31( );
   }
   
   void uScript_GraphEvents_uScriptDestroy_31(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptDestroy_31( );
   }
   
   void Relay_In_2()
   {
      {
         {
            logic_uScriptAct_ClampInt_Target_2 = local_AddedInt_System_Int32;
            
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
      logic_uScriptAct_ClampInt_uScriptAct_ClampInt_2.In(logic_uScriptAct_ClampInt_Target_2, logic_uScriptAct_ClampInt_Min_2, logic_uScriptAct_ClampInt_Max_2, out logic_uScriptAct_ClampInt_IntResult_2, out logic_uScriptAct_ClampInt_FloatResult_2);
      property_tokens_Detox_ScriptEditor_Parameter_tokens_15 = logic_uScriptAct_ClampInt_IntResult_2;
      property_tokens_Detox_ScriptEditor_Parameter_tokens_15_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_3()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_SetColor_uScriptAct_SetColor_3.In(logic_uScriptAct_SetColor_Value_3, out logic_uScriptAct_SetColor_TargetColor_3);
      property_color_Detox_ScriptEditor_Parameter_color_1 = logic_uScriptAct_SetColor_TargetColor_3;
      property_color_Detox_ScriptEditor_Parameter_color_1_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetColor_uScriptAct_SetColor_3.Out;
      
      if ( test_0 == true )
      {
         Relay_In_23();
      }
   }
   
   void Relay_In_4()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_SetColor_uScriptAct_SetColor_4.In(logic_uScriptAct_SetColor_Value_4, out logic_uScriptAct_SetColor_TargetColor_4);
      property_color_Detox_ScriptEditor_Parameter_color_11 = logic_uScriptAct_SetColor_TargetColor_4;
      property_color_Detox_ScriptEditor_Parameter_color_11_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetColor_uScriptAct_SetColor_4.Out;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
   }
   
   void Relay_In_5()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_5.In(logic_uScriptAct_Delay_Duration_5, logic_uScriptAct_Delay_SingleFrame_5);
      logic_uScriptAct_Delay_DrivenDelay_5 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_5.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_Stop_5()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_5.Stop(logic_uScriptAct_Delay_Duration_5, logic_uScriptAct_Delay_SingleFrame_5);
      logic_uScriptAct_Delay_DrivenDelay_5 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_5.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_DrivenDelay_5( )
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_5 = logic_uScriptAct_Delay_uScriptAct_Delay_5.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_5 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_5.AfterDelay == true )
         {
            Relay_In_3();
         }
      }
   }
   void Relay_In_8()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_SetColor_uScriptAct_SetColor_8.In(logic_uScriptAct_SetColor_Value_8, out logic_uScriptAct_SetColor_TargetColor_8);
      property_color_Detox_ScriptEditor_Parameter_color_21 = logic_uScriptAct_SetColor_TargetColor_8;
      property_color_Detox_ScriptEditor_Parameter_color_21_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetColor_uScriptAct_SetColor_8.Out;
      
      if ( test_0 == true )
      {
         Relay_In_20();
      }
   }
   
   void Relay_OnButtonClick_9()
   {
   }
   
   void Relay_OnButtonDown_9()
   {
   }
   
   void Relay_OnButtonUp_9()
   {
      Relay_In_13();
   }
   
   void Relay_In_10()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_10.In(logic_uScriptAct_Delay_Duration_10, logic_uScriptAct_Delay_SingleFrame_10);
      logic_uScriptAct_Delay_DrivenDelay_10 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_10.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_Stop_10()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_10.Stop(logic_uScriptAct_Delay_Duration_10, logic_uScriptAct_Delay_SingleFrame_10);
      logic_uScriptAct_Delay_DrivenDelay_10 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_10.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_DrivenDelay_10( )
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_10 = logic_uScriptAct_Delay_uScriptAct_Delay_10.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_10 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_10.AfterDelay == true )
         {
            Relay_In_8();
         }
      }
   }
   void Relay_In_12()
   {
      {
         {
            logic_uScriptCon_CompareInt_A_12 = local_AddedInt_System_Int32;
            
         }
         {
            logic_uScriptCon_CompareInt_B_12 = local_0_System_Int32;
            
         }
      }
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_12.In(logic_uScriptCon_CompareInt_A_12, logic_uScriptCon_CompareInt_B_12);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_12.GreaterThanOrEqualTo;
      bool test_1 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_12.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_4();
      }
      if ( test_1 == true )
      {
         Relay_In_2();
      }
   }
   
   void Relay_In_13()
   {
      {
         {
            logic_uScriptAct_AddInt_v2_A_13 = property_tokens_Detox_ScriptEditor_Parameter_tokens_14_Get_Refresh( );
         }
         {
            logic_uScriptAct_AddInt_v2_B_13 = AddTokens;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_13.In(logic_uScriptAct_AddInt_v2_A_13, logic_uScriptAct_AddInt_v2_B_13, out logic_uScriptAct_AddInt_v2_IntResult_13, out logic_uScriptAct_AddInt_v2_FloatResult_13);
      local_AddedInt_System_Int32 = logic_uScriptAct_AddInt_v2_IntResult_13;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_13.Out;
      
      if ( test_0 == true )
      {
         Relay_In_12();
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
      logic_uScriptAct_SetColor_uScriptAct_SetColor_17.In(logic_uScriptAct_SetColor_Value_17, out logic_uScriptAct_SetColor_TargetColor_17);
      property_color_Detox_ScriptEditor_Parameter_color_24 = logic_uScriptAct_SetColor_TargetColor_17;
      property_color_Detox_ScriptEditor_Parameter_color_24_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetColor_uScriptAct_SetColor_17.Out;
      
      if ( test_0 == true )
      {
         Relay_In_10();
      }
   }
   
   void Relay_In_20()
   {
      {
         {
            logic_uScriptAct_ClampInt_Target_20 = local_AddedInt_System_Int32;
            
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
      logic_uScriptAct_ClampInt_uScriptAct_ClampInt_20.In(logic_uScriptAct_ClampInt_Target_20, logic_uScriptAct_ClampInt_Min_20, logic_uScriptAct_ClampInt_Max_20, out logic_uScriptAct_ClampInt_IntResult_20, out logic_uScriptAct_ClampInt_FloatResult_20);
      property_tokens_Detox_ScriptEditor_Parameter_tokens_6 = logic_uScriptAct_ClampInt_IntResult_20;
      property_tokens_Detox_ScriptEditor_Parameter_tokens_6_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_23()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_23.In(logic_uScriptAct_Delay_Duration_23, logic_uScriptAct_Delay_SingleFrame_23);
      logic_uScriptAct_Delay_DrivenDelay_23 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_23.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_17();
      }
   }
   
   void Relay_Stop_23()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_23.Stop(logic_uScriptAct_Delay_Duration_23, logic_uScriptAct_Delay_SingleFrame_23);
      logic_uScriptAct_Delay_DrivenDelay_23 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_23.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_17();
      }
   }
   
   void Relay_DrivenDelay_23( )
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_23 = logic_uScriptAct_Delay_uScriptAct_Delay_23.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_23 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_23.AfterDelay == true )
         {
            Relay_In_17();
         }
      }
   }
   void Relay_In_25()
   {
      {
         {
            logic_uScriptAct_SetString_Value_25 = local_27_System_String;
            
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
      logic_uScriptAct_SetString_uScriptAct_SetString_25.In(logic_uScriptAct_SetString_Value_25, logic_uScriptAct_SetString_ToUpperCase_25, logic_uScriptAct_SetString_ToLowerCase_25, logic_uScriptAct_SetString_TrimWhitespace_25, out logic_uScriptAct_SetString_Target_25);
      property_text_Detox_ScriptEditor_Parameter_text_29 = logic_uScriptAct_SetString_Target_25;
      property_text_Detox_ScriptEditor_Parameter_text_29_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_26()
   {
      {
         {
            logic_uScriptAct_IntToString_Target_26 = property_tokens_Detox_ScriptEditor_Parameter_tokens_28_Get_Refresh( );
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
      logic_uScriptAct_IntToString_uScriptAct_IntToString_26.In(logic_uScriptAct_IntToString_Target_26, logic_uScriptAct_IntToString_StandardFormat_26, logic_uScriptAct_IntToString_CustomFormat_26, logic_uScriptAct_IntToString_CustomCulture_26, out logic_uScriptAct_IntToString_Result_26);
      local_27_System_String = logic_uScriptAct_IntToString_Result_26;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_IntToString_uScriptAct_IntToString_26.Out;
      
      if ( test_0 == true )
      {
         Relay_In_25();
      }
   }
   
   void Relay_OnUpdate_30()
   {
      Relay_In_26();
   }
   
   void Relay_OnLateUpdate_30()
   {
   }
   
   void Relay_OnFixedUpdate_30()
   {
   }
   
   void Relay_uScriptEnable_31()
   {
      Relay_In_41();
   }
   
   void Relay_uScriptDisable_31()
   {
   }
   
   void Relay_uScriptDestroy_31()
   {
   }
   
   void Relay_True_32()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_32.True(out logic_uScriptAct_SetBool_Target_32);
      property_active_Detox_ScriptEditor_Parameter_active_33 = logic_uScriptAct_SetBool_Target_32;
      property_active_Detox_ScriptEditor_Parameter_active_33_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_False_32()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_32.False(out logic_uScriptAct_SetBool_Target_32);
      property_active_Detox_ScriptEditor_Parameter_active_33 = logic_uScriptAct_SetBool_Target_32;
      property_active_Detox_ScriptEditor_Parameter_active_33_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnButtonClick_35()
   {
   }
   
   void Relay_OnButtonDown_35()
   {
   }
   
   void Relay_OnButtonUp_35()
   {
      Relay_In_37();
   }
   
   void Relay_In_37()
   {
      {
         {
            logic_uScriptCon_CompareInt_A_37 = property_tokens_Detox_ScriptEditor_Parameter_tokens_38_Get_Refresh( );
         }
         {
         }
      }
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_37.In(logic_uScriptCon_CompareInt_A_37, logic_uScriptCon_CompareInt_B_37);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_37.LessThanOrEqualTo;
      
      if ( test_0 == true )
      {
         Relay_True_40();
      }
   }
   
   void Relay_True_40()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_40.True(out logic_uScriptAct_SetBool_Target_40);
      property_active_Detox_ScriptEditor_Parameter_active_39 = logic_uScriptAct_SetBool_Target_40;
      property_active_Detox_ScriptEditor_Parameter_active_39_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_False_40()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_40.False(out logic_uScriptAct_SetBool_Target_40);
      property_active_Detox_ScriptEditor_Parameter_active_39 = logic_uScriptAct_SetBool_Target_40;
      property_active_Detox_ScriptEditor_Parameter_active_39_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_41()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_41.In(logic_uScriptAct_Delay_Duration_41, logic_uScriptAct_Delay_SingleFrame_41);
      logic_uScriptAct_Delay_DrivenDelay_41 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_41.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_False_32();
      }
   }
   
   void Relay_Stop_41()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_41.Stop(logic_uScriptAct_Delay_Duration_41, logic_uScriptAct_Delay_SingleFrame_41);
      logic_uScriptAct_Delay_DrivenDelay_41 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_41.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_False_32();
      }
   }
   
   void Relay_DrivenDelay_41( )
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_41 = logic_uScriptAct_Delay_uScriptAct_Delay_41.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_41 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_41.AfterDelay == true )
         {
            Relay_False_32();
         }
      }
   }
}
