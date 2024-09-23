using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace BuffCompany;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class BuffCompany : BaseUnityPlugin
{
    public static BuffCompany Instance { get; private set; } = null!;
    internal new static ManualLogSource Logger { get; private set; } = null!;
    internal static Harmony? Harmony { get; set; }

    private void Awake()
    {
        Logger = base.Logger;
        Instance = this;

        Patch();

        Logger.LogInfo($"{MyPluginInfo.PLUGIN_GUID} v{MyPluginInfo.PLUGIN_VERSION} has loaded. Good luck.");
    }

    internal static void Patch()
    {
        Harmony ??= new Harmony(MyPluginInfo.PLUGIN_GUID);

        Harmony.PatchAll();

        Logger.LogDebug("Patched");
    }

    internal static void Unpatch()
    {
        Harmony?.UnpatchSelf();

        Logger.LogDebug("Unpatched");
    }
}
