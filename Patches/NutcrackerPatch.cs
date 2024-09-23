using HarmonyLib;

namespace BuffCompany.Patches
{
    [HarmonyPatch(typeof(NutcrackerEnemyAI), "Start")]
    internal class NutcrackerPatch
    {
        static void Prefix(NutcrackerEnemyAI __instance)
        {
            __instance.enemyHP = 7;
        }
    }
}
