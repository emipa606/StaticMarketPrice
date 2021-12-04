using HarmonyLib;
using RimWorld;

namespace StaticMarketPrice.HarmonyPatches;

[HarmonyPatch(typeof(Tradeable), "GetPriceTooltip")]
public static class StaticMarketPrice_GetPriceTooltip
{
    public static bool Prefix(ref string __result, ref Tradeable __instance, TradeAction action)
    {
        __result = StatDefOf.MarketValue.LabelCap + ": " + __instance.BaseMarketValue;
        return false;
    }
}