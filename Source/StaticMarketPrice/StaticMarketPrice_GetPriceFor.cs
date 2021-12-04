﻿using HarmonyLib;
using RimWorld;

namespace StaticMarketPrice.HarmonyPatches;

[HarmonyPatch(typeof(Tradeable), "GetPriceFor")]
public static class StaticMarketPrice_GetPriceFor
{
    public static bool Prefix(ref float __result, ref Tradeable __instance, TradeAction action)
    {
        __result = __instance.BaseMarketValue *
                   TradeSession.trader.TraderKind.PriceTypeFor(__instance.ThingDef, action).PriceMultiplier();
        return false;
    }
}