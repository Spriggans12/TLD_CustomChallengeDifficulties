using System;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class contains all the variables you can set in a vanilla sandbox game with a Custom difficulty.
 * The values loaded are read from the file mods/customChallengesSettings/difficulty_settings.txt
 * This file can be edited prior to launching the game.
 * You can use the JAVA program to generate a difficulty_settings file from a String dump of an in-game Custom difficulty (cf documentation for how to use it)
 */
namespace CustomChallengeDifficulties {

    public static class DifficultySettings {

        public static string FILE = "mods/customChallengesSettings/difficulty_settings.txt";

        /////////
        // Variables from CustomExperienceMode
        /////////
        public static bool m_AllowInteriorStartingSpawn;
        public static bool m_SurvivorVoiceOver;
        public static bool m_WeakIce;
        public static bool m_UseMinAirTempValue;
        public static bool m_EnableDysentery;
        public static bool m_EnableSprains;
        public static bool m_EnableFoodPoisoning;
        public static bool m_EnableBrokenRibs;
        public static bool m_LimitedRest;
        public static bool m_AdjustFreezingDueToNearbyFire;
        public static bool m_InterruptIfFreezingWhileSleeping;
        public static bool m_RiflesInWorld;
        public static CustomExperienceModeManager.CustomTunableLMHV m_BaseWorldDifficulty;
        public static CustomExperienceModeManager.CustomTunableNLMH m_StruggleClothingDamageBonus;
        public static CustomExperienceModeManager.CustomTunableDayNightMultiplier m_DayNightLengthMultiplier;
        public static CustomExperienceModeManager.CustomTunableLMHV m_WeatherChangeFrequency;
        public static CustomExperienceModeManager.CustomTunableNLMH m_StrugglePlayerStrengthBonus;
        public static CustomExperienceModeManager.CustomTunableNLMH m_GradualTempReductionRate;
        public static CustomExperienceModeManager.CustomTunableNLMH m_AuroraFrequency;
        public static CustomExperienceModeManager.CustomTunableLMHV m_CalorieBurnRate;
        public static CustomExperienceModeManager.CustomTunableLMHV m_ThirstIncrease;
        public static CustomExperienceModeManager.CustomTunableLMHV m_FatigueIncrease;
        public static CustomExperienceModeManager.CustomTunableLMHV m_FreezingIncrease;
        public static CustomExperienceModeManager.CustomTunableLMHV m_HoursWarmthToCureHypothermia;
        public static CustomExperienceModeManager.CustomTunableLMHV m_ItemDecayRate;
        public static CustomExperienceModeManager.CustomTunableLMHV m_ItemSpawnChance;
        public static CustomExperienceModeManager.CustomTunableNLMH m_ReduceWildlifePopOverTime;
        public static CustomExperienceModeManager.CustomTunableNLMH m_EmptyContainerChance;
        public static CustomExperienceModeManager.CustomTunableLMHV m_StickBranchStoneSpawnFrequency;
        public static CustomExperienceModeManager.CustomTunableLMHV m_StartingGear;
        public static CustomExperienceModeManager.CustomTunableNLMH m_StruggleDamageReceivedBonus;
        public static CustomExperienceModeManager.CustomTunableNLMH m_ScentIncreaseFromMeatBlood;
        public static CustomExperienceModeManager.CustomTunableNLMH m_WolfFleeChance;
        public static CustomExperienceModeManager.CustomTunableLMHV m_StruggleDamageEventSeverity;
        public static CustomExperienceModeManager.CustomTunableLMHV m_WildlifeSmellRange;
        public static CustomExperienceModeManager.CustomTunableLMHV m_WildlifeSpawnFrequency;
        public static bool m_WildlifeNotAttackUnprovoked;
        public static bool m_NoPredatorsFirstDay;
        public static bool m_CabinFeverEnabled;
        public static bool m_ParasitesEnabled;
        public static CustomExperienceModeManager.CustomTunableNLMHV m_ConditionRecoveryRest;
        public static CustomExperienceModeManager.CustomTunableNLMHV m_ConditionRecoveryAwake;
        public static CustomExperienceModeManager.CustomTunableNLMHV m_FrosbiteRisk;
        public static CustomExperienceModeManager.CustomTunableNLMHV m_RabbitSpawnChance;
        public static CustomExperienceModeManager.CustomTunableNLMHV m_BearSpawnChance;
        public static CustomExperienceModeManager.CustomTunableNLMHV m_BlizzardFrequency;
        public static CustomExperienceModeManager.CustomTunableNLMHV m_DeerSpawnChance;
        public static CustomExperienceModeManager.CustomTunableNLMHV m_FishSpawnChance;
        public static CustomExperienceModeManager.CustomTunableNLMHV m_WolfSpawnChance;
        public static CustomExperienceModeManager.CustomTunableTimeOfDay m_StartTimeOfDay;
        public static bool m_WildlifeInterruptRest;
        public static CustomExperienceModeManager.CustomTunableLMH m_WindVariability;
        public static CustomExperienceModeManager.CustomTunableLMH m_PlantSpawnFrequency;
        public static CustomExperienceModeManager.CustomTunableNLH m_ReduceMaxItemsContainers;
        public static CustomExperienceModeManager.CustomTunableWeather m_StartWeather;
        public static CustomExperienceModeManager.CustomTunableDistance m_WolfSpawnDistance;
        public static CustomExperienceModeManager.CustomTunableDistance m_WildlifeDetectionRange;
        public static CustomExperienceModeManager.CustomTunableNLMHV m_MooseSpawnChance;




        /////////
        /////////
        /////////

        public static void Load() {
            List<VariableAndSetter> varList = new List<VariableAndSetter> {
                new VariableAndSetter("AllowInteriorStartingSpawn", x => m_AllowInteriorStartingSpawn = (bool)x, typeof(bool)),
                new VariableAndSetter("SurvivorVoiceOver", x => m_SurvivorVoiceOver = (bool)x, typeof(bool)),
                new VariableAndSetter("WeakIce", x => m_WeakIce = (bool)x, typeof(bool)),
                new VariableAndSetter("UseMinAirTempValue", x => m_UseMinAirTempValue = (bool)x, typeof(bool)),
                new VariableAndSetter("EnableDysentery", x => m_EnableDysentery = (bool)x, typeof(bool)),
                new VariableAndSetter("EnableSprains", x => m_EnableSprains = (bool)x, typeof(bool)),
                new VariableAndSetter("EnableFoodPoisoning", x => m_EnableFoodPoisoning = (bool)x, typeof(bool)),
                new VariableAndSetter("EnableBrokenRibs", x => m_EnableBrokenRibs = (bool)x, typeof(bool)),
                new VariableAndSetter("LimitedRest", x => m_LimitedRest = (bool)x, typeof(bool)),
                new VariableAndSetter("AdjustFreezingDueToNearbyFire", x => m_AdjustFreezingDueToNearbyFire = (bool)x, typeof(bool)),
                new VariableAndSetter("InterruptIfFreezingWhileSleeping", x => m_InterruptIfFreezingWhileSleeping = (bool)x, typeof(bool)),
                new VariableAndSetter("RiflesInWorld", x => m_RiflesInWorld = (bool)x, typeof(bool)),
                new VariableAndSetter("BaseWorldDifficulty", x => m_BaseWorldDifficulty = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("StruggleClothingDamageBonus", x => m_StruggleClothingDamageBonus = (CustomExperienceModeManager.CustomTunableNLMH)x, typeof(CustomExperienceModeManager.CustomTunableNLMH)),
                new VariableAndSetter("DayNightLengthMultiplier", x => m_DayNightLengthMultiplier = (CustomExperienceModeManager.CustomTunableDayNightMultiplier)x, typeof(CustomExperienceModeManager.CustomTunableDayNightMultiplier)),
                new VariableAndSetter("WeatherChangeFrequency", x => m_WeatherChangeFrequency = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("StrugglePlayerStrengthBonus", x => m_StrugglePlayerStrengthBonus = (CustomExperienceModeManager.CustomTunableNLMH)x, typeof(CustomExperienceModeManager.CustomTunableNLMH)),
                new VariableAndSetter("GradualTempReductionRate", x => m_GradualTempReductionRate = (CustomExperienceModeManager.CustomTunableNLMH)x, typeof(CustomExperienceModeManager.CustomTunableNLMH)),
                new VariableAndSetter("AuroraFrequency", x => m_AuroraFrequency = (CustomExperienceModeManager.CustomTunableNLMH)x, typeof(CustomExperienceModeManager.CustomTunableNLMH)),
                new VariableAndSetter("CalorieBurnRate", x => m_CalorieBurnRate = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("ThirstIncrease", x => m_ThirstIncrease = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("FatigueIncrease", x => m_FatigueIncrease = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("FreezingIncrease", x => m_FreezingIncrease = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("HoursWarmthToCureHypothermia", x => m_HoursWarmthToCureHypothermia = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("ItemDecayRate", x => m_ItemDecayRate = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("ItemSpawnChance", x => m_ItemSpawnChance = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("ReduceWildlifePopOverTime", x => m_ReduceWildlifePopOverTime = (CustomExperienceModeManager.CustomTunableNLMH)x, typeof(CustomExperienceModeManager.CustomTunableNLMH)),
                new VariableAndSetter("EmptyContainerChance", x => m_EmptyContainerChance = (CustomExperienceModeManager.CustomTunableNLMH)x, typeof(CustomExperienceModeManager.CustomTunableNLMH)),
                new VariableAndSetter("StickBranchStoneSpawnFrequency", x => m_StickBranchStoneSpawnFrequency = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("StartingGear", x => m_StartingGear = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("StruggleDamageReceivedBonus", x => m_StruggleDamageReceivedBonus = (CustomExperienceModeManager.CustomTunableNLMH)x, typeof(CustomExperienceModeManager.CustomTunableNLMH)),
                new VariableAndSetter("ScentIncreaseFromMeatBlood", x => m_ScentIncreaseFromMeatBlood = (CustomExperienceModeManager.CustomTunableNLMH)x, typeof(CustomExperienceModeManager.CustomTunableNLMH)),
                new VariableAndSetter("WolfFleeChance", x => m_WolfFleeChance = (CustomExperienceModeManager.CustomTunableNLMH)x, typeof(CustomExperienceModeManager.CustomTunableNLMH)),
                new VariableAndSetter("StruggleDamageEventSeverity", x => m_StruggleDamageEventSeverity = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("WildlifeSmellRange", x => m_WildlifeSmellRange = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("WildlifeSpawnFrequency", x => m_WildlifeSpawnFrequency = (CustomExperienceModeManager.CustomTunableLMHV)x, typeof(CustomExperienceModeManager.CustomTunableLMHV)),
                new VariableAndSetter("WildlifeNotAttackUnprovoked", x => m_WildlifeNotAttackUnprovoked = (bool)x, typeof(bool)),
                new VariableAndSetter("NoPredatorsFirstDay", x => m_NoPredatorsFirstDay = (bool)x, typeof(bool)),
                new VariableAndSetter("CabinFeverEnabled", x => m_CabinFeverEnabled = (bool)x, typeof(bool)),
                new VariableAndSetter("ParasitesEnabled", x => m_ParasitesEnabled = (bool)x, typeof(bool)),
                new VariableAndSetter("ConditionRecoveryRest", x => m_ConditionRecoveryRest = (CustomExperienceModeManager.CustomTunableNLMHV)x, typeof(CustomExperienceModeManager.CustomTunableNLMHV)),
                new VariableAndSetter("ConditionRecoveryAwake", x => m_ConditionRecoveryAwake = (CustomExperienceModeManager.CustomTunableNLMHV)x, typeof(CustomExperienceModeManager.CustomTunableNLMHV)),
                new VariableAndSetter("FrosbiteRisk", x => m_FrosbiteRisk = (CustomExperienceModeManager.CustomTunableNLMHV)x, typeof(CustomExperienceModeManager.CustomTunableNLMHV)),
                new VariableAndSetter("RabbitSpawnChance", x => m_RabbitSpawnChance = (CustomExperienceModeManager.CustomTunableNLMHV)x, typeof(CustomExperienceModeManager.CustomTunableNLMHV)),
                new VariableAndSetter("BearSpawnChance", x => m_BearSpawnChance = (CustomExperienceModeManager.CustomTunableNLMHV)x, typeof(CustomExperienceModeManager.CustomTunableNLMHV)),
                new VariableAndSetter("BlizzardFrequency", x => m_BlizzardFrequency = (CustomExperienceModeManager.CustomTunableNLMHV)x, typeof(CustomExperienceModeManager.CustomTunableNLMHV)),
                new VariableAndSetter("DeerSpawnChance", x => m_DeerSpawnChance = (CustomExperienceModeManager.CustomTunableNLMHV)x, typeof(CustomExperienceModeManager.CustomTunableNLMHV)),
                new VariableAndSetter("FishSpawnChance", x => m_FishSpawnChance = (CustomExperienceModeManager.CustomTunableNLMHV)x, typeof(CustomExperienceModeManager.CustomTunableNLMHV)),
                new VariableAndSetter("WolfSpawnChance", x => m_WolfSpawnChance = (CustomExperienceModeManager.CustomTunableNLMHV)x, typeof(CustomExperienceModeManager.CustomTunableNLMHV)),
                new VariableAndSetter("StartTimeOfDay", x => m_StartTimeOfDay = (CustomExperienceModeManager.CustomTunableTimeOfDay)x, typeof(CustomExperienceModeManager.CustomTunableTimeOfDay)),
                new VariableAndSetter("WildlifeInterruptRest", x => m_WildlifeInterruptRest = (bool)x, typeof(bool)),
                new VariableAndSetter("WindVariability", x => m_WindVariability = (CustomExperienceModeManager.CustomTunableLMH)x, typeof(CustomExperienceModeManager.CustomTunableLMH)),
                new VariableAndSetter("PlantSpawnFrequency", x => m_PlantSpawnFrequency = (CustomExperienceModeManager.CustomTunableLMH)x, typeof(CustomExperienceModeManager.CustomTunableLMH)),
                new VariableAndSetter("ReduceMaxItemsContainers", x => m_ReduceMaxItemsContainers = (CustomExperienceModeManager.CustomTunableNLH)x, typeof(CustomExperienceModeManager.CustomTunableNLH)),
                new VariableAndSetter("StartWeather", x => m_StartWeather = (CustomExperienceModeManager.CustomTunableWeather)x, typeof(CustomExperienceModeManager.CustomTunableWeather)),
                new VariableAndSetter("WolfSpawnDistance", x => m_WolfSpawnDistance = (CustomExperienceModeManager.CustomTunableDistance)x, typeof(CustomExperienceModeManager.CustomTunableDistance)),
                new VariableAndSetter("WildlifeDetectionRange", x => m_WildlifeDetectionRange = (CustomExperienceModeManager.CustomTunableDistance)x, typeof(CustomExperienceModeManager.CustomTunableDistance)),
                new VariableAndSetter("MooseSpawnChance", x => m_MooseSpawnChance = (CustomExperienceModeManager.CustomTunableNLMHV)x, typeof(CustomExperienceModeManager.CustomTunableNLMHV)),
            };

            SettingsUtil.LoadFromFile(FILE, varList);
        }
    }
}