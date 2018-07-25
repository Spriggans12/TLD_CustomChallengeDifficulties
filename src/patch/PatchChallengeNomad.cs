
using System;
using UnityEngine;

namespace CustomChallengeDifficulties {
	
	class PatchChallengeNomad {
		static bool Prepare() {
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