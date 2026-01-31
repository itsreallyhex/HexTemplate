using BepInEx;
using GorillaLocomotion;
using Photon.Realtime;
using UnityEngine;

namespace Hex_Template
{
    public class Test : BaseUnityPlugin
    {
        public void Update()
        {
            if (UnityInput.Current.GetKeyDown(KeyCode.T))
            {
                Logger.LogInfo("T key was pressed! Hex is here.");
            }



          
        }
    }
}