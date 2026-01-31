/*using BepInEx;
using HarmonyLib;

namespace Hex_Template
{
    [System.ComponentModel.Description(PluginInfo.Description)]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {
        private void Awake() =>
            GorillaTagger.OnPlayerSpawned(OnPlayerSpawned);

        public void OnPlayerSpawned() =>
            Patches.PatchHandler.PatchAll();
    }
}*/
