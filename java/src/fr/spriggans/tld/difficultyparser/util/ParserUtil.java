package fr.spriggans.tld.difficultyparser.util;

import java.util.ArrayList;
import java.util.Base64;
import java.util.List;

import fr.spriggans.tld.difficultyparser.bitarray.CSharpBitArray;
import fr.spriggans.tld.difficultyparser.enums.CustomTunables;
import fr.spriggans.tld.difficultyparser.parameter.DifficutlyParameters;

/**
 * Nice and ugly code. Copied / pasted / adapted from
 * "CreateCustomModeFromString" @ "CustomExperienceModeManager" from TLD's C#.
 */
public class ParserUtil {

	public static void setValuesFromString(DifficutlyParameters diff, String difficultyString) {
		byte[] bytes = Base64.getDecoder().decode(difficultyString);
		CSharpBitArray bitArray = new CSharpBitArray(bytes);

		diff.getM_AllowInteriorStartingSpawn().setEnumValue(CustomTunables.Bool.get(bitArray.get(0)));
		diff.getM_SurvivorVoiceOver().setEnumValue(CustomTunables.Bool.get(bitArray.get(1)));
		// diff.getM_WeakIce().setEnumValue(CustomTunables.Bool.get(bitArray.get(2)); //
		// Unused
		diff.getM_UseMinAirTempValue().setEnumValue(CustomTunables.Bool.get(bitArray.get(3)));
		diff.getM_EnableDysentery().setEnumValue(CustomTunables.Bool.get(bitArray.get(4)));
		diff.getM_EnableSprains().setEnumValue(CustomTunables.Bool.get(bitArray.get(5)));
		diff.getM_EnableFoodPoisoning().setEnumValue(CustomTunables.Bool.get(bitArray.get(6)));
		diff.getM_EnableBrokenRibs().setEnumValue(CustomTunables.Bool.get(bitArray.get(7)));
		diff.getM_LimitedRest().setEnumValue(CustomTunables.Bool.get(bitArray.get(8)));
		diff.getM_AdjustFreezingDueToNearbyFire().setEnumValue(CustomTunables.Bool.get(bitArray.get(9)));
		diff.getM_InterruptIfFreezingWhileSleeping().setEnumValue(CustomTunables.Bool.get(bitArray.get(10)));
		diff.getM_RiflesInWorld().setEnumValue(CustomTunables.Bool.get(bitArray.get(11)));
		diff.getM_BaseWorldDifficulty().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 12, 2)]);
		diff.getM_StruggleClothingDamageBonus().setEnumValue(CustomTunables.NLMH.VALS[bitsToDecimal(bitArray, 14, 2)]);
		diff.getM_DayNightLengthMultiplier()
				.setEnumValue(CustomTunables.DayNightMultiplier.VALS[bitsToDecimal(bitArray, 16, 2)]);
		diff.getM_WeatherChangeFrequency().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 18, 2)]);
		diff.getM_StrugglePlayerStrengthBonus().setEnumValue(CustomTunables.NLMH.VALS[bitsToDecimal(bitArray, 20, 2)]);
		diff.getM_GradualTempReductionRate().setEnumValue(CustomTunables.NLMH.VALS[bitsToDecimal(bitArray, 22, 2)]);
		diff.getM_AuroraFrequency().setEnumValue(CustomTunables.NLMH.VALS[bitsToDecimal(bitArray, 24, 2)]);
		diff.getM_CalorieBurnRate().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 26, 2)]);
		diff.getM_ThirstIncrease().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 28, 2)]);
		diff.getM_FatigueIncrease().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 30, 2)]);
		diff.getM_FreezingIncrease().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 32, 2)]);
		diff.getM_HoursWarmthToCureHypothermia().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 34, 2)]);
		diff.getM_ItemDecayRate().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 36, 2)]);
		diff.getM_ItemSpawnChance().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 38, 2)]);
		diff.getM_ReduceWildlifePopOverTime().setEnumValue(CustomTunables.NLMH.VALS[bitsToDecimal(bitArray, 40, 2)]);
		diff.getM_EmptyContainerChance().setEnumValue(CustomTunables.NLMH.VALS[bitsToDecimal(bitArray, 42, 2)]);
		diff.getM_StickBranchStoneSpawnFrequency()
				.setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 44, 2)]);
		diff.getM_StartingGear().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 46, 2)]);
		diff.getM_StruggleDamageReceivedBonus().setEnumValue(CustomTunables.NLMH.VALS[bitsToDecimal(bitArray, 48, 2)]);
		diff.getM_ScentIncreaseFromMeatBlood().setEnumValue(CustomTunables.NLMH.VALS[bitsToDecimal(bitArray, 50, 2)]);
		diff.getM_WolfFleeChance().setEnumValue(CustomTunables.NLMH.VALS[bitsToDecimal(bitArray, 52, 2)]);
		diff.getM_StruggleDamageEventSeverity().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 56, 2)]);
		diff.getM_WildlifeSmellRange().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 58, 2)]);
		diff.getM_WildlifeSpawnFrequency().setEnumValue(CustomTunables.LMHV.VALS[bitsToDecimal(bitArray, 60, 2)]);
		diff.getM_WildlifeNotAttackUnprovoked().setEnumValue(CustomTunables.Bool.get(bitArray.get(62)));
		diff.getM_NoPredatorsFirstDay().setEnumValue(CustomTunables.Bool.get(bitArray.get(63)));
		diff.getM_CabinFeverEnabled().setEnumValue(CustomTunables.Bool.get(bitArray.get(64)));
		diff.getM_ParasitesEnabled().setEnumValue(CustomTunables.Bool.get(bitArray.get(65)));
		int num = bitsToDecimal(bitArray, 66, 12);
		int[] array = convertDecToBase(num, 5, 5);
		diff.getM_ConditionRecoveryRest().setEnumValue(CustomTunables.NLMHV.VALS[array[0]]);
		diff.getM_ConditionRecoveryAwake().setEnumValue(CustomTunables.NLMHV.VALS[array[1]]);
		diff.getM_FrosbiteRisk().setEnumValue(CustomTunables.NLMHV.VALS[array[2]]);
		diff.getM_RabbitSpawnChance().setEnumValue(CustomTunables.NLMHV.VALS[array[3]]);
		diff.getM_BearSpawnChance().setEnumValue(CustomTunables.NLMHV.VALS[array[4]]);
		num = bitsToDecimal(bitArray, 78, 12);
		array = convertDecToBase(num, 5, 5);
		diff.getM_BlizzardFrequency().setEnumValue(CustomTunables.NLMHV.VALS[array[0]]);
		diff.getM_DeerSpawnChance().setEnumValue(CustomTunables.NLMHV.VALS[array[1]]);
		diff.getM_FishSpawnChance().setEnumValue(CustomTunables.NLMHV.VALS[array[2]]);
		diff.getM_WolfSpawnChance().setEnumValue(CustomTunables.NLMHV.VALS[array[3]]);
		diff.getM_StartTimeOfDay().setEnumValue(CustomTunables.TimeOfDay.VALS[array[4]]);
		diff.getM_WildlifeInterruptRest().setEnumValue(CustomTunables.Bool.get(bitArray.get(90)));
		num = bitsToDecimal(bitArray, 91, 5);
		int[] array2 = convertDecToBase(num, 3, 3);
		diff.getM_WindVariability().setEnumValue(CustomTunables.LMH.VALS[array2[0]]);
		diff.getM_PlantSpawnFrequency().setEnumValue(CustomTunables.LMH.VALS[array2[1]]);
		diff.getM_ReduceMaxItemsContainers().setEnumValue(CustomTunables.NLH.VALS[array2[2]]);
		num = bitsToDecimal(bitArray, 96, 6);
		int num2 = num / 7;
		diff.getM_StartWeather().setEnumValue(CustomTunables.Weather.VALS[num2]);
		num -= num2 * 7;
		num2 = num / 3;
		diff.getM_WolfSpawnDistance().setEnumValue(CustomTunables.Distance.VALS[num2]);
		num -= num2 * 3;
		num2 = num;
		diff.getM_WildlifeDetectionRange().setEnumValue(CustomTunables.Distance.VALS[num2]);
		num = bitsToDecimal(bitArray, 102, 3);
		array = convertDecToBase(num, 5, 1);
		diff.getM_MooseSpawnChance().setEnumValue(CustomTunables.NLMHV.VALS[array[0]]);
	}

	private static int bitsToDecimal(CSharpBitArray bitArray, int startIndex, int length) {
		CSharpBitArray bitArray2 = new CSharpBitArray(length);
		for (int i = 0; i < bitArray2.length(); i++) {
			bitArray2.set(i, bitArray.get(startIndex + i));
		}
		int[] array = new int[1];
		bitArray2.copyTo(array, 0);
		return array[0];
	}

	private static int[] convertDecToBase(int decimalValue, int baseValue, int size) {
		List<Integer> list = new ArrayList<Integer>(size);
		for (int i = size - 1; i >= 0; i--) {
			int num = decimalValue / (int) Math.pow(baseValue, i);
			list.add(num);
			decimalValue -= num * (int) Math.pow(baseValue, i);
		}
		return list.stream().mapToInt(Integer::intValue).toArray();
	}
}
