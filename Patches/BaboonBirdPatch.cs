using HarmonyLib;

namespace BuffCompany.Patches
{
    [HarmonyPatch(typeof(BaboonBirdAI), "Start")]
    internal class BaboonBirdPatch
    {
        static void Prefix(BaboonBirdAI __instance)
        {
            __instance.enemyHP = 6;
        }
    }
}
