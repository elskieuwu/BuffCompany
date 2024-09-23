using HarmonyLib;

namespace BuffCompany.Patches
{
    [HarmonyPatch(typeof(ButlerEnemyAI), "Start")]
    internal class ButlerEnemyStartPatch
    {
        static void Postfix(ButlerEnemyAI __instance)
        {
            __instance.enemyHP = 8;
            __instance.idleMovementSpeedBase = 3.5f;
        }
    }
}
