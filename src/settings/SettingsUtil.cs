using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
			variablesToLoad.ForEach(
				v => {
					// nb : there might be a better way here. I ain't no C# expert...
					if (v.setterFloat != null) {
						SetGlobal<float>(dic, v.variableNameInFile, v.setterFloat);
					} else if (v.setterBool != null) {
						SetGlobal<bool>(dic, v.variableNameInFile, v.setterBool);
					}
				}
			);
			
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
		
		public static void SetGlobal<T>(Dictionary<string, string> dict, string key, Action<T> globalSetter) {
			string value;
			if (!dict.TryGetValue(key, out value)) {
				Debug.LogFormat("*No entry for '{0}' found. Defaulting value. Maybe you did an unintended typo in the .txt file ?", key);
				return;
			}
			
			try {
				T val = typeof(T).IsEnum? ParseToEnum<T>(value): ParseTo<T>(value); 
				
				Debug.LogFormat("* Setting {0} to {1}", key, val);
				dict.Remove(key);
				globalSetter(val);
			
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
		public Action<float> setterFloat { get; set; }
		public Action<bool> setterBool { get; set; }
		
		public VariableAndSetter(string variableNameInFile, Action<float> setterFloat, Action<bool> setterBool) {
			this.variableNameInFile = variableNameInFile;
			this.setterFloat = setterFloat;
			this.setterBool = setterBool;
		}
	}

}