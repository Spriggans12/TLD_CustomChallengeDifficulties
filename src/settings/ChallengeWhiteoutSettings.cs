using System;
using System.Collections.Generic;

namespace CustomChallengeDifficulties {

	public static class ChallengeWhiteoutSettings {

		public static string FILE = "mods/customChallengesSettings/challenge_whiteout_settings.txt";
		
		public static float Variable1 = 0.1f;
		
		public static void Load() {
			List<VariableAndSetter> varList = new List<VariableAndSetter> {
				new VariableAndSetter("var1", x => Variable1 = x, null, null),
            };
			
			SettingsUtil.LoadFromFile(FILE, varList);
		}
	}
}