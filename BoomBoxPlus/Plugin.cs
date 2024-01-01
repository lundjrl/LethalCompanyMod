using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace BoomBoxPlus
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class BoomBoxBase : BaseUnityPlugin
    {
        private const string modGUID = "Lundjrl.BoomBoxPlus";
        private const string modName = "Boom Box Plus";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static BoomBoxBase Instance;

        internal ManualLogSource mls;

        // Unity onInit function
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("The test mod is woke.");

            harmony.PatchAll(typeof(BoomBoxBase));
        }
    }
}
