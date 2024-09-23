using HarmonyLib;

namespace BuffCompany.Patches
{
    [HarmonyPatch(typeof(CrawlerAI), "Start")]
    internal class CrawlerPatch
    {
        static void Prefix(CrawlerAI __instance)
        {
            __instance.enemyHP = 5;
        }
    }
}
