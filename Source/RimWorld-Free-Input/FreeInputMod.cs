using System;
using System.Reflection;
using Verse;
using Harmony;

namespace duduluu.FreeInput {
    [StaticConstructorOnStartup]
    public static class FreeInputMod {
        static FreeInputMod() {
            var harmony = HarmonyInstance.Create("duduluu.FreeInput");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
