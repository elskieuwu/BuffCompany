using HarmonyLib;

namespace BuffCompany.Patches
{
    [HarmonyPatch(typeof(HoarderBugAI), "Start")]
    internal class HoarderBugPatch
    {
        static void Prefix(HoarderBugAI __instance)
        {
            __instance.enemyHP = 5;
        }
    }
}
