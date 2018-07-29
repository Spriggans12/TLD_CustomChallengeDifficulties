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
            } catch (Exception e) {
                FileLog.Log(e.Message);
                throw;
            }

            return true;
        }

        // Main patch function.
        [HarmonyPriority(100)]
        static void Postfix(ExperienceMode __instance) {
            FileLog.Log(__instance.ToString());

            if (__instance.m_ModeType == ExperienceModeType.ChallengeNomad
                || __instance.m_ModeType == ExperienceModeType.ChallengeHunted
                || __instance.m_ModeType == ExperienceModeType.ChallengeHuntedPart2
                || __instance.m_ModeType == ExperienceModeType.ChallengeRescue
                || __instance.m_ModeType == ExperienceModeType.ChallengeWhiteout) {
                CustomExperienceModeManager component = ((UnityEngine.Component)__instance).GetComponent<CustomExperienceModeManager>();
                List<ExperienceMode> list = new List<ExperienceMode>();
                list.Add(GameManager.GetExperienceModeManagerComponent().GetSpecificExperienceMode(ExperienceModeType.Pilgrim));
                list.Add(GameManager.GetExperienceModeManagerComponent().GetSpecificExperienceMode(ExperienceModeType.Voyageur));
                list.Add(GameManager.GetExperienceModeManagerComponent().GetSpecificExperienceMode(ExperienceModeType.Stalker));
                list.Add(GameManager.GetExperienceModeManagerComponent().GetSpecificExperienceMode(ExperienceModeType.Interloper));
                __instance.m_DayNightDurationScale = (float)(DifficultySettings.m_DayNightLengthMultiplier + 1);
                __instance.m_WeatherDurationScale = list[(int)(CustomExperienceModeManager.CustomTunableLMHV.VeryHigh - DifficultySettings.m_WeatherChangeFrequency)].m_WeatherDurationScale;
                if (DifficultySettings.m_BlizzardFrequency == CustomExperienceModeManager.CustomTunableNLMHV.None) {
                    __instance.m_ChanceOfBlizzardScale = 0f;
                } else {
                    __instance.m_ChanceOfBlizzardScale = list[DifficultySettings.m_BlizzardFrequency - CustomExperienceModeManager.CustomTunableNLMHV.Low].m_ChanceOfBlizzardScale;
                }
                if (DifficultySettings.m_CalorieBurnRate == CustomExperienceModeManager.CustomTunableLMHV.Medium) {
                    __instance.m_CalorieBurnScale = list[2].m_CalorieBurnScale;
                } else if (DifficultySettings.m_CalorieBurnRate == CustomExperienceModeManager.CustomTunableLMHV.High) {
                    __instance.m_CalorieBurnScale = list[1].m_CalorieBurnScale;
                } else {
                    __instance.m_CalorieBurnScale = list[(int)DifficultySettings.m_CalorieBurnRate].m_CalorieBurnScale;
                }
                __instance.m_ThirstRateScale = component.m_ThirstScaleList[(int)DifficultySettings.m_ThirstIncrease];
                __instance.m_FreezingRateScale = list[(int)DifficultySettings.m_FreezingIncrease].m_FreezingRateScale;
                 __instance.m_FatigueRateScale = component.m_FatigueScaleList[(int)DifficultySettings.m_FatigueIncrease];
                __instance.m_ConditonRecoveryFromRestScale = component.m_ConditionRecoveryRestList[(int)DifficultySettings.m_ConditionRecoveryRest];
                __instance.m_ConditonRecoveryWhileAwakeScale = component.m_ConditionRecoveryAwakeList[(int)DifficultySettings.m_ConditionRecoveryAwake];
                __instance.m_DecayScale = list[(int)DifficultySettings.m_ItemDecayRate].m_DecayScale;
                __instance.m_GearSpawnChanceScale = list[(int)(CustomExperienceModeManager.CustomTunableLMHV.VeryHigh - DifficultySettings.m_ItemSpawnChance)].m_GearSpawnChanceScale;
                __instance.m_ReduceMaxItemsInContainer = list[(int)(DifficultySettings.m_ReduceMaxItemsContainers + 1)].m_ReduceMaxItemsInContainer;
                __instance.m_ChanceForEmptyContainer = component.m_EmptyContainerChanceList[(int)DifficultySettings.m_EmptyContainerChance];
                __instance.m_SpawnRegionChanceActiveScale = 1f;
                __instance.m_ClosestSpawnDistanceAfterTransitionScale = list[(int)((CustomExperienceModeManager.CustomTunableDistance)3 - DifficultySettings.m_WolfSpawnDistance)].m_ClosestSpawnDistanceAfterTransitionScale;
                __instance.m_SmellRangeScale = component.m_SmellRangeList[(int)DifficultySettings.m_WildlifeSmellRange];
                if (DifficultySettings.m_StrugglePlayerStrengthBonus == CustomExperienceModeManager.CustomTunableNLMH.None) {
                    __instance.m_StruggleTapStrengthScale = list[2].m_StruggleTapStrengthScale;
                } else if (DifficultySettings.m_StrugglePlayerStrengthBonus == CustomExperienceModeManager.CustomTunableNLMH.Low) {
                    __instance.m_StruggleTapStrengthScale = list[3].m_StruggleTapStrengthScale;
                } else {
                    __instance.m_StruggleTapStrengthScale = list[(int)(CustomExperienceModeManager.CustomTunableNLMH.High - DifficultySettings.m_StrugglePlayerStrengthBonus)].m_StruggleTapStrengthScale;
                }
                __instance.m_StrugglePlayerDamageReceivedScale = component.m_StruggleDamageReceivedList[(int)DifficultySettings.m_StruggleDamageReceivedBonus];
                __instance.m_StrugglePlayerClothingDamageScale = component.m_StruggleClothingDamageList[(int)DifficultySettings.m_StruggleClothingDamageBonus];
                __instance.m_StrugglePlayerDamageReceivedIntervalScale = 1f;
                __instance.m_StugglePlayerPercentLossFromBearScale = 1f;
                __instance.m_OutdoorTempDropCelsiusMax = list[(int)DifficultySettings.m_GradualTempReductionRate].m_OutdoorTempDropCelsiusMax;
                __instance.m_OutdoorTempDropDayStart = list[(int)DifficultySettings.m_GradualTempReductionRate].m_OutdoorTempDropDayStart;
                __instance.m_OutdoorTempDropDayFinal = list[(int)DifficultySettings.m_GradualTempReductionRate].m_OutdoorTempDropDayFinal;
                __instance.m_RespawnHoursScaleMax = list[(int)DifficultySettings.m_ReduceWildlifePopOverTime].m_RespawnHoursScaleMax;
                __instance.m_RespawnHoursScaleDayStart = list[(int)DifficultySettings.m_ReduceWildlifePopOverTime].m_RespawnHoursScaleDayStart;
                __instance.m_RespawnHoursScaleDayFinal = list[(int)DifficultySettings.m_ReduceWildlifePopOverTime].m_RespawnHoursScaleDayFinal;
                __instance.m_FishCatchTimeScaleMax = component.m_FishCatchTimeScaleMaxList[(int)DifficultySettings.m_FishSpawnChance];
                __instance.m_FishCatchTimeScaleDayStart = component.m_FishCatchTimeScaleDayStartList[(int)DifficultySettings.m_FishSpawnChance];
                __instance.m_FishCatchTimeScaleDayFinal = component.m_FishCatchTimeScaleDayFinalList[(int)DifficultySettings.m_FishSpawnChance];
                __instance.m_RadialRespawnTimeScaleMax = list[(int)(CustomExperienceModeManager.CustomTunableLMHV.VeryHigh - DifficultySettings.m_StickBranchStoneSpawnFrequency)].m_RadialRespawnTimeScaleMax;
                __instance.m_RadialRespawnTimeScaleDayStart = list[(int)(CustomExperienceModeManager.CustomTunableLMHV.VeryHigh - DifficultySettings.m_StickBranchStoneSpawnFrequency)].m_RadialRespawnTimeScaleDayStart;
                __instance.m_RadialRespawnTimeScaleDayFinal = list[(int)(CustomExperienceModeManager.CustomTunableLMHV.VeryHigh - DifficultySettings.m_StickBranchStoneSpawnFrequency)].m_RadialRespawnTimeScaleDayFinal;
                __instance.m_NumHoursWarmForHypothermiaCureScale = list[(int)DifficultySettings.m_HoursWarmthToCureHypothermia].m_NumHoursWarmForHypothermiaCureScale;
            }
        }
    }
}
