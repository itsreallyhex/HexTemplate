using BepInEx;
using GorillaLocomotion;
using Photon.Pun;
using UnityEngine;
using Photon.Realtime;
using HarmonyLib;
using Photon;
using UnityEngine.InputSystem;

// This is a Template I made witouit a menu or anything. I made the injection and the rest is to u!. Enjoy :)  04/02/2026-06/02/2026 - Hex

namespace Hex_Template
{
    //  U can change the GUID, NAME and version in the pluginfo.cs 
    [BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.Version)]
    public class Test : BaseUnityPlugin
    {
       
       

            public void Awake()
            {
            // Just to check if the plugin is loaded, don't recommend removing this line
            Debug.Log($"{PluginInfo.NAME} is loaded");

            // Example of how to change the max jump speed of the player when pressing J key
            if (Keyboard.current[Key.J].wasPressedThisFrame)
                {
                    GTPlayer.Instance.maxJumpSpeed = 60f;
                    Debug.Log("Max Jump Speed set to: " + GTPlayer.Instance.maxJumpSpeed);
                }

            }
         
        


        public void Update()
        {
            //This is called every frame,
          
        }
    }

}