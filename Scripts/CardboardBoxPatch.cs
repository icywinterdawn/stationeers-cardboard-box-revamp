using HarmonyLib;
using JetBrains.Annotations;
using Assets.Scripts.Objects.Items;
using Assets.Scripts.Objects;
using Assets.Scripts.UI;

namespace CardboardBoxRevamp.Scripts
{
    [HarmonyPatch]    
    public class CardboardBoxPatch
    {
        [HarmonyReversePatch]
        [HarmonyPatch(typeof(Thing), nameof(Thing.OnChildExitInventory))]
        static void OnChildExitInventory(Thing instance, DynamicItem previousChild) { }

        [UsedImplicitly]
        [HarmonyPatch(typeof(CardboardBox), nameof(CardboardBox.OnChildExitInventory))]
        private static bool Prefix(CardboardBox __instance, DynamicItem previousChild)
        {
            OnChildExitInventory(__instance, previousChild);
            // Overwrite the previous behavior entirely.
            return false;
        }
    }
}
