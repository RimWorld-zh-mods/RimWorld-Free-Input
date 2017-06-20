using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using RimWorld;
using Verse;
using Harmony;

namespace duduluu.FreeInput.Patches {
    /// <summary>
    /// Replace vanilla rename character input method.
    /// </summary>
    [HarmonyPatch(typeof(CharacterCardUtility))]
    [HarmonyPatch("DoNameInputRect")]
    public static class CharacterCardUtility_Patch {
        [HarmonyPrefix]
        public static void DoNameInputRect_Free(Rect rect, ref string name, int maxLength) {
            string text = Widgets.TextField(rect, name);
            if (text.Length <= maxLength) {
                name = text;
            }
        }
    }
}
