using HarmonyLib;

namespace BuffCompany.Patches
{
    [HarmonyPatch(typeof(ForestGiantAI), "HitEnemy")]
    internal class ForestGiantPatch
    {
        static void Prefix(ForestGiantAI __instance)
        {
            __instance.enemyHP = 38;
        }
    }
}
