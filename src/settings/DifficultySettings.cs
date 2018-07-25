
/*
 * This class contains all the variables you can set in a vanilla sandbox game with a Custom difficulty.
 * The values loaded are read from the file mods/customChallengesSettings/difficulty_settings.txt
 * This file can be edited prior to launching the game.
 * You can use the JAVA program to generate a difficulty_settings file from a String dump of an in-game Custom difficulty (cf documentation for how to use it)
 */
namespace CustomChallengeDifficulties {

	public static class DifficultySettings {
		
		public static string FILE = "mods/customChallengesSettings/difficulty_settings.txt";
		
		public static float Variable1 = 0.1f;
		public static float Variable2 = 0.1f;
		public static bool Variable3 = true;
		// ...
		
		public static void Load() {
			List<VariableAndSetter> varList = new List<VariableAndSetter> {
				new VariableAndSetter("var1", x => Variable1 = x, null),
				new VariableAndSetter("var2", x => Variable2 = x, null),
				new VariableAndSetter("var3", null, x => Variable3 = x),
            };
			
			SettingsUtil.LoadFromFile(FILE, varList);
		}
	}
}