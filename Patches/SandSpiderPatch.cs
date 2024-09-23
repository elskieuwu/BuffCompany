using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine;

namespace BuffCompany.Patches
{
    [HarmonyPatch(typeof(SandSpiderAI), "Start")]
    internal class SandSpiderPatch
    {
        static void Prefix(SandSpiderAI __instance)
        {
            __instance.enemyHP = 7;
        }
    }
}
