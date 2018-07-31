using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace CustomChallengeDifficulties {

    [HarmonyPatch(typeof(ExperienceModeManager), "InCustomMode")]
    class PatchExperienceModeManagerInCustomMode {

        // - returns a boolean that controls if original is executed (true) or not (false)
        static bool Prefix(ExperienceModeManager __instance, bool __result) {
            ExperienceModeType _m = __instance.GetCurrentExperienceModeType();
            if(_m == ExperienceModeType.ChallengeHunted
                || _m == ExperienceModeType.ChallengeHuntedPart2
                || _m == ExperienceModeType.ChallengeNomad
                || _m == ExperienceModeType.ChallengeRescue
                || _m == ExperienceModeType.ChallengeWhiteout) {
                __result = true;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(ExperienceModeManager), "GetCustomMode")]
    class PatchExperienceModeManagerGetCustomMode {

        // - returns a boolean that controls if original is executed (true) or not (false)
        static bool Prefix(ExperienceModeManager __instance, __) {


            return true;
        }
    }
}
