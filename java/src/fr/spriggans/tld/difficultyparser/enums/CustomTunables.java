package fr.spriggans.tld.difficultyparser.enums;

/**
 * Enums extracted from TLD's C# code.
 */
public class CustomTunables {

	public enum LMH {
		Low, Medium, High;

		public static LMH[] VALS = values();
	}

	public enum NLH {
		None, Low, High;

		public static NLH[] VALS = values();
	}

	public enum LMHV {
		Low, Medium, High, VeryHigh;

		public static LMHV[] VALS = values();
	}

	public enum NLMH {
		None, Low, Medium, High;

		public static NLMH[] VALS = values();
	}

	public enum NLMHV {
		None, Low, Medium, High, VeryHigh;

		public static NLMHV[] VALS = values();
	}

	public enum DayNightMultiplier {
		OneX, TwoX, ThreeX, FourX;

		public static DayNightMultiplier[] VALS = values();
	}

	public enum TimeOfDay {
		Dawn, Noon, Dusk, Midnight, Random;

		public static TimeOfDay[] VALS = values();
	}

	public enum Distance {
		Close, Medium, Far;

		public static Distance[] VALS = values();
	}

	public enum Weather {
		Clear, LightSnow, HeavySnow, Blizzard, LightFog, DenseFog, Random;

		public static Weather[] VALS = values();
	}

	public enum Bool {
		True("true"), False("false");

		private String name;

		Bool(String n) {
			this.name = n;
		}

		public static Bool get(boolean b) {
			return b ? True : False;
		}

		@Override
		public String toString() {
			return this.name;
		}
	}
}
