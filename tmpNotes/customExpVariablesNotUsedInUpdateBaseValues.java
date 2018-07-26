///// GAME START

// Baseline resource availability
public CustomExperienceModeManager.CustomTunableLMHV m_BaseWorldDifficulty;
// Starting time of day
public CustomExperienceModeManager.CustomTunableTimeOfDay m_StartTimeOfDay;
// Starting weather
public CustomExperienceModeManager.CustomTunableWeather m_StartWeather;
// Players spawns indoors
public bool m_AllowInteriorStartingSpawn;
// Survivor monologue
public bool m_SurvivorVoiceOver;


///// ENVIRONEMENT


// Wind variance
public CustomExperienceModeManager.CustomTunableLMH m_WindVariability;
// Aurora freq
public CustomExperienceModeManager.CustomTunableNLMH m_AuroraFrequency;
// Fire overcomes air temp
public bool m_UseMinAirTempValue;

// UNUSED ???
public bool m_WeakIce;


///// HEALTH

// Frostbite rate
public CustomExperienceModeManager.CustomTunableNLMHV m_FrosbiteRisk;
// Cabin fever
public bool m_CabinFeverEnabled;
// Parasites
public bool m_ParasitesEnabled;
// Dysentery
public bool m_EnableDysentery;
// Sprains
public bool m_EnableSprains;
// Food poison
public bool m_EnableFoodPoisoning;
// Broken ribs
public bool m_EnableBrokenRibs;
// Rest as a resource
public bool m_LimitedRest;
// Fire prevents freezing
public bool m_AdjustFreezingDueToNearbyFire;
// Wakes up if freezing
public bool m_InterruptIfFreezingWhileSleeping;


///// GEAR


// Starting gear allocation
public CustomExperienceModeManager.CustomTunableLMHV m_StartingGear;
// Rifle availability
public bool m_RiflesInWorld;
// Harvestable plant availability
public CustomExperienceModeManager.CustomTunableLMH m_PlantSpawnFrequency;



///// WILDLIFE SPAWNS


// Wolf
public CustomExperienceModeManager.CustomTunableNLMHV m_WolfSpawnChance;
// Deer
public CustomExperienceModeManager.CustomTunableNLMHV m_DeerSpawnChance;
// Rabbit
public CustomExperienceModeManager.CustomTunableNLMHV m_RabbitSpawnChance;
// Bear
public CustomExperienceModeManager.CustomTunableNLMHV m_BearSpawnChance;
// Moose
public CustomExperienceModeManager.CustomTunableNLMHV m_MooseSpawnChance;
// Wildlife respawn frequency
public CustomExperienceModeManager.CustomTunableLMHV m_WildlifeSpawnFrequency;


// Predator grace period
public bool m_NoPredatorsFirstDay;


///// WILDLIFE BEHAVIOUR


// Scent increase from meat/blood
public CustomExperienceModeManager.CustomTunableNLMH m_ScentIncreaseFromMeatBlood;
// Passive wildlife
public bool m_WildlifeNotAttackUnprovoked;
// Attacks during rest
public bool m_WildlifeInterruptRest;
// Wolf fear
public CustomExperienceModeManager.CustomTunableNLMH m_WolfFleeChance;
// Detection range
public CustomExperienceModeManager.CustomTunableDistance m_WildlifeDetectionRange;


///// WILDLIFE STRUGGLE


// Damage severity
public CustomExperienceModeManager.CustomTunableLMHV m_StruggleDamageEventSeverity;
