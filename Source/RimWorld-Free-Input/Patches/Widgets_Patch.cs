using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using Verse;
using Harmony;

namespace duduluu.FreeInput.Patches {
    /// <summary>
    /// Replace vanilla TextField input method.
    /// </summary>
    [HarmonyPatch(typeof(Widgets))]
    [HarmonyPatch("TextField")]
    [HarmonyPatch(new Type[] { typeof(Rect), typeof(string), typeof(int), typeof(Regex)})]
    public static class Widgets_Patch {
        [HarmonyPrefix]
        public static bool TextField_Free(ref string __result, Rect rect, string text, int maxLength, Regex inputValidator) {
            string text2 = Widgets.TextField(rect, text);
            if (text2.Length <= maxLength) {
                __result = text2;
                return false;
            }
            __result = text;
            return false;
        }
    }
}
