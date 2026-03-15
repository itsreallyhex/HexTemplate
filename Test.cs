using BepInEx;
using GorillaLocomotion;
using Photon.Pun;
using UnityEngine;
using Photon.Realtime;
using HarmonyLib;
using Photon;

// This is a Template I made witouit a menu or anything. I made the injection and the rest is to u!. Enjoy :)  04/02/2026-06/02/2026 - Hex

namespace Hex_Template
{
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            //This is called when the plugin is loaded, you can use it to initialize things or to patch methods with Harmony.
        }

        public void Update()
        {
            //This is called every frame,
            //you can use it to check for input or to do things that need to be done every frame. Such as checking if the player is Tagged or not
        }
    }

}