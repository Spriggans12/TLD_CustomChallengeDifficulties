package fr.spriggans.tld.difficultyparser.parameter;

import fr.spriggans.tld.difficultyparser.enums.CustomTunables;
import fr.spriggans.tld.difficultyparser.util.ParserUtil;

/**
 * Class containing all fields settable via Custom difficulty mode.
 */
public class DifficutlyParameters {

	///// GAME START

	// Baseline resource availability
	private final Field<CustomTunables.LMHV> m_BaseWorldDifficulty = new Field<>("Baseline resource availability",
			"BaseWorldDifficulty");
	// Starting time of day
	private final Field<CustomTunables.TimeOfDay> m_StartTimeOfDay = new Field<>("Starting time of day",
			"StartTimeOfDay");
	// Starting weather
	private final Field<CustomTunables.Weather> m_StartWeather = new Field<>("Starting weather", "StartWeather");
	// Players spawns indoors
	private final Field<CustomTunables.Bool> m_AllowInteriorStartingSpawn = new Field<>("Players spawns indoors",
			"AllowInteriorStartingSpawn");
	// Survivor monologue
	private final Field<CustomTunables.Bool> m_SurvivorVoiceOver = new Field<>("Survivor monologue",
			"SurvivorVoiceOver");

	///// ENVIRONEMENT

	// Length of day mult
	private final Field<CustomTunables.DayNightMultiplier> m_DayNightLengthMultiplier = new Field<>(
			"Length of day mult", "DayNightLengthMultiplier");
	// Weather variance
	private final Field<CustomTunables.LMHV> m_WeatherChangeFrequency = new Field<>("Weather variance",
			"WeatherChangeFrequency");
	// Blizzard freq
	private final Field<CustomTunables.NLMHV> m_BlizzardFrequency = new Field<>("Blizzard freq", "BlizzardFrequency");
	// Worlds gets colder other time
	private final Field<CustomTunables.NLMH> m_GradualTempReductionRate = new Field<>("Worlds gets colder other time",
			"GradualTempReductionRate");
	// Wind variance
	private final Field<CustomTunables.LMH> m_WindVariability = new Field<>("Wind variance", "WindVariability");
	// Aurora freq
	private final Field<CustomTunables.NLMH> m_AuroraFrequency = new Field<>("Aurora freq", "AuroraFrequency");
	// Fire overcomes air temp
	private final Field<CustomTunables.Bool> m_UseMinAirTempValue = new Field<>("Fire overcomes air temp",
			"UseMinAirTempValue");

	///// HEALTH

	// Calorie burn rate
	private final Field<CustomTunables.LMHV> m_CalorieBurnRate = new Field<>("Calorie burn rate", "CalorieBurnRate");
	// Thirst rate
	private final Field<CustomTunables.LMHV> m_ThirstIncrease = new Field<>("Thirst rate", "ThirstIncrease");
	// Fatigue rate
	private final Field<CustomTunables.LMHV> m_FatigueIncrease = new Field<>("Fatigue rate", "FatigueIncrease");
	// Freezing rate
	private final Field<CustomTunables.LMHV> m_FreezingIncrease = new Field<>("Freezing rate", "FreezingIncrease");
	// At rest condition rec rate
	private final Field<CustomTunables.NLMHV> m_ConditionRecoveryRest = new Field<>("At rest condition rec rate",
			"ConditionRecoveryRest");
	// Condition rec rate
	private final Field<CustomTunables.NLMHV> m_ConditionRecoveryAwake = new Field<>("Condition rec rate",
			"ConditionRecoveryAwake");
	// Hypothermia rec time
	private final Field<CustomTunables.LMHV> m_HoursWarmthToCureHypothermia = new Field<>("Hypothermia rec time",
			"HoursWarmthToCureHypothermia");
	// Frostbite rate
	private final Field<CustomTunables.NLMHV> m_FrosbiteRisk = new Field<>("Frostbite rate", "FrosbiteRisk");
	// Cabin fever
	private final Field<CustomTunables.Bool> m_CabinFeverEnabled = new Field<>("Cabin fever", "CabinFeverEnabled");
	// Parasites
	private final Field<CustomTunables.Bool> m_ParasitesEnabled = new Field<>("Parasites", "ParasitesEnabled");
	// Dysentery
	private final Field<CustomTunables.Bool> m_EnableDysentery = new Field<>("Dysentery", "EnableDysentery");
	// Sprains
	private final Field<CustomTunables.Bool> m_EnableSprains = new Field<>("Sprains", "EnableSprains");
	// Food poison
	private final Field<CustomTunables.Bool> m_EnableFoodPoisoning = new Field<>("Food poison", "EnableFoodPoisoning");
	// Broken ribs
	private final Field<CustomTunables.Bool> m_EnableBrokenRibs = new Field<>("Broken ribs", "EnableBrokenRibs");
	// Rest as a resource
	private final Field<CustomTunables.Bool> m_LimitedRest = new Field<>("Rest as a resource", "LimitedRest");
	// Fire prevents freezing
	private final Field<CustomTunables.Bool> m_AdjustFreezingDueToNearbyFire = new Field<>("Fire prevents freezing",
			"AdjustFreezingDueToNearbyFire");
	// Wakes up if freezing
	private final Field<CustomTunables.Bool> m_InterruptIfFreezingWhileSleeping = new Field<>("Wakes up if freezing",
			"InterruptIfFreezingWhileSleeping");

	///// GEAR

	// Item decay rate
	private final Field<CustomTunables.LMHV> m_ItemDecayRate = new Field<>("Item decay rate", "ItemDecayRate");
	// Loose item availability
	private final Field<CustomTunables.LMHV> m_ItemSpawnChance = new Field<>("Loose item availability",
			"ItemSpawnChance");
	// Empty container chance
	private final Field<CustomTunables.NLMH> m_EmptyContainerChance = new Field<>("Empty container chance",
			"EmptyContainerChance");
	// Stick, branch, stone spawn freq
	private final Field<CustomTunables.LMHV> m_StickBranchStoneSpawnFrequency = new Field<>(
			"Stick, branch, stone spawn freq", "StickBranchStoneSpawnFrequency");
	// Starting gear allocation
	private final Field<CustomTunables.LMHV> m_StartingGear = new Field<>("Starting gear allocation", "StartingGear");
	// Rifle availability
	private final Field<CustomTunables.Bool> m_RiflesInWorld = new Field<>("Rifle availability", "RiflesInWorld");
	// Harvestable plant availability
	private final Field<CustomTunables.LMH> m_PlantSpawnFrequency = new Field<>("Harvestable plant availability",
			"PlantSpawnFrequency");
	// Reduce container item density
	private final Field<CustomTunables.NLH> m_ReduceMaxItemsContainers = new Field<>("Reduce container item density",
			"ReduceMaxItemsContainers");

	///// WILDLIFE SPAWNS

	// Fish
	private final Field<CustomTunables.NLMHV> m_FishSpawnChance = new Field<>("FishSpawnChance", "FishSpawnChance");
	// Wolf
	private final Field<CustomTunables.NLMHV> m_WolfSpawnChance = new Field<>("WolfSpawnChance", "WolfSpawnChance");
	// Deer
	private final Field<CustomTunables.NLMHV> m_DeerSpawnChance = new Field<>("DeerSpawnChance", "DeerSpawnChance");
	// Rabbit
	private final Field<CustomTunables.NLMHV> m_RabbitSpawnChance = new Field<>("RabbitSpawnChance",
			"RabbitSpawnChance");
	// Bear
	private final Field<CustomTunables.NLMHV> m_BearSpawnChance = new Field<>("BearSpawnChance", "BearSpawnChance");
	// Moose
	private final Field<CustomTunables.NLMHV> m_MooseSpawnChance = new Field<>("MooseSpawnChance", "MooseSpawnChance");
	// Wildlife respawn frequency
	private final Field<CustomTunables.LMHV> m_WildlifeSpawnFrequency = new Field<>("Wildlife respawn frequency",
			"WildlifeSpawnFrequency");
	// Reduce wildlife pop over time
	private final Field<CustomTunables.NLMH> m_ReduceWildlifePopOverTime = new Field<>("Reduce wildlife pop over time",
			"ReduceWildlifePopOverTime");
	// Wolf spawn distance
	private final Field<CustomTunables.Distance> m_WolfSpawnDistance = new Field<>("Wolf spawn distance",
			"WolfSpawnDistance");
	// Predator grace period
	private final Field<CustomTunables.Bool> m_NoPredatorsFirstDay = new Field<>("Predator grace period",
			"NoPredatorsFirstDay");

	///// WILDLIFE BEHAVIOUR

	// Smell range
	private final Field<CustomTunables.LMHV> m_WildlifeSmellRange = new Field<>("Smell range", "WildlifeSmellRange");
	// Scent increase from meat/blood
	private final Field<CustomTunables.NLMH> m_ScentIncreaseFromMeatBlood = new Field<>(
			"Scent increase from meat/blood", "ScentIncreaseFromMeatBlood");
	// Passive wildlife
	private final Field<CustomTunables.Bool> m_WildlifeNotAttackUnprovoked = new Field<>("Passive wildlife",
			"WildlifeNotAttackUnprovoked");
	// Attacks during rest
	private final Field<CustomTunables.Bool> m_WildlifeInterruptRest = new Field<>("Attacks during rest",
			"WildlifeInterruptRest");
	// Wolf fear
	private final Field<CustomTunables.NLMH> m_WolfFleeChance = new Field<>("Wolf fear", "WolfFleeChance");
	// Detection range
	private final Field<CustomTunables.Distance> m_WildlifeDetectionRange = new Field<>("Detection range",
			"WildlifeDetectionRange");

	///// WILDLIFE STRUGGLE

	// Fighting back bonus
	private final Field<CustomTunables.NLMH> m_StrugglePlayerStrengthBonus = new Field<>("Fighting back bonus",
			"StrugglePlayerStrengthBonus");
	// Condition damage
	private final Field<CustomTunables.NLMH> m_StruggleDamageReceivedBonus = new Field<>("Condition damage",
			"StruggleDamageReceivedBonus");
	// Clothing damage
	private final Field<CustomTunables.NLMH> m_StruggleClothingDamageBonus = new Field<>("Clothing damage",
			"StruggleClothingDamageBonus");
	// Damage severity
	private final Field<CustomTunables.LMHV> m_StruggleDamageEventSeverity = new Field<>("Damage severity",
			"StruggleDamageEventSeverity");

	public DifficutlyParameters(String difficultyString) {
		ParserUtil.setValuesFromString(this, difficultyString);
	}

	public Field<CustomTunables.LMHV> getM_BaseWorldDifficulty() {
		return m_BaseWorldDifficulty;
	}

	public Field<CustomTunables.TimeOfDay> getM_StartTimeOfDay() {
		return m_StartTimeOfDay;
	}

	public Field<CustomTunables.Weather> getM_StartWeather() {
		return m_StartWeather;
	}

	public Field<CustomTunables.Bool> getM_AllowInteriorStartingSpawn() {
		return m_AllowInteriorStartingSpawn;
	}

	public Field<CustomTunables.Bool> getM_SurvivorVoiceOver() {
		return m_SurvivorVoiceOver;
	}

	public Field<CustomTunables.DayNightMultiplier> getM_DayNightLengthMultiplier() {
		return m_DayNightLengthMultiplier;
	}

	public Field<CustomTunables.LMHV> getM_WeatherChangeFrequency() {
		return m_WeatherChangeFrequency;
	}

	public Field<CustomTunables.NLMHV> getM_BlizzardFrequency() {
		return m_BlizzardFrequency;
	}

	public Field<CustomTunables.NLMH> getM_GradualTempReductionRate() {
		return m_GradualTempReductionRate;
	}

	public Field<CustomTunables.LMH> getM_WindVariability() {
		return m_WindVariability;
	}

	public Field<CustomTunables.NLMH> getM_AuroraFrequency() {
		return m_AuroraFrequency;
	}

	public Field<CustomTunables.Bool> getM_UseMinAirTempValue() {
		return m_UseMinAirTempValue;
	}

	public Field<CustomTunables.LMHV> getM_CalorieBurnRate() {
		return m_CalorieBurnRate;
	}

	public Field<CustomTunables.LMHV> getM_ThirstIncrease() {
		return m_ThirstIncrease;
	}

	public Field<CustomTunables.LMHV> getM_FatigueIncrease() {
		return m_FatigueIncrease;
	}

	public Field<CustomTunables.LMHV> getM_FreezingIncrease() {
		return m_FreezingIncrease;
	}

	public Field<CustomTunables.NLMHV> getM_ConditionRecoveryRest() {
		return m_ConditionRecoveryRest;
	}

	public Field<CustomTunables.NLMHV> getM_ConditionRecoveryAwake() {
		return m_ConditionRecoveryAwake;
	}

	public Field<CustomTunables.LMHV> getM_HoursWarmthToCureHypothermia() {
		return m_HoursWarmthToCureHypothermia;
	}

	public Field<CustomTunables.NLMHV> getM_FrosbiteRisk() {
		return m_FrosbiteRisk;
	}

	public Field<CustomTunables.Bool> getM_CabinFeverEnabled() {
		return m_CabinFeverEnabled;
	}

	public Field<CustomTunables.Bool> getM_ParasitesEnabled() {
		return m_ParasitesEnabled;
	}

	public Field<CustomTunables.Bool> getM_EnableDysentery() {
		return m_EnableDysentery;
	}

	public Field<CustomTunables.Bool> getM_EnableSprains() {
		return m_EnableSprains;
	}

	public Field<CustomTunables.Bool> getM_EnableFoodPoisoning() {
		return m_EnableFoodPoisoning;
	}

	public Field<CustomTunables.Bool> getM_EnableBrokenRibs() {
		return m_EnableBrokenRibs;
	}

	public Field<CustomTunables.Bool> getM_LimitedRest() {
		return m_LimitedRest;
	}

	public Field<CustomTunables.Bool> getM_AdjustFreezingDueToNearbyFire() {
		return m_AdjustFreezingDueToNearbyFire;
	}

	public Field<CustomTunables.Bool> getM_InterruptIfFreezingWhileSleeping() {
		return m_InterruptIfFreezingWhileSleeping;
	}

	public Field<CustomTunables.LMHV> getM_ItemDecayRate() {
		return m_ItemDecayRate;
	}

	public Field<CustomTunables.LMHV> getM_ItemSpawnChance() {
		return m_ItemSpawnChance;
	}

	public Field<CustomTunables.NLMH> getM_EmptyContainerChance() {
		return m_EmptyContainerChance;
	}

	public Field<CustomTunables.LMHV> getM_StickBranchStoneSpawnFrequency() {
		return m_StickBranchStoneSpawnFrequency;
	}

	public Field<CustomTunables.LMHV> getM_StartingGear() {
		return m_StartingGear;
	}

	public Field<CustomTunables.Bool> getM_RiflesInWorld() {
		return m_RiflesInWorld;
	}

	public Field<CustomTunables.LMH> getM_PlantSpawnFrequency() {
		return m_PlantSpawnFrequency;
	}

	public Field<CustomTunables.NLH> getM_ReduceMaxItemsContainers() {
		return m_ReduceMaxItemsContainers;
	}

	public Field<CustomTunables.NLMHV> getM_FishSpawnChance() {
		return m_FishSpawnChance;
	}

	public Field<CustomTunables.NLMHV> getM_WolfSpawnChance() {
		return m_WolfSpawnChance;
	}

	public Field<CustomTunables.NLMHV> getM_DeerSpawnChance() {
		return m_DeerSpawnChance;
	}

	public Field<CustomTunables.NLMHV> getM_RabbitSpawnChance() {
		return m_RabbitSpawnChance;
	}

	public Field<CustomTunables.NLMHV> getM_BearSpawnChance() {
		return m_BearSpawnChance;
	}

	public Field<CustomTunables.NLMHV> getM_MooseSpawnChance() {
		return m_MooseSpawnChance;
	}

	public Field<CustomTunables.LMHV> getM_WildlifeSpawnFrequency() {
		return m_WildlifeSpawnFrequency;
	}

	public Field<CustomTunables.NLMH> getM_ReduceWildlifePopOverTime() {
		return m_ReduceWildlifePopOverTime;
	}

	public Field<CustomTunables.Distance> getM_WolfSpawnDistance() {
		return m_WolfSpawnDistance;
	}

	public Field<CustomTunables.Bool> getM_NoPredatorsFirstDay() {
		return m_NoPredatorsFirstDay;
	}

	public Field<CustomTunables.LMHV> getM_WildlifeSmellRange() {
		return m_WildlifeSmellRange;
	}

	public Field<CustomTunables.NLMH> getM_ScentIncreaseFromMeatBlood() {
		return m_ScentIncreaseFromMeatBlood;
	}

	public Field<CustomTunables.Bool> getM_WildlifeNotAttackUnprovoked() {
		return m_WildlifeNotAttackUnprovoked;
	}

	public Field<CustomTunables.Bool> getM_WildlifeInterruptRest() {
		return m_WildlifeInterruptRest;
	}

	public Field<CustomTunables.NLMH> getM_WolfFleeChance() {
		return m_WolfFleeChance;
	}

	public Field<CustomTunables.Distance> getM_WildlifeDetectionRange() {
		return m_WildlifeDetectionRange;
	}

	public Field<CustomTunables.NLMH> getM_StrugglePlayerStrengthBonus() {
		return m_StrugglePlayerStrengthBonus;
	}

	public Field<CustomTunables.NLMH> getM_StruggleDamageReceivedBonus() {
		return m_StruggleDamageReceivedBonus;
	}

	public Field<CustomTunables.NLMH> getM_StruggleClothingDamageBonus() {
		return m_StruggleClothingDamageBonus;
	}

	public Field<CustomTunables.LMHV> getM_StruggleDamageEventSeverity() {
		return m_StruggleDamageEventSeverity;
	}
}
