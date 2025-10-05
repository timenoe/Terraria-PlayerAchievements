using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ModLoader;
using TerrariaAchievementLib.Achievements;

namespace PlayerAchievements.Achievements.Mediumcore
{
    /// <summary>
    /// Mediumcore achievement attributes
    /// </summary>
    public class MediumcoreAchievements
    {
        /// <summary>
        /// Mediumcore achievement condition requirements
        /// </summary>
        public static readonly ConditionReqs reqs = new(PlayerDiff.Mediumcore, WorldDiff.Classic, SpecialSeed.None);
    }

    public class MediumcoreTimberAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreTimberAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("TIMBER", MediumcoreAchievements.reqs));
        }
    }

    public class MediumcoreBenchedAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreBenchedAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("BENCHED", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreTimberAchievement>());
        }
    }

    public class MediumcoreNoHoboAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreNoHoboAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("NO_HOBO", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreBenchedAchievement>());
        }
    }

    public class MediumcoreObtainHammerAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreObtainHammerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("OBTAIN_HAMMER", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreNoHoboAchievement>());
        }
    }

    public class MediumcoreOooShinyAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreOooShinyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("OOO_SHINY", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreObtainHammerAchievement>());
        }
    }

    public class MediumcoreHeartBreakerAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreHeartBreakerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("HEART_BREAKER", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreOooShinyAchievement>());
        }
    }

    public class MediumcoreHeavyMetalAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreHeavyMetalAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("HEAVY_METAL", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreHeartBreakerAchievement>());
        }
    }

    public class MediumcoreIAmLootAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreIAmLootAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("I_AM_LOOT", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreHeavyMetalAchievement>());
        }
    }

    public class MediumcoreStarPowerAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreStarPowerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("STAR_POWER", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreIAmLootAchievement>());
        }
    }

    public class MediumcoreHoldOnTightAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreHoldOnTightAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("HOLD_ON_TIGHT", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreStarPowerAchievement>());
        }
    }

    public class MediumcoreEyeOnYouAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreEyeOnYouAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("EYE_ON_YOU", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreHoldOnTightAchievement>());
        }
    }

    public class MediumcoreSmashingPoppetAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreSmashingPoppetAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("SMASHING_POPPET", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreEyeOnYouAchievement>());
        }
    }

    public class MediumcoreWheresMyHoneyAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreWheresMyHoneyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("WHERES_MY_HONEY", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreSmashingPoppetAchievement>());
        }
    }

    public class MediumcoreStingOperationAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreStingOperationAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("STING_OPERATION", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreWheresMyHoneyAchievement>());
        }
    }

    public class MediumcoreBonedAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreBonedAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("BONED", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreStingOperationAchievement>());
        }
    }

    public class MediumcoreDungeonHeistAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreDungeonHeistAchievement";

        public override void AutoStaticDefaults() {}

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("DUNGEON_HEIST", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreBonedAchievement>());
        }
    }

    public class MediumcoreItsGettingHotInHereAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreItsGettingHotInHereAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("ITS_GETTING_HOT_IN_HERE", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreDungeonHeistAchievement>());
        }
    }

    public class MediumcoreMinerForFireAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreMinerForFireAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("MINER_FOR_FIRE", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreItsGettingHotInHereAchievement>());
        }
    }

    public class MediumcoreStillHungryAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreStillHungryAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("STILL_HUNGRY", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreMinerForFireAchievement>());
        }
    }

    public class MediumcoreItsHardAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreItsHardAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("ITS_HARD", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreStillHungryAchievement>());
        }
    }

    public class MediumcoreBegoneEvilAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreBegoneEvilAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("BEGONE_EVIL", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreItsHardAchievement>());
        }
    }

    public class MediumcoreExtraShinyAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreExtraShinyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("EXTRA_SHINY", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreBegoneEvilAchievement>());
        }
    }

    public class MediumcoreHeadInTheCloudsAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreHeadInTheCloudsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("HEAD_IN_THE_CLOUDS", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreExtraShinyAchievement>());
        }
    }

    public class MediumcoreBucketsOfBoltsAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreBucketsOfBoltsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("BUCKET_OF_BOLTS", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreHeadInTheCloudsAchievement>());
        }
    }

    public class MediumcoreDraxAttaxAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreDraxAttaxAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("DRAX_ATTAX", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreBucketsOfBoltsAchievement>());
        }
    }

    public class MediumcorePhotosynthesisAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcorePhotosynthesisAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("PHOTOSYNTHESIS", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreDraxAttaxAchievement>());
        }
    }

    public class MediumcoreGetALifeAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreGetALifeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("GET_A_LIFE", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcorePhotosynthesisAchievement>());
        }
    }

    public class MediumcoreTheGreatSouthernPlantkillAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreTheGreatSouthernPlantkillAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("THE_GREAT_SOUTHERN_PLANTKILL", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreGetALifeAchievement>());
        }
    }

    public class MediumcoreTempleRaiderAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreTempleRaiderAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("TEMPLE_RAIDER", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreTheGreatSouthernPlantkillAchievement>());
        }
    }

    public class MediumcoreLihzahrdianIdolAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreLihzahrdianIdolAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("LIHZAHRDIAN_IDOL", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreTempleRaiderAchievement>());
        }
    }

    public class MediumcoreRobbingTheGraveAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreRobbingTheGraveAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Explorer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("ROBBING_THE_GRAVE", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreLihzahrdianIdolAchievement>());
        }
    }

    public class MediumcoreObsessiveDevotionAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreObsessiveDevotionAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("OBSESSIVE_DEVOTION", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreRobbingTheGraveAchievement>());
        }
    }

    public class MediumcoreStarDestroyerAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreStarDestroyerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("STAR_DESTROYER", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreObsessiveDevotionAchievement>());
        }
    }

    public class MediumcoreChampionOfTerrariaAchievement : ModAchievement
    {
        public override string TextureName => "PlayerAchievements/Assets/MediumcoreChampionOfTerrariaAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            ConditionHelper.AddConditions(this, ConditionHelper.GetVanillaAchievementConditions("CHAMPION_OF_TERRARIA", MediumcoreAchievements.reqs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MediumcoreStarDestroyerAchievement>());
        }
    }
}
