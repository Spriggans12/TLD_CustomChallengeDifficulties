using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Harmony;
using UnityEngine;

/*
 * This util class handles the loading of settings files.
 */
namespace CustomChallengeDifficulties {

    public static class SettingsUtil {

        public static void LoadFromFile(string filename, List<VariableAndSetter> variablesToLoad) {
            // Loads file
            Dictionary<string, string> dic = loadFileToDict(filename);

            // Sets global variables
            variablesToLoad.ForEach(v => {
                SetGlobal(dic, v.variableNameInFile, v.setter, v.type);
            });

            // Logs
            var leftoverEntries = dic.Select(kvp => kvp.Key + "=" + kvp.Value).ToArray();
            if (leftoverEntries.Any()) {
                var leftoverString = string.Join(", ", leftoverEntries);
                FileLog.Log("*** MEANINGLESS LINES FOUND IN FILE : " + leftoverString);
            }
            FileLog.Log("Finished loading " + filename + " file !");
        }

        private static Dictionary<string, string> loadFileToDict(string filename) {
            return File.ReadAllLines(filename)
                .Where(l => !l.StartsWith("#"))
                .Select(l => l.Split(new[] { '=' }))
                .Where(arr => arr.Length == 2)
                .ToDictionary(s => s[0].Trim(), s => s[1].Trim());
        }

        public static void SetGlobal(Dictionary<string, string> dict, string key, Action<object> globalSetter, Type type) {
            string value;
            if (!dict.TryGetValue(key, out value)) {
                FileLog.Log("*No entry for '" + key + "' found. Defaulting value. Maybe you did an unintended typo in the .txt file ?");
                return;
            }

            try {
                object val = null;
                if (type == typeof(CustomExperienceModeManager.CustomTunableDayNightMultiplier)) {
                    val = ParseToEnum<CustomExperienceModeManager.CustomTunableDayNightMultiplier>(value);
                }
                if (type == typeof(CustomExperienceModeManager.CustomTunableDistance)) {
                    val = ParseToEnum<CustomExperienceModeManager.CustomTunableDistance>(value);
                }
                if (type == typeof(CustomExperienceModeManager.CustomTunableLMH)) {
                    val = ParseToEnum<CustomExperienceModeManager.CustomTunableLMH>(value);
                }
                if (type == typeof(CustomExperienceModeManager.CustomTunableLMHV)) {
                    val = ParseToEnum<CustomExperienceModeManager.CustomTunableLMHV>(value);
                }
                if (type == typeof(CustomExperienceModeManager.CustomTunableNLH)) {
                    val = ParseToEnum<CustomExperienceModeManager.CustomTunableNLH>(value);
                }
                if (type == typeof(CustomExperienceModeManager.CustomTunableNLMH)) {
                    val = ParseToEnum<CustomExperienceModeManager.CustomTunableNLMH>(value);
                }
                if (type == typeof(CustomExperienceModeManager.CustomTunableNLMHV)) {
                    val = ParseToEnum<CustomExperienceModeManager.CustomTunableNLMHV>(value);
                }
                if (type == typeof(CustomExperienceModeManager.CustomTunableTimeOfDay)) {
                    val = ParseToEnum<CustomExperienceModeManager.CustomTunableTimeOfDay>(value);
                }
                if (type == typeof(CustomExperienceModeManager.CustomTunableWeather)) {
                    val = ParseToEnum<CustomExperienceModeManager.CustomTunableWeather>(value);
                }
                if (type == typeof(bool)) {
                    val = ParseTo<bool>(value);
                }
                if (type == typeof(int)) {
                    val = ParseTo<int>(value);
                }

                if (val != null) {
                    FileLog.Log("* Setting "+key+" to " + val.ToString());
                    dict.Remove(key);
                    globalSetter(val);
                }
            } catch (Exception e) {
                FileLog.Log("*** BAD VALUE for '"+key+"' ('"+value+"'). Defaulting value. Full error below.");
                FileLog.Log(e.Message);
            }
        }

        public static T ParseTo<T>(object obj) {
            return (T)Convert.ChangeType(obj, typeof(T));
        }

        public static T ParseToEnum<T>(string input) {
            return (T)Enum.Parse(typeof(T), input);
        }
    }

    public class VariableAndSetter {
        public string variableNameInFile { get; set; }
        public Action<object> setter { get; set; }
        public Type type { get; set; }

        public VariableAndSetter(string variableNameInFile, Action<object> setter, Type type) {
            this.variableNameInFile = variableNameInFile;
            this.setter = setter;
            this.type = type;
        }
    }

}