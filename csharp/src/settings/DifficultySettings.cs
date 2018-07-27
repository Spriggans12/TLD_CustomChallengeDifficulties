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
namespace CustomChallengeDifficulties
{

    public static class DifficultySettings
    {

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

        public static void Load()
        {
            List<VariableAndSetter> varList = new List<VariableAndSetter> {
                new VariableAndSetter("BaseWorldDifficulty", x => m_BaseWorldDifficulty = (CustomTunableLMHV) x),
            };



            SettingsUtil.LoadFromFile(FILE, varList);
        }
    }
}