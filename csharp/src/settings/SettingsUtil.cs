using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using static CustomExperienceModeManager;

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
                       Debug.LogFormat("*** MEANINGLESS LINES FOUND IN FILE : {0}", leftoverString);
            }
                 Debug.LogFormat("Finished loading {0} file !", filename);
        }

        private static Dictionary<string, string> loadFileToDict(string filename) {
            return File.ReadAllLines(filename)
                .Where(l => !l.StartsWith("#"))
                .Select(l => l.Split(new[] { '=' }))
                .Where(arr => arr.Length == 2)
                .ToDictionary(s => s[0].Trim(), s => s[1].Trim());
        }

        public static void SetGlobal(Dictionary<string, string> dict, string key, Action<object> globalSetter, Type type) {
            if (!dict.TryGetValue(key, out string value)) {
                   Debug.LogFormat("*No entry for '{0}' found. Defaulting value. Maybe you did an unintended typo in the .txt file ?", key);
                return;
            }

            try {
                object val = null;
                if (type == typeof(CustomTunableDayNightMultiplier)) {
                    val = ParseToEnum<CustomTunableDayNightMultiplier>(value);
                }
                if (type == typeof(CustomTunableDistance)) {
                    val = ParseToEnum<CustomTunableDistance>(value);
                }
                if (type == typeof(CustomTunableLMH)) {
                    val = ParseToEnum<CustomTunableLMH>(value);
                }
                if (type == typeof(CustomTunableLMHV)) {
                    val = ParseToEnum<CustomTunableLMHV>(value);
                }
                if (type == typeof(CustomTunableNLH)) {
                    val = ParseToEnum<CustomTunableNLH>(value);
                }
                if (type == typeof(CustomTunableNLMH)) {
                    val = ParseToEnum<CustomTunableNLMH>(value);
                }
                if (type == typeof(CustomTunableNLMHV)) {
                    val = ParseToEnum<CustomTunableNLMHV>(value);
                }
                if (type == typeof(CustomTunableTimeOfDay)) {
                    val = ParseToEnum<CustomTunableTimeOfDay>(value);
                }
                if (type == typeof(CustomTunableWeather)) {
                    val = ParseToEnum<CustomTunableWeather>(value);
                }
                if (type == typeof(bool)) {
                    val = ParseTo<bool>(value);
                }
                if (type == typeof(int)) {
                    val = ParseTo<int>(value);
                }

                if (val != null) {
                          Debug.LogFormat("* Setting {0} to {1}", key, val.ToString());
                    dict.Remove(key);
                    globalSetter(val);
                }
            } catch (Exception e) {
                  Debug.LogFormat("*** BAD VALUE for '{0}' ('{1}'). Defaulting value. Full error below.", key, value);
                  Debug.LogFormat(e.Message);
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
        public Type type { get; }

        public VariableAndSetter(string variableNameInFile, Action<object> setter, Type type) {
            this.variableNameInFile = variableNameInFile;
            this.setter = setter;
            this.type = type;
        }
    }

}