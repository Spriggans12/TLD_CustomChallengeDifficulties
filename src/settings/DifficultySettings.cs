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
        // Variables from ExperienceMode
        /////////
        [Header("TOD and Weather"), Range(0f, 10f)]
        public static float m_DayNightDurationScale;
        [Range(0f, 10f)]
        public static float m_WeatherDurationScale;
        [Range(0f, 10f)]
        public static float m_ChanceOfBlizzardScale;
        [Header("Player"), Range(0f, 10f)]
        public static float m_CalorieBurnScale;
        [Range(0f, 10f)]
        public static float m_ThirstRateScale;
        [Range(0f, 10f)]
        public static float m_FreezingRateScale;
        [Range(0f, 10f)]
        public static float m_FatigueRateScale;
        [Range(0f, 10f)]
        public static float m_ConditonRecoveryFromRestScale;
        [Range(0f, 10f)]
        public static float m_ConditonRecoveryWhileAwakeScale;
        [Header("Loot/Gear"), Range(0f, 10f)]
        public static float m_DecayScale;
        [Range(0f, 1f)]
        public static float m_GearSpawnChanceScale;
        [Range(0f, 10f)]
        public static int m_ReduceMaxItemsInContainer;
        [Range(0f, 100f), Tooltip("Only used when ReduceMaxItemsInContainer results in empty container")]
        public static int m_ChanceForEmptyContainer;
        [Header("AI"), Range(0f, 10f)]
        public static float m_SpawnRegionChanceActiveScale;
        [Range(0f, 10f)]
        public static float m_ClosestSpawnDistanceAfterTransitionScale;
        [Range(0f, 10f)]
        public static float m_SmellRangeScale;
        [Header("Struggle"), Range(0f, 10f)]
        public static float m_StruggleTapStrengthScale;
        [Range(0f, 10f)]
        public static float m_StrugglePlayerDamageReceivedIntervalScale;
        [Range(0f, 10f)]
        public static float m_StrugglePlayerDamageReceivedScale;
        [Range(0f, 10f)]
        public static float m_StrugglePlayerClothingDamageScale;
        [Range(0f, 10f)]
        public static float m_StugglePlayerPercentLossFromBearScale;
        [Header("Outdoor Temp Decrease")]
        public static float m_OutdoorTempDropCelsiusMax;
        public static int m_OutdoorTempDropDayStart;
        public static int m_OutdoorTempDropDayFinal;
        [Header("AI Respawn Decrease")]
        public static float m_RespawnHoursScaleMax;
        public static int m_RespawnHoursScaleDayStart;
        public static int m_RespawnHoursScaleDayFinal;
        [Header("Fishing Catch Decrease")]
        public static float m_FishCatchTimeScaleMax;
        public static int m_FishCatchTimeScaleDayStart;
        public static int m_FishCatchTimeScaleDayFinal;
        [Header("Radial Spawn Decrease")]
        public static float m_RadialRespawnTimeScaleMax;
        public static int m_RadialRespawnTimeScaleDayStart;
        public static int m_RadialRespawnTimeScaleDayFinal;
        [Header("First Aid"), Range(0f, 10f)]
        public static float m_NumHoursWarmForHypothermiaCureScale = 1f;
        /////////
        /////////
        /////////

        public static void Load() {
            List<VariableAndSetter> varList = new List<VariableAndSetter> {
                new VariableAndSetter("DayNightDurationScale", x => m_DayNightDurationScale = x, null, null),
                new VariableAndSetter("WeatherDurationScale", x => m_WeatherDurationScale = x, null, null),
                new VariableAndSetter("ChanceOfBlizzardScale", x => m_ChanceOfBlizzardScale = x, null, null),
                new VariableAndSetter("CalorieBurnScale", x => m_CalorieBurnScale = x, null, null),
                new VariableAndSetter("ThirstRateScale", x => m_ThirstRateScale = x, null, null),
                new VariableAndSetter("FreezingRateScale", x => m_FreezingRateScale = x, null, null),
                new VariableAndSetter("FatigueRateScale", x => m_FatigueRateScale = x, null, null),
                new VariableAndSetter("ConditonRecoveryFromRestScale", x => m_ConditonRecoveryFromRestScale = x, null, null),
                new VariableAndSetter("ConditonRecoveryWhileAwakeScale", x => m_ConditonRecoveryWhileAwakeScale = x, null, null),
                new VariableAndSetter("DecayScale", x => m_DecayScale = x, null, null),
                new VariableAndSetter("GearSpawnChanceScale", x => m_GearSpawnChanceScale = x, null, null),
                new VariableAndSetter("ReduceMaxItemsInContainer", null, null, x => m_ReduceMaxItemsInContainer = x),
                new VariableAndSetter("ChanceForEmptyContainer", null, null, x => m_ChanceForEmptyContainer = x),
                new VariableAndSetter("SpawnRegionChanceActiveScale", x => m_SpawnRegionChanceActiveScale = x, null, null),
                new VariableAndSetter("ClosestSpawnDistanceAfterTransitionScale", x => m_ClosestSpawnDistanceAfterTransitionScale = x, null, null),
                new VariableAndSetter("SmellRangeScale", x => m_SmellRangeScale = x, null, null),
                new VariableAndSetter("StruggleTapStrengthScale", x => m_StruggleTapStrengthScale = x, null, null),
                new VariableAndSetter("StrugglePlayerDamageReceivedIntervalScale", x => m_StrugglePlayerDamageReceivedIntervalScale = x, null, null),
                new VariableAndSetter("StrugglePlayerDamageReceivedScale", x => m_StrugglePlayerDamageReceivedScale = x, null, null),
                new VariableAndSetter("StrugglePlayerClothingDamageScale", x => m_StrugglePlayerClothingDamageScale = x, null, null),
                new VariableAndSetter("StugglePlayerPercentLossFromBearScale", x => m_StugglePlayerPercentLossFromBearScale = x, null, null),
                new VariableAndSetter("OutdoorTempDropCelsiusMax", x => m_OutdoorTempDropCelsiusMax = x, null, null),
                new VariableAndSetter("OutdoorTempDropDayStart", null, null, x => m_OutdoorTempDropDayStart = x),
                new VariableAndSetter("OutdoorTempDropDayFinal", null, null,  x => m_OutdoorTempDropDayFinal = x),
                new VariableAndSetter("RespawnHoursScaleMax", null, null, x => m_RespawnHoursScaleMax = x),
                new VariableAndSetter("RespawnHoursScaleDayStart", null, null, x => m_RespawnHoursScaleDayStart = x),
                new VariableAndSetter("RespawnHoursScaleDayFinal", null, null, x => m_RespawnHoursScaleDayFinal = x),
                new VariableAndSetter("FishCatchTimeScaleMax", x => m_FishCatchTimeScaleMax = x, null, null),
                new VariableAndSetter("FishCatchTimeScaleDayStart", null, null, x => m_FishCatchTimeScaleDayStart = x),
                new VariableAndSetter("FishCatchTimeScaleDayFinal", null, null, x => m_FishCatchTimeScaleDayFinal = x),
                new VariableAndSetter("RadialRespawnTimeScaleMax", x => m_RadialRespawnTimeScaleMax = x, null, null),
                new VariableAndSetter("RadialRespawnTimeScaleDayStart", null, null, x => m_RadialRespawnTimeScaleDayStart = x),
                new VariableAndSetter("RadialRespawnTimeScaleDayFinal", null, null, x => m_RadialRespawnTimeScaleDayFinal = x),
                new VariableAndSetter("NumHoursWarmForHypothermiaCureScale", x => m_NumHoursWarmForHypothermiaCureScale = x, null, null),
            };

            SettingsUtil.LoadFromFile(FILE, varList);
        }
    }
}