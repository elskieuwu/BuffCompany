using HarmonyLib;

namespace BuffCompany.Patches
{
    [HarmonyPatch(typeof(CentipedeAI), "Start")]
    internal class CentipedeStartPatch
    {
        static void Prefix(CentipedeAI __instance)
        {
            __instance.enemyHP = 6;
            __instance.singlePlayerSecondChanceGiven = true;
        }
    }
}
