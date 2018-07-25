namespace CustomChallengeDifficulties {

	public static class ChallengeHunted2Settings {

		public static string FILE = "mods/customChallengesSettings/challenge_hunted2_settings.txt";
		
		public static float Variable1 = 0.1f;
		
		public static void Load() {
			List<VariableAndSetter> varList = new List<VariableAndSetter> {
				new VariableAndSetter("var1", x => Variable1 = x, null),
            };
			
			SettingsUtil.LoadFromFile(FILE, varList);
		}
	}
}