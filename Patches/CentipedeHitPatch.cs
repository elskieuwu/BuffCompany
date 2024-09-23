using HarmonyLib;

namespace BuffCompany.Patches
{
    [HarmonyPatch(typeof(CentipedeAI), "HitEnemy")]
    internal class CentipedeHitPatch
    {
        static void Prefix(CentipedeAI __instance)
        {
            __instance.enemyHP = 6;
        }
    }
}
