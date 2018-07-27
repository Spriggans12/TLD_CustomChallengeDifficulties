package fr.spriggans.tld.difficultyparser.writer;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStreamWriter;
import java.io.UnsupportedEncodingException;
import java.io.Writer;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

import fr.spriggans.tld.difficultyparser.parameter.DifficutlyParameters;
import fr.spriggans.tld.difficultyparser.parameter.Field;

/**
 * Writes difficulty settings into the requested File.
 */
public class FileWritter {

	private static final String CR_LF = "\r\n";

	private static final String HEADER = "#####\r\n"
			+ "# This is a settings file that contains all the variables from the \"Custom difficulty\" screen in TLD.\r\n"
			+ "# Each parameter can here be set. These parameters will define the difficulty of all the challenges you play.\r\n"
			+ "# That way, you can finally simulate a custom difficulty on challenges.\r\n" + "#\r\n"
			+ "# Some parameters are not smart to use in challenges, like the choice of the starting location or the no-rifle spawn.\r\n"
			+ "# => These parameters are not used by the Patch if the Challenge loaded needs specific settings.\r\n"
			+ "# For example, it is possible to start Nomad in any location you want. But in other challenges, you can't.\r\n"
			+ "# Another example, in white-out, you can't turn off Rifle-spawn, as you need it to finish the challenge.\r\n"
			+ "# \r\n"
			+ "# In this file, you will find a list, as seen in game, of all the parameters one could set.\r\n"
			+ "# For each parameter, you must use of the possible commented values.\r\n" + "# /!\\ !!Beware!! \r\n"
			+ "#     -> Parameters are case sensitive ! So \"High\" and \"high\" are not the same thing. Using wrong case makes the Patch not work.\r\n"
			+ "#     -> All parameters must be set. Even specific parameters like starting location.\r\n" + "# \r\n"
			+ "# Lines that start with a # are ignored.\r\n" + "#####\r\n";

	private static final String GAME_START = "### GAME START\r\n";

	private static final String ENVIRONEMENT = "### ENVIRONEMENT\r\n";

	private static final String HEALTH = "### HEALTH\r\n";

	private static final String GEAR = "### GEAR\r\n";

	private static final String WILDLIFE_SPAWNS = "### WILDLIFE SPAWNS\r\n";

	private static final String WILDLIFE_BEHAVIOUR = "### WILDLIFE BEHAVIOUR\r\n";

	private static final String WILDLIFE_STRUGGLE = "### WILDLIFE STRUGGLE\r\n";

	private static final String VALUES_CAN_BE = "# Values can be either of ";

	/**
	 * @param diffParams
	 * @return file location
	 */
	public static String generate(String fileName, DifficutlyParameters diffParams)
			throws UnsupportedEncodingException, IOException {

		try (Writer writer = new BufferedWriter(new OutputStreamWriter(new FileOutputStream(fileName), "utf-8"))) {
			writeHeader(writer);
			writeGameStart(writer, diffParams);
			writeEnvironement(writer, diffParams);
			writeHealth(writer, diffParams);
			writeGear(writer, diffParams);
			writeWildlifeSpawns(writer, diffParams);
			writeWildlifeBehaviour(writer, diffParams);
			writeWildlifeStruggle(writer, diffParams);
		}

		return new File(fileName).getAbsolutePath();
	}

	private static void writeHeader(Writer writer) throws IOException {
		writer.write(HEADER);
		blankLine(writer);
		blankLine(writer);
	}

	private static void writeGameStart(Writer writer, DifficutlyParameters diffParams) throws IOException {
		writer.write(GAME_START);
		blankLine(writer);

		writeField(writer, diffParams.getM_BaseWorldDifficulty());
		writeField(writer, diffParams.getM_StartTimeOfDay());
		writeField(writer, diffParams.getM_StartWeather());
		writeField(writer, diffParams.getM_AllowInteriorStartingSpawn());
		writeField(writer, diffParams.getM_SurvivorVoiceOver());

		blankLine(writer);
		blankLine(writer);
	}

	private static void writeEnvironement(Writer writer, DifficutlyParameters diffParams) throws IOException {
		writer.write(ENVIRONEMENT);
		blankLine(writer);
		
		writeField(writer, diffParams.getM_DayNightLengthMultiplier());
		writeField(writer, diffParams.getM_WeatherChangeFrequency());
		writeField(writer, diffParams.getM_BlizzardFrequency());
		writeField(writer, diffParams.getM_GradualTempReductionRate());
		writeField(writer, diffParams.getM_WindVariability());
		writeField(writer, diffParams.getM_AuroraFrequency());
		writeField(writer, diffParams.getM_UseMinAirTempValue());

		blankLine(writer);
		blankLine(writer);
	}

	private static void writeHealth(Writer writer, DifficutlyParameters diffParams) throws IOException {
		writer.write(HEALTH);
		blankLine(writer);
		
		writeField(writer, diffParams.getM_CalorieBurnRate());
		writeField(writer, diffParams.getM_ThirstIncrease());
		writeField(writer, diffParams.getM_FatigueIncrease());
		writeField(writer, diffParams.getM_FreezingIncrease());
		writeField(writer, diffParams.getM_ConditionRecoveryRest());
		writeField(writer, diffParams.getM_ConditionRecoveryAwake());
		writeField(writer, diffParams.getM_HoursWarmthToCureHypothermia());
		writeField(writer, diffParams.getM_FrosbiteRisk());
		writeField(writer, diffParams.getM_CabinFeverEnabled());
		writeField(writer, diffParams.getM_ParasitesEnabled());
		writeField(writer, diffParams.getM_EnableDysentery());
		writeField(writer, diffParams.getM_EnableSprains());
		writeField(writer, diffParams.getM_EnableFoodPoisoning());
		writeField(writer, diffParams.getM_EnableBrokenRibs());
		writeField(writer, diffParams.getM_LimitedRest());
		writeField(writer, diffParams.getM_AdjustFreezingDueToNearbyFire());
		writeField(writer, diffParams.getM_InterruptIfFreezingWhileSleeping());

		blankLine(writer);
		blankLine(writer);
	}

	private static void writeGear(Writer writer, DifficutlyParameters diffParams) throws IOException {
		writer.write(GEAR);
		blankLine(writer);
		
		writeField(writer, diffParams.getM_ItemDecayRate());
		writeField(writer, diffParams.getM_ItemSpawnChance());
		writeField(writer, diffParams.getM_EmptyContainerChance());
		writeField(writer, diffParams.getM_StickBranchStoneSpawnFrequency());
		writeField(writer, diffParams.getM_StartingGear());
		writeField(writer, diffParams.getM_RiflesInWorld());
		writeField(writer, diffParams.getM_PlantSpawnFrequency());
		writeField(writer, diffParams.getM_ReduceMaxItemsContainers());


		blankLine(writer);
		blankLine(writer);
	}

	private static void writeWildlifeSpawns(Writer writer, DifficutlyParameters diffParams) throws IOException {
		writer.write(WILDLIFE_SPAWNS);
		blankLine(writer);
		
		writeField(writer, diffParams.getM_FishSpawnChance());
		writeField(writer, diffParams.getM_WolfSpawnChance());
		writeField(writer, diffParams.getM_DeerSpawnChance());
		writeField(writer, diffParams.getM_RabbitSpawnChance());
		writeField(writer, diffParams.getM_BearSpawnChance());
		writeField(writer, diffParams.getM_MooseSpawnChance());
		writeField(writer, diffParams.getM_WildlifeSpawnFrequency());
		writeField(writer, diffParams.getM_ReduceWildlifePopOverTime());
		writeField(writer, diffParams.getM_WolfSpawnDistance());
		writeField(writer, diffParams.getM_NoPredatorsFirstDay());

		blankLine(writer);
		blankLine(writer);
	}

	private static void writeWildlifeBehaviour(Writer writer, DifficutlyParameters diffParams) throws IOException {
		writer.write(WILDLIFE_BEHAVIOUR);
		blankLine(writer);
		
		writeField(writer, diffParams.getM_WildlifeSmellRange());
		writeField(writer, diffParams.getM_ScentIncreaseFromMeatBlood());
		writeField(writer, diffParams.getM_WildlifeNotAttackUnprovoked());
		writeField(writer, diffParams.getM_WildlifeInterruptRest());
		writeField(writer, diffParams.getM_WolfFleeChance());
		writeField(writer, diffParams.getM_WildlifeDetectionRange());

		blankLine(writer);
		blankLine(writer);
	}

	private static void writeWildlifeStruggle(Writer writer, DifficutlyParameters diffParams) throws IOException {
		writer.write(WILDLIFE_STRUGGLE);
		blankLine(writer);
		
		writeField(writer, diffParams.getM_StrugglePlayerStrengthBonus());
		writeField(writer, diffParams.getM_StruggleDamageReceivedBonus());
		writeField(writer, diffParams.getM_StruggleClothingDamageBonus());
		writeField(writer, diffParams.getM_StruggleDamageEventSeverity());

		blankLine(writer);
		blankLine(writer);
	}

	private static void writeField(Writer writer, Field<? extends Enum<?>> field) throws IOException {
		writer.write("# " + field.getDescription());
		writer.write(CR_LF);
		writer.write(VALUES_CAN_BE);
		if(field.getEnumValue() != null) {
			Class<?> enumClazz = field.getEnumValue().getClass();
			List<Object> enumValuesList = Arrays.asList(enumClazz.getEnumConstants());
			String commaSeparatedValues = enumValuesList.stream().map(e -> e.toString()).collect(Collectors.joining(", "));
			writer.write(commaSeparatedValues);
		}
		writer.write(CR_LF);
		writer.write(field.getVariableName());
		writer.write(" = ");
		writer.write(field.getEnumValue() == null ? "null" : field.getEnumValue().toString());
		writer.write(CR_LF);
		writer.write(CR_LF);
	}

	private static void blankLine(Writer writer) throws IOException {
		writer.write(CR_LF);
	}
}
