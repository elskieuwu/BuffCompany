using HarmonyLib;

namespace BuffCompany.Patches
{
    [HarmonyPatch(typeof(MaskedPlayerEnemy), "Start")]
    internal class MaskedPlayerEnemyPatch
    {
        static void Prefix(MaskedPlayerEnemy __instance)
        {
            __instance.enemyHP = 5;
        }
    }
}
