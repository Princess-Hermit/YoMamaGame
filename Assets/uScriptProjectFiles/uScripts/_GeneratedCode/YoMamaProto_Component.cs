//uScript Generated Code - Build 1.0.3055
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/YoMamaProto")]
public class YoMamaProto_Component : uScriptCode
{
   #pragma warning disable 414
   public YoMamaProto ExposedVariables = new YoMamaProto( ); 
   #pragma warning restore 414
   
   public System.Boolean FoodPressed01 { get { return ExposedVariables.FoodPressed01; } set { ExposedVariables.FoodPressed01 = value; } } 
   public System.Boolean FoodPressed02 { get { return ExposedVariables.FoodPressed02; } set { ExposedVariables.FoodPressed02 = value; } } 
   public System.Boolean FoodPressed03 { get { return ExposedVariables.FoodPressed03; } set { ExposedVariables.FoodPressed03 = value; } } 
   public System.Boolean FoodPressed04 { get { return ExposedVariables.FoodPressed04; } set { ExposedVariables.FoodPressed04 = value; } } 
   public UnityEngine.GameObject[] FoodList { get { return ExposedVariables.FoodList; } set { ExposedVariables.FoodList = value; } } 
   
   void Awake( )
   {
      #if !(UNITY_FLASH)
      useGUILayout = false;
      #endif
      ExposedVariables.Awake( );
      ExposedVariables.SetParent( this.gameObject );
      if ( "1.CMR" != uScript_MasterComponent.Version )
      {
         uScriptDebug.Log( "The generated code is not compatible with your current uScript Runtime " + uScript_MasterComponent.Version, uScriptDebug.Type.Error );
         ExposedVariables = null;
         UnityEngine.Debug.Break();
      }
   }
   void Start( )
   {
      ExposedVariables.Start( );
   }
   void OnEnable( )
   {
      ExposedVariables.OnEnable( );
   }
   void OnDisable( )
   {
      ExposedVariables.OnDisable( );
   }
   void Update( )
   {
      ExposedVariables.Update( );
   }
   void OnDestroy( )
   {
      ExposedVariables.OnDestroy( );
   }
   #if UNITY_EDITOR
      void OnDrawGizmos( )
      {
         {
            GameObject gameObject;
            gameObject = GameObject.Find( "Brody" ); 
            if ( null != gameObject ) Gizmos.DrawIcon(gameObject.transform.position, "uscript_gizmo_variables.png");
         }
      }
   #endif
}
