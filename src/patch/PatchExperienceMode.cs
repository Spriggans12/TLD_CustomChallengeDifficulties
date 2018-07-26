using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace CustomChallengeDifficulties {

    // Experience mode patch.
    [HarmonyPatch(typeof(ExperienceMode), "Start", new Type[0])]
    class PatchExperienceMode {
        static bool Prepare() {
            try {
                DifficultySettings.Load();
                ChallengeNomadSettings.Load();
            } catch (Exception e) {
                Debug.LogFormat(e.Message);
                throw;
            }

            return true;
        }

        // Main patch function.
        [HarmonyPriority(100)]
        static void Postfix(ExperienceMode __instance) {
            if (__instance.m_ModeType == ExperienceModeType.ChallengeNomad) {
                __instance.m_DayNightDurationScale = DifficultySettings.m_DayNightDurationScale;
                __instance.m_WeatherDurationScale = DifficultySettings.m_WeatherDurationScale;
                __instance.m_ChanceOfBlizzardScale = DifficultySettings.m_ChanceOfBlizzardScale;
                __instance.m_CalorieBurnScale = DifficultySettings.m_CalorieBurnScale;
                __instance.m_ThirstRateScale = DifficultySettings.m_ThirstRateScale;
                __instance.m_FreezingRateScale = DifficultySettings.m_FreezingRateScale;
                __instance.m_FatigueRateScale = DifficultySettings.m_FatigueRateScale;
                __instance.m_ConditonRecoveryFromRestScale = DifficultySettings.m_ConditonRecoveryFromRestScale;
                __instance.m_ConditonRecoveryWhileAwakeScale = DifficultySettings.m_ConditonRecoveryWhileAwakeScale;
                __instance.m_DecayScale = DifficultySettings.m_DecayScale;
                __instance.m_GearSpawnChanceScale = DifficultySettings.m_GearSpawnChanceScale;
                __instance.m_ReduceMaxItemsInContainer = DifficultySettings.m_ReduceMaxItemsInContainer;
                __instance.m_ChanceForEmptyContainer = DifficultySettings.m_ChanceForEmptyContainer;
                __instance.m_SpawnRegionChanceActiveScale = DifficultySettings.m_SpawnRegionChanceActiveScale;
                __instance.m_ClosestSpawnDistanceAfterTransitionScale = DifficultySettings.m_ClosestSpawnDistanceAfterTransitionScale;
                __instance.m_SmellRangeScale = DifficultySettings.m_SmellRangeScale;
                __instance.m_StruggleTapStrengthScale = DifficultySettings.m_StruggleTapStrengthScale;
                __instance.m_StrugglePlayerDamageReceivedIntervalScale = DifficultySettings.m_StrugglePlayerDamageReceivedIntervalScale;
                __instance.m_StrugglePlayerDamageReceivedScale = DifficultySettings.m_StrugglePlayerDamageReceivedScale;
                __instance.m_StrugglePlayerClothingDamageScale = DifficultySettings.m_StrugglePlayerClothingDamageScale;
                __instance.m_StugglePlayerPercentLossFromBearScale = DifficultySettings.m_StugglePlayerPercentLossFromBearScale;
                __instance.m_OutdoorTempDropCelsiusMax = DifficultySettings.m_OutdoorTempDropCelsiusMax;
                __instance.m_OutdoorTempDropDayStart = DifficultySettings.m_OutdoorTempDropDayStart;
                __instance.m_OutdoorTempDropDayFinal = DifficultySettings.m_OutdoorTempDropDayFinal;
                __instance.m_RespawnHoursScaleMax = DifficultySettings.m_RespawnHoursScaleMax;
                __instance.m_RespawnHoursScaleDayStart = DifficultySettings.m_RespawnHoursScaleDayStart;
                __instance.m_RespawnHoursScaleDayFinal = DifficultySettings.m_RespawnHoursScaleDayFinal;
                __instance.m_FishCatchTimeScaleMax = DifficultySettings.m_FishCatchTimeScaleMax;
                __instance.m_FishCatchTimeScaleDayStart = DifficultySettings.m_FishCatchTimeScaleDayStart;
                __instance.m_FishCatchTimeScaleDayFinal = DifficultySettings.m_FishCatchTimeScaleDayFinal;
                __instance.m_RadialRespawnTimeScaleMax = DifficultySettings.m_RadialRespawnTimeScaleMax;
                __instance.m_RadialRespawnTimeScaleDayStart = DifficultySettings.m_RadialRespawnTimeScaleDayStart;
                __instance.m_RadialRespawnTimeScaleDayFinal = DifficultySettings.m_RadialRespawnTimeScaleDayFinal;
                __instance.m_NumHoursWarmForHypothermiaCureScale = DifficultySettings.m_NumHoursWarmForHypothermiaCureScale;
            }
        }
    }
}
