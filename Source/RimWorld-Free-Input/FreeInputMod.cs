using System;
using System.Reflection;
using System.Text.RegularExpressions;
using RimWorld;
using Verse;

namespace duduluu.FreeInput {
    [StaticConstructorOnStartup]
    public static class FreeInputMod {
        static FreeInputMod() {
            Regex validNameRegex_free = new Regex(".*");
            BindingFlags bindingAttr = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
            typeof(CharacterCardUtility).GetField("validNameRegex", bindingAttr).SetValue(null, validNameRegex_free);
            typeof(Outfit).GetField("ValidNameRegex", bindingAttr).SetValue(null, validNameRegex_free);
        }
    }
}
