using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ModLoader;
using TerrariaAchievementLib.Achievements;
using PlayerAchievements.Achievements.Hardcore;

namespace PlayerAchievements.Achievements.Hardestcore
{
    /// <summary>
    /// Hardestcore achievement attributes
    /// </summary>
    public class HardestcoreAchievements
    {
        /// <summary>
        /// Hardestcore achievement condition requirements
        /// </summary>
        public static readonly ConditionReqs reqs = new(PlayerDiff.Hardestcore, WorldDiff.Classic, SpecialSeed.None);
    }

    public class HardestcoreTimberAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreTimberAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("TIMBER", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardcoreChampionOfTerrariaAchievement>());
        }
    }

    public class HardestcoreBenchedAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreBenchedAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("BENCHED", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreTimberAchievement>());
        }
    }

    public class HardestcoreNoHoboAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreNoHoboAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("NO_HOBO", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreBenchedAchievement>());
        }
    }

    public class HardestcoreObtainHammerAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreObtainHammerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("OBTAIN_HAMMER", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreNoHoboAchievement>());
        }
    }

    public class HardestcoreOooShinyAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreOooShinyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("OOO_SHINY", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreObtainHammerAchievement>());
        }
    }

    public class HardestcoreHeartBreakerAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreHeartBreakerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("HEART_BREAKER", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreOooShinyAchievement>());
        }
    }

    public class HardestcoreHeavyMetalAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreHeavyMetalAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("HEAVY_METAL", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreHeartBreakerAchievement>());
        }
    }

    public class HardestcoreIAmLootAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreIAmLootAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("I_AM_LOOT", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreHeavyMetalAchievement>());
        }
    }

    public class HardestcoreStarPowerAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreStarPowerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("STAR_POWER", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreIAmLootAchievement>());
        }
    }

    public class HardestcoreHoldOnTightAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreHoldOnTightAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("HOLD_ON_TIGHT", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreStarPowerAchievement>());
        }
    }

    public class HardestcoreEyeOnYouAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreEyeOnYouAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("EYE_ON_YOU", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreHoldOnTightAchievement>());
        }
    }

    public class HardestcoreSmashingPoppetAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreSmashingPoppetAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("SMASHING_POPPET", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreEyeOnYouAchievement>());
        }
    }

    public class HardestcoreWheresMyHoneyAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreWheresMyHoneyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("WHERES_MY_HONEY", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreSmashingPoppetAchievement>());
        }
    }

    public class HardestcoreStingOperationAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreStingOperationAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("STING_OPERATION", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreWheresMyHoneyAchievement>());
        }
    }

    public class HardestcoreBonedAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreBonedAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("BONED", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreStingOperationAchievement>());
        }
    }

    public class HardestcoreDungeonHeistAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreDungeonHeistAchievement";

        public override void AutoStaticDefaults() { }

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("DUNGEON_HEIST", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreBonedAchievement>());
        }
    }

    public class HardestcoreItsGettingHotInHereAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreItsGettingHotInHereAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("ITS_GETTING_HOT_IN_HERE", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreDungeonHeistAchievement>());
        }
    }

    public class HardestcoreMinerForFireAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreMinerForFireAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("MINER_FOR_FIRE", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreItsGettingHotInHereAchievement>());
        }
    }

    public class HardestcoreStillHungryAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreStillHungryAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("STILL_HUNGRY", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreMinerForFireAchievement>());
        }
    }

    public class HardestcoreItsHardAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreItsHardAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("ITS_HARD", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreStillHungryAchievement>());
        }
    }

    public class HardestcoreBegoneEvilAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreBegoneEvilAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("BEGONE_EVIL", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreItsHardAchievement>());
        }
    }

    public class HardestcoreExtraShinyAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreExtraShinyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("EXTRA_SHINY", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreBegoneEvilAchievement>());
        }
    }

    public class HardestcoreHeadInTheCloudsAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreHeadInTheCloudsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("HEAD_IN_THE_CLOUDS", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreExtraShinyAchievement>());
        }
    }

    public class HardestcoreBucketsOfBoltsAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreBucketsOfBoltsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("BUCKET_OF_BOLTS", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreHeadInTheCloudsAchievement>());
        }
    }

    public class HardestcoreDraxAttaxAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreDraxAttaxAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("DRAX_ATTAX", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreBucketsOfBoltsAchievement>());
        }
    }

    public class HardestcorePhotosynthesisAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcorePhotosynthesisAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("PHOTOSYNTHESIS", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreDraxAttaxAchievement>());
        }
    }

    public class HardestcoreGetALifeAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreGetALifeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("GET_A_LIFE", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcorePhotosynthesisAchievement>());
        }
    }

    public class HardestcoreTheGreatSouthernPlantkillAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreTheGreatSouthernPlantkillAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("THE_GREAT_SOUTHERN_PLANTKILL", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreGetALifeAchievement>());
        }
    }

    public class HardestcoreTempleRaiderAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreTempleRaiderAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("TEMPLE_RAIDER", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreTheGreatSouthernPlantkillAchievement>());
        }
    }

    public class HardestcoreLihzahrdianIdolAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreLihzahrdianIdolAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("LIHZAHRDIAN_IDOL", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreTempleRaiderAchievement>());
        }
    }

    public class HardestcoreRobbingTheGraveAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreRobbingTheGraveAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("ROBBING_THE_GRAVE", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreLihzahrdianIdolAchievement>());
        }
    }

    public class HardestcoreObsessiveDevotionAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreObsessiveDevotionAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("OBSESSIVE_DEVOTION", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreRobbingTheGraveAchievement>());
        }
    }

    public class HardestcoreStarDestroyerAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreStarDestroyerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("STAR_DESTROYER", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreObsessiveDevotionAchievement>());
        }
    }

    public class HardestcoreChampionOfTerrariaAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/HardestcoreChampionOfTerrariaAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("CHAMPION_OF_TERRARIA", HardestcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<HardestcoreStarDestroyerAchievement>());
        }
    }
}
