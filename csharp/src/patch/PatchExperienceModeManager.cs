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
        static bool Prefix(ExperienceModeManager __instance, CustomExperienceMode __result) {
            ExperienceModeType _m = __instance.GetCurrentExperienceModeType();
            if (_m == ExperienceModeType.ChallengeHunted
                || _m == ExperienceModeType.ChallengeHuntedPart2
                || _m == ExperienceModeType.ChallengeNomad
                || _m == ExperienceModeType.ChallengeRescue
                || _m == ExperienceModeType.ChallengeWhiteout) {

                CustomExperienceMode res = new CustomExperienceMode();
                res.m_AuroraFrequency = DifficultySettings.m_AuroraFrequency;
                res.m_BaseWorldDifficulty = DifficultySettings.m_BaseWorldDifficulty;
                res.m_ScentIncreaseFromMeatBlood = DifficultySettings.m_ScentIncreaseFromMeatBlood;
                res.m_PlantSpawnFrequency = DifficultySettings.m_PlantSpawnFrequency;
                res.m_WildlifeDetectionRange = DifficultySettings.m_WildlifeDetectionRange;
                res.m_WildlifeSpawnFrequency = DifficultySettings.m_WildlifeSpawnFrequency;
                res.m_WindVariability = DifficultySettings.m_WindVariability;
                res.m_WolfFleeChance = DifficultySettings.m_WolfFleeChance;
                res.m_WildlifeNotAttackUnprovoked = DifficultySettings.m_WildlifeNotAttackUnprovoked;
                res.m_EnableBrokenRibs = DifficultySettings.m_EnableBrokenRibs;
                res.m_CabinFeverEnabled = DifficultySettings.m_CabinFeverEnabled;
                res.m_RiflesInWorld = DifficultySettings.m_RiflesInWorld;
                res.m_EnableDysentery = DifficultySettings.m_EnableDysentery;
                res.m_EnableFoodPoisoning = DifficultySettings.m_EnableFoodPoisoning;
                res.m_AdjustFreezingDueToNearbyFire = DifficultySettings.m_AdjustFreezingDueToNearbyFire;
                res.m_FrosbiteRisk = DifficultySettings.m_FrosbiteRisk;
                res.m_ParasitesEnabled = DifficultySettings.m_ParasitesEnabled;
                res.m_AllowInteriorStartingSpawn = DifficultySettings.m_AllowInteriorStartingSpawn;
                res.m_StartWeather = DifficultySettings.m_StartWeather;
                res.m_StartTimeOfDay = DifficultySettings.m_StartTimeOfDay;
                res.m_SurvivorVoiceOver = DifficultySettings.m_SurvivorVoiceOver;
                res.m_LimitedRest = DifficultySettings.m_LimitedRest;
                res.m_InterruptIfFreezingWhileSleeping = DifficultySettings.m_InterruptIfFreezingWhileSleeping;
                res.m_WildlifeInterruptRest = DifficultySettings.m_WildlifeInterruptRest;
                res.m_BearSpawnChance = DifficultySettings.m_BearSpawnChance;
                res.m_WolfSpawnChance = DifficultySettings.m_WolfSpawnChance;
                res.m_MooseSpawnChance = DifficultySettings.m_MooseSpawnChance;
                res.m_DeerSpawnChance = DifficultySettings.m_DeerSpawnChance;
                res.m_RabbitSpawnChance = DifficultySettings.m_RabbitSpawnChance;
                res.m_NoPredatorsFirstDay = DifficultySettings.m_NoPredatorsFirstDay;
                res.m_EnableSprains = DifficultySettings.m_EnableSprains;
                res.m_StartingGear = DifficultySettings.m_StartingGear;
                res.m_StruggleDamageEventSeverity = DifficultySettings.m_StruggleDamageEventSeverity;
                res.m_UseMinAirTempValue = DifficultySettings.m_UseMinAirTempValue;
                res.m_DayNightLengthMultiplier = DifficultySettings.m_DayNightLengthMultiplier;
                res.m_WeatherChangeFrequency = DifficultySettings.m_WeatherChangeFrequency;
                res.m_BlizzardFrequency = DifficultySettings.m_BlizzardFrequency;
                res.m_GradualTempReductionRate = DifficultySettings.m_GradualTempReductionRate;
                res.m_CalorieBurnRate = DifficultySettings.m_CalorieBurnRate;
                res.m_ThirstIncrease = DifficultySettings.m_ThirstIncrease;
                res.m_FatigueIncrease = DifficultySettings.m_FatigueIncrease;
                res.m_FreezingIncrease = DifficultySettings.m_FreezingIncrease;
                res.m_ConditionRecoveryAwake = DifficultySettings.m_ConditionRecoveryAwake;
                res.m_ConditionRecoveryRest = DifficultySettings.m_ConditionRecoveryRest;
                res.m_HoursWarmthToCureHypothermia = DifficultySettings.m_HoursWarmthToCureHypothermia;
                res.m_ItemDecayRate = DifficultySettings.m_ItemDecayRate;
                res.m_ItemSpawnChance = DifficultySettings.m_ItemSpawnChance;
                res.m_EmptyContainerChance = DifficultySettings.m_EmptyContainerChance;
                res.m_StickBranchStoneSpawnFrequency = DifficultySettings.m_StickBranchStoneSpawnFrequency;
                res.m_ReduceMaxItemsContainers = DifficultySettings.m_ReduceMaxItemsContainers;
                res.m_StrugglePlayerStrengthBonus = DifficultySettings.m_StrugglePlayerStrengthBonus;
                res.m_StruggleDamageReceivedBonus = DifficultySettings.m_StruggleDamageReceivedBonus;
                res.m_StruggleClothingDamageBonus = DifficultySettings.m_StruggleClothingDamageBonus;
                res.m_FishSpawnChance = DifficultySettings.m_FishSpawnChance;
                res.m_WildlifeSmellRange = DifficultySettings.m_WildlifeSmellRange;
                res.m_ReduceWildlifePopOverTime = DifficultySettings.m_ReduceWildlifePopOverTime;

                __result = res;
                return false;
            }
            return true;
        }
    }
}
