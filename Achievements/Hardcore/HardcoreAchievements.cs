using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ModLoader;
using TerrariaAchievementLib.Achievements;
using PlayerAchievements.Achievements.Mediumcore;

namespace PlayerAchievements.Achievements.Hardcore
{
    /// <summary>
    /// Hardcore achievement attributes
    /// </summary>
    public class HardcoreAchievements
    {
        /// <summary>
        /// Hardcore achievement condition requirements
        /// </summary>
        public static readonly ConditionReqs reqs = new(PlayerDiff.Hardcore, WorldDiff.Classic, SpecialSeed.None);
    }

    public class HardcoreTimberAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreTimberAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("TIMBER", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreChampionOfTerrariaAchievement>());
        }
    }

    public class HardcoreBenchedAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreBenchedAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("BENCHED", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreTimberAchievement>());
        }
    }

    public class HardcoreNoHoboAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreNoHoboAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("NO_HOBO", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreBenchedAchievement>());
        }
    }

    public class HardcoreObtainHammerAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreObtainHammerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("OBTAIN_HAMMER", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreNoHoboAchievement>());
        }
    }

    public class HardcoreOooShinyAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreOooShinyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("OOO_SHINY", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreObtainHammerAchievement>());
        }
    }

    public class HardcoreHeartBreakerAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreHeartBreakerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("HEART_BREAKER", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreOooShinyAchievement>());
        }
    }

    public class HardcoreHeavyMetalAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreHeavyMetalAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("HEAVY_METAL", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreHeartBreakerAchievement>());
        }
    }

    public class HardcoreIAmLootAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreIAmLootAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("I_AM_LOOT", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreHeavyMetalAchievement>());
        }
    }

    public class HardcoreStarPowerAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreStarPowerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("STAR_POWER", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreIAmLootAchievement>());
        }
    }

    public class HardcoreHoldOnTightAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreHoldOnTightAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("HOLD_ON_TIGHT", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreStarPowerAchievement>());
        }
    }

    public class HardcoreEyeOnYouAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreEyeOnYouAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("EYE_ON_YOU", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreHoldOnTightAchievement>());
        }
    }

    public class HardcoreSmashingPoppetAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreSmashingPoppetAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("SMASHING_POPPET", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreEyeOnYouAchievement>());
        }
    }

    public class HardcoreWheresMyHoneyAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreWheresMyHoneyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("WHERES_MY_HONEY", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreSmashingPoppetAchievement>());
        }
    }

    public class HardcoreStingOperationAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreStingOperationAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("STING_OPERATION", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreWheresMyHoneyAchievement>());
        }
    }

    public class HardcoreBonedAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreBonedAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("BONED", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreStingOperationAchievement>());
        }
    }

    public class HardcoreDungeonHeistAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreDungeonHeistAchievement";

        public override void AutoStaticDefaults() { }

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("DUNGEON_HEIST", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreBonedAchievement>());
        }
    }

    public class HardcoreItsGettingHotInHereAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreItsGettingHotInHereAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("ITS_GETTING_HOT_IN_HERE", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreDungeonHeistAchievement>());
        }
    }

    public class HardcoreMinerForFireAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreMinerForFireAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("MINER_FOR_FIRE", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreItsGettingHotInHereAchievement>());
        }
    }

    public class HardcoreStillHungryAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreStillHungryAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("STILL_HUNGRY", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreMinerForFireAchievement>());
        }
    }

    public class HardcoreItsHardAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreItsHardAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("ITS_HARD", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreStillHungryAchievement>());
        }
    }

    public class HardcoreBegoneEvilAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreBegoneEvilAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("BEGONE_EVIL", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreItsHardAchievement>());
        }
    }

    public class HardcoreExtraShinyAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreExtraShinyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("EXTRA_SHINY", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreBegoneEvilAchievement>());
        }
    }

    public class HardcoreHeadInTheCloudsAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreHeadInTheCloudsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("HEAD_IN_THE_CLOUDS", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreExtraShinyAchievement>());
        }
    }

    public class HardcoreBucketsOfBoltsAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreBucketsOfBoltsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("BUCKET_OF_BOLTS", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreHeadInTheCloudsAchievement>());
        }
    }

    public class HardcoreDraxAttaxAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreDraxAttaxAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("DRAX_ATTAX", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreBucketsOfBoltsAchievement>());
        }
    }

    public class HardcorePhotosynthesisAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcorePhotosynthesisAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("PHOTOSYNTHESIS", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreDraxAttaxAchievement>());
        }
    }

    public class HardcoreGetALifeAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreGetALifeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("GET_A_LIFE", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcorePhotosynthesisAchievement>());
        }
    }

    public class HardcoreTheGreatSouthernPlantkillAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreTheGreatSouthernPlantkillAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("THE_GREAT_SOUTHERN_PLANTKILL", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreGetALifeAchievement>());
        }
    }

    public class HardcoreTempleRaiderAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreTempleRaiderAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("TEMPLE_RAIDER", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreTheGreatSouthernPlantkillAchievement>());
        }
    }

    public class HardcoreLihzahrdianIdolAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreLihzahrdianIdolAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("LIHZAHRDIAN_IDOL", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreTempleRaiderAchievement>());
        }
    }

    public class HardcoreRobbingTheGraveAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreRobbingTheGraveAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("ROBBING_THE_GRAVE", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreLihzahrdianIdolAchievement>());
        }
    }

    public class HardcoreObsessiveDevotionAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreObsessiveDevotionAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("OBSESSIVE_DEVOTION", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreRobbingTheGraveAchievement>());
        }
    }

    public class HardcoreStarDestroyerAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreStarDestroyerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("STAR_DESTROYER", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreObsessiveDevotionAchievement>());
        }
    }

    public class HardcoreChampionOfTerrariaAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardcoreChampionOfTerrariaAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("CHAMPION_OF_TERRARIA", HardcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreStarDestroyerAchievement>());
        }
    }
}
