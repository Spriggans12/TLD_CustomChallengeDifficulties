using System;
using System.Collections.Generic;
using UnityEngine;
using static CustomExperienceModeManager;

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
        public static CustomTunableLMHV m_BaseWorldDifficulty;
        public static CustomTunableNLMH m_StruggleClothingDamageBonus;
        public static CustomTunableDayNightMultiplier m_DayNightLengthMultiplier;
        public static CustomTunableLMHV m_WeatherChangeFrequency;
        public static CustomTunableNLMH m_StrugglePlayerStrengthBonus;
        public static CustomTunableNLMH m_GradualTempReductionRate;
        public static CustomTunableNLMH m_AuroraFrequency;
        public static CustomTunableLMHV m_CalorieBurnRate;
        public static CustomTunableLMHV m_ThirstIncrease;
        public static CustomTunableLMHV m_FatigueIncrease;
        public static CustomTunableLMHV m_FreezingIncrease;
        public static CustomTunableLMHV m_HoursWarmthToCureHypothermia;
        public static CustomTunableLMHV m_ItemDecayRate;
        public static CustomTunableLMHV m_ItemSpawnChance;
        public static CustomTunableNLMH m_ReduceWildlifePopOverTime;
        public static CustomTunableNLMH m_EmptyContainerChance;
        public static CustomTunableLMHV m_StickBranchStoneSpawnFrequency;
        public static CustomTunableLMHV m_StartingGear;
        public static CustomTunableNLMH m_StruggleDamageReceivedBonus;
        public static CustomTunableNLMH m_ScentIncreaseFromMeatBlood;
        public static CustomTunableNLMH m_WolfFleeChance;
        public static CustomTunableLMHV m_StruggleDamageEventSeverity;
        public static CustomTunableLMHV m_WildlifeSmellRange;
        public static CustomTunableLMHV m_WildlifeSpawnFrequency;
        public static bool m_WildlifeNotAttackUnprovoked;
        public static bool m_NoPredatorsFirstDay;
        public static bool m_CabinFeverEnabled;
        public static bool m_ParasitesEnabled;
        public static CustomTunableNLMHV m_ConditionRecoveryRest;
        public static CustomTunableNLMHV m_ConditionRecoveryAwake;
        public static CustomTunableNLMHV m_FrosbiteRisk;
        public static CustomTunableNLMHV m_RabbitSpawnChance;
        public static CustomTunableNLMHV m_BearSpawnChance;
        public static CustomTunableNLMHV m_BlizzardFrequency;
        public static CustomTunableNLMHV m_DeerSpawnChance;
        public static CustomTunableNLMHV m_FishSpawnChance;
        public static CustomTunableNLMHV m_WolfSpawnChance;
        public static CustomTunableTimeOfDay m_StartTimeOfDay;
        public static bool m_WildlifeInterruptRest;
        public static CustomTunableLMH m_WindVariability;
        public static CustomTunableLMH m_PlantSpawnFrequency;
        public static CustomTunableNLH m_ReduceMaxItemsContainers;
        public static CustomTunableWeather m_StartWeather;
        public static CustomTunableDistance m_WolfSpawnDistance;
        public static CustomTunableDistance m_WildlifeDetectionRange;
        public static CustomTunableNLMHV m_MooseSpawnChance;




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
                new VariableAndSetter("BaseWorldDifficulty", x => m_BaseWorldDifficulty = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("StruggleClothingDamageBonus", x => m_StruggleClothingDamageBonus = (CustomTunableNLMH)x, typeof(CustomTunableNLMH)),
                new VariableAndSetter("DayNightLengthMultiplier", x => m_DayNightLengthMultiplier = (CustomTunableDayNightMultiplier)x, typeof(CustomTunableDayNightMultiplier)),
                new VariableAndSetter("WeatherChangeFrequency", x => m_WeatherChangeFrequency = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("StrugglePlayerStrengthBonus", x => m_StrugglePlayerStrengthBonus = (CustomTunableNLMH)x, typeof(CustomTunableNLMH)),
                new VariableAndSetter("GradualTempReductionRate", x => m_GradualTempReductionRate = (CustomTunableNLMH)x, typeof(CustomTunableNLMH)),
                new VariableAndSetter("AuroraFrequency", x => m_AuroraFrequency = (CustomTunableNLMH)x, typeof(CustomTunableNLMH)),
                new VariableAndSetter("CalorieBurnRate", x => m_CalorieBurnRate = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("ThirstIncrease", x => m_ThirstIncrease = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("FatigueIncrease", x => m_FatigueIncrease = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("FreezingIncrease", x => m_FreezingIncrease = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("HoursWarmthToCureHypothermia", x => m_HoursWarmthToCureHypothermia = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("ItemDecayRate", x => m_ItemDecayRate = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("ItemSpawnChance", x => m_ItemSpawnChance = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("ReduceWildlifePopOverTime", x => m_ReduceWildlifePopOverTime = (CustomTunableNLMH)x, typeof(CustomTunableNLMH)),
                new VariableAndSetter("EmptyContainerChance", x => m_EmptyContainerChance = (CustomTunableNLMH)x, typeof(CustomTunableNLMH)),
                new VariableAndSetter("StickBranchStoneSpawnFrequency", x => m_StickBranchStoneSpawnFrequency = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("StartingGear", x => m_StartingGear = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("StruggleDamageReceivedBonus", x => m_StruggleDamageReceivedBonus = (CustomTunableNLMH)x, typeof(CustomTunableNLMH)),
                new VariableAndSetter("ScentIncreaseFromMeatBlood", x => m_ScentIncreaseFromMeatBlood = (CustomTunableNLMH)x, typeof(CustomTunableNLMH)),
                new VariableAndSetter("WolfFleeChance", x => m_WolfFleeChance = (CustomTunableNLMH)x, typeof(CustomTunableNLMH)),
                new VariableAndSetter("StruggleDamageEventSeverity", x => m_StruggleDamageEventSeverity = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("WildlifeSmellRange", x => m_WildlifeSmellRange = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("WildlifeSpawnFrequency", x => m_WildlifeSpawnFrequency = (CustomTunableLMHV)x, typeof(CustomTunableLMHV)),
                new VariableAndSetter("WildlifeNotAttackUnprovoked", x => m_WildlifeNotAttackUnprovoked = (bool)x, typeof(bool)),
                new VariableAndSetter("NoPredatorsFirstDay", x => m_NoPredatorsFirstDay = (bool)x, typeof(bool)),
                new VariableAndSetter("CabinFeverEnabled", x => m_CabinFeverEnabled = (bool)x, typeof(bool)),
                new VariableAndSetter("ParasitesEnabled", x => m_ParasitesEnabled = (bool)x, typeof(bool)),
                new VariableAndSetter("ConditionRecoveryRest", x => m_ConditionRecoveryRest = (CustomTunableNLMHV)x, typeof(CustomTunableNLMHV)),
                new VariableAndSetter("ConditionRecoveryAwake", x => m_ConditionRecoveryAwake = (CustomTunableNLMHV)x, typeof(CustomTunableNLMHV)),
                new VariableAndSetter("FrosbiteRisk", x => m_FrosbiteRisk = (CustomTunableNLMHV)x, typeof(CustomTunableNLMHV)),
                new VariableAndSetter("RabbitSpawnChance", x => m_RabbitSpawnChance = (CustomTunableNLMHV)x, typeof(CustomTunableNLMHV)),
                new VariableAndSetter("BearSpawnChance", x => m_BearSpawnChance = (CustomTunableNLMHV)x, typeof(CustomTunableNLMHV)),
                new VariableAndSetter("BlizzardFrequency", x => m_BlizzardFrequency = (CustomTunableNLMHV)x, typeof(CustomTunableNLMHV)),
                new VariableAndSetter("DeerSpawnChance", x => m_DeerSpawnChance = (CustomTunableNLMHV)x, typeof(CustomTunableNLMHV)),
                new VariableAndSetter("FishSpawnChance", x => m_FishSpawnChance = (CustomTunableNLMHV)x, typeof(CustomTunableNLMHV)),
                new VariableAndSetter("WolfSpawnChance", x => m_WolfSpawnChance = (CustomTunableNLMHV)x, typeof(CustomTunableNLMHV)),
                new VariableAndSetter("StartTimeOfDay", x => m_StartTimeOfDay = (CustomTunableTimeOfDay)x, typeof(CustomTunableTimeOfDay)),
                new VariableAndSetter("WildlifeInterruptRest", x => m_WildlifeInterruptRest = (bool)x, typeof(bool)),
                new VariableAndSetter("WindVariability", x => m_WindVariability = (CustomTunableLMH)x, typeof(CustomTunableLMH)),
                new VariableAndSetter("PlantSpawnFrequency", x => m_PlantSpawnFrequency = (CustomTunableLMH)x, typeof(CustomTunableLMH)),
                new VariableAndSetter("ReduceMaxItemsContainers", x => m_ReduceMaxItemsContainers = (CustomTunableNLH)x, typeof(CustomTunableNLH)),
                new VariableAndSetter("StartWeather", x => m_StartWeather = (CustomTunableWeather)x, typeof(CustomTunableWeather)),
                new VariableAndSetter("WolfSpawnDistance", x => m_WolfSpawnDistance = (CustomTunableDistance)x, typeof(CustomTunableDistance)),
                new VariableAndSetter("WildlifeDetectionRange", x => m_WildlifeDetectionRange = (CustomTunableDistance)x, typeof(CustomTunableDistance)),
                new VariableAndSetter("MooseSpawnChance", x => m_MooseSpawnChance = (CustomTunableNLMHV)x, typeof(CustomTunableNLMHV)),
            };

            SettingsUtil.LoadFromFile(FILE, varList);
        }
    }
}