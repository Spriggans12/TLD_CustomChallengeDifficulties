

namespace CustomChallengeDifficulties {
	
	class PatchChallengeNomad {
		static bool Prepare() {
			Debug.LogFormat.Log("");
			Debug.LogFormat.Log(DateTime.Now + " ---- Loading Nomad Mod.");
			try {
				DifficultySettings.Load();
				ChallengeNomadSettings.Load();
			} catch (Exception e) {
				Debug.LogFormat(e.Message);
				throw;
			}
			
			return true;
		}
		
		// TODO
	}
	
}