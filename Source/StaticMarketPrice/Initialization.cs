using System.Reflection;
using HarmonyLib;
using Verse;

namespace StaticMarketPrice;

[StaticConstructorOnStartup]
public static class Initialization
{
    static Initialization()
    {
        new Harmony("Harmony_StaticMarketPrice").PatchAll(Assembly.GetExecutingAssembly());
    }
}