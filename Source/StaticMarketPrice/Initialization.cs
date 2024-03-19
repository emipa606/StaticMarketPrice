using System;
using System.Reflection;
using HarmonyLib;
using Verse;

namespace StaticMarketPrice;

[StaticConstructorOnStartup]
public static class Initialization
{
    static Initialization()
    {
        try
        {
            new Harmony("Harmony_StaticMarketPrice").PatchAll(Assembly.GetExecutingAssembly());
        }
        catch (Exception e)
        {
            Log.Error($"StaticMarketPrice Mod Exception, failed to proceed harmony patches: {e.Message}");
        }
    }
}