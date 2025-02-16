using System.Collections.Generic;
using System.Linq;
using Terraria.Achievements;
using Terraria.ID;
using Terraria.UI;
using TerrariaAchievementLib.Achievements;
using TerrariaAchievementLib.Achievements.Conditions;
using TerrariaAchievementLib.Systems;

namespace PlayerAchievements.Systems
{
    /// <summary>
    /// Adds player difficulty achievements to the in-game list
    /// </summary>
    public class PlayerAchievementSystem : AchievementSystem
    {
        protected override string Identifier { get => "PLAYER"; }

        protected override List<string> TexturePaths { get => ["PlayerAchievements/Assets/Achievements"]; }

        
        protected override void RegisterAchievements()
        {
            AchievementProgression.Enable(ProgressionRestriction.Player);
            
            ConditionReqs mediumcoreReqs = new(PlayerDiff.Mediumcore, WorldDiff.Classic, SpecialSeed.None);
            RegisterProgressionAchievements("MEDIUMCORE", mediumcoreReqs);

            ConditionReqs hardcoreReqs = new(PlayerDiff.Hardcore, WorldDiff.Classic, SpecialSeed.None);
            RegisterProgressionAchievements("HARDCORE", hardcoreReqs);

            ConditionReqs hardestcoreReqs = new(PlayerDiff.Hardestcore, WorldDiff.Classic, SpecialSeed.None);
            RegisterProgressionAchievements("HARDESTCORE", hardestcoreReqs);
        }

        /// <summary>
        /// Register progression-related achievements<br/>
        /// These are all achievements that are included in the vanilla Achievement Advisor
        /// </summary>
        /// <param name="id">Internal name prefix identifier</param>
        /// <param name="reqs">Common achievement requirements</param>
        private void RegisterProgressionAchievements(string id, ConditionReqs reqs)
        {
            int[] wood = [9, 619, 2504, 620, 2503, 2260, 621, 911, 1729, 5215];
            RegisterAchievement($"{id}_TIMBER", ItemGrabCondition.GrabAny(reqs, wood), AchievementCategory.Collector);

            int[] workbenches = ItemID.Sets.Workbenches.Select(s => (int)s).ToArray();
            RegisterAchievement($"{id}_BENCHED", ItemCraftCondition.CraftAny(reqs, workbenches), AchievementCategory.Collector);

            RegisterAchievement($"{id}_NO_HOBO", FlagProgressionCondition.Set(reqs, AchievementHelperID.Events.NPCMovedIn), AchievementCategory.Explorer);

            int[] hammers = [2775, 2746, 5283, 3505, 654, 3517, 7, 3493, 2780, 1513, 2516, 660, 3481, 657, 922, 3511, 2785, 3499, 3487, 196, 367, 104, 797, 2320, 787, 1234, 1262, 3465, 204, 217, 1507, 3524, 3522, 3525, 3523, 4317, 1305];
            RegisterAchievement($"{id}_OBTAIN_HAMMER", ItemGrabCondition.GrabAny(reqs, hammers), AchievementCategory.Collector);

            int[] ore = [7, 6, 9, 8, 166, 167, 168, 169, 22, 204, 58, 107, 108, 111, 221, 222, 223, 211];
            RegisterAchievement($"{id}_OOO_SHINY", TileDestroyCondition.DestroyAny(reqs, ore), AchievementCategory.Explorer);

            RegisterAchievement($"{id}_HEART_BREAKER", TileDestroyCondition.Destroy(reqs, TileID.Heart), AchievementCategory.Explorer);

            RegisterAchievement($"{id}_HEAVY_METAL", ItemGrabCondition.GrabAny(reqs, [ItemID.IronAnvil, ItemID.LeadAnvil]), AchievementCategory.Collector);

            RegisterAchievement($"{id}_I_AM_LOOT", FlagSpecialCondition.Set(reqs, AchievementHelperID.Special.PeekInGoldenChest), AchievementCategory.Explorer);

            RegisterAchievement($"{id}_STAR_POWER", FlagSpecialCondition.Set(reqs, AchievementHelperID.Special.ConsumeStar), AchievementCategory.Collector);

            RegisterAchievement($"{id}_HOLD_ON_TIGHT", ItemEquipCondition.Equip(reqs, ItemSlot.Context.EquipGrapple, ItemID.None), AchievementCategory.Collector);

            RegisterAchievement($"{id}_EYE_ON_YOU", NpcKillCondition.Kill(reqs, true, NPCID.EyeofCthulhu), AchievementCategory.Slayer);

            RegisterAchievement($"{id}_SMASHING_POPPET", FlagProgressionCondition.Set(reqs, AchievementHelperID.Events.SmashShadowOrb), AchievementCategory.Explorer);

            RegisterAchievement($"{id}_WHERES_MY_HONEY", FlagSpecialCondition.Set(reqs, AchievementHelperID.Special.FoundBeeHive), AchievementCategory.Explorer);

            RegisterAchievement($"{id}_STING_OPERATION", NpcKillCondition.Kill(reqs, true, NPCID.QueenBee), AchievementCategory.Slayer);

            RegisterAchievement($"{id}_BONED", NpcKillCondition.Kill(reqs, true, NPCID.SkeletronHead), AchievementCategory.Slayer);

            List<CustomAchievementCondition> dhConds = [];
            dhConds.Add(ItemGrabCondition.Grab(reqs, ItemID.GoldenKey));
            dhConds.Add(FlagProgressionCondition.Set(reqs, AchievementHelperID.Events.UnlockedGoldenChest));
            RegisterAchievement($"{id}_DUNGEON_HEIST", dhConds, false, AchievementCategory.Explorer);

            RegisterAchievement($"{id}_ITS_GETTING_HOT_IN_HERE", FlagSpecialCondition.Set(reqs, AchievementHelperID.Special.FoundHell), AchievementCategory.Explorer);

            RegisterAchievement($"{id}_MINER_FOR_FIRE", ItemCraftCondition.Craft(reqs, ItemID.MoltenPickaxe), AchievementCategory.Collector);

            RegisterAchievement($"{id}_STILL_HUNGRY", NpcKillCondition.KillAny(reqs, true, [NPCID.WallofFlesh, NPCID.WallofFleshEye]), AchievementCategory.Slayer);

            RegisterAchievement($"{id}_ITS_HARD", FlagProgressionCondition.Set(reqs, AchievementHelperID.Events.StartHardmode), AchievementCategory.Explorer);

            RegisterAchievement($"{id}_BEGONE_EVIL", FlagProgressionCondition.Set(reqs, AchievementHelperID.Events.SmashDemonAltar), AchievementCategory.Explorer);

            int[] hardmodeOre = [107, 108, 111, 221, 222, 223];
            RegisterAchievement($"{id}_EXTRA_SHINY", TileDestroyCondition.DestroyAny(reqs, hardmodeOre), AchievementCategory.Explorer);

            RegisterAchievement($"{id}_HEAD_IN_THE_CLOUDS", ItemEquipCondition.Equip(reqs, AchievementData.ItemSlotContextID.EquipWings, ItemID.None), AchievementCategory.Collector);

            List<CustomAchievementCondition> bbConds = [];
            bbConds.Add(NpcKillCondition.KillAny(reqs, false, [NPCID.Retinazer, NPCID.Spazmatism]));
            bbConds.AddRange(NpcKillCondition.KillAll(reqs, false, [NPCID.TheDestroyer, NPCID.SkeletronPrime]));
            RegisterAchievement($"{id}_BUCKETS_OF_BOLTS", bbConds, true, AchievementCategory.Slayer);

            RegisterAchievement($"{id}_DRAX_ATTAX", ItemCraftCondition.CraftAny(reqs, [ItemID.Drax, ItemID.PickaxeAxe]), AchievementCategory.Collector);

            RegisterAchievement($"{id}_PHOTOSYNTHESIS", TileDestroyCondition.Destroy(reqs, TileID.Chlorophyte), AchievementCategory.Explorer);

            RegisterAchievement($"{id}_GET_A_LIFE", FlagSpecialCondition.Set(reqs, AchievementHelperID.Special.ConsumeFruit), AchievementCategory.Explorer);

            RegisterAchievement($"{id}_THE_GREAT_SOUTHERN_PLANTKILL", NpcKillCondition.Kill(reqs, true, NPCID.Plantera), AchievementCategory.Slayer);

            RegisterAchievement($"{id}_TEMPLE_RAIDER", FlagProgressionCondition.Set(reqs, AchievementHelperID.Events.TempleRaider), AchievementCategory.Collector);

            RegisterAchievement($"{id}_LIHZAHRDIAN_IDOL", NpcKillCondition.Kill(reqs, true, NPCID.Golem), AchievementCategory.Slayer);

            int[] dungeonItems = [1513, 938, 963, 977, 1300, 1254, 1514, 679, 759, 1446, 1445, 1444, 1183, 1266, 671, 3291, 4679];
            RegisterAchievement($"{id}_ROBBING_THE_GRAVE", ItemGrabCondition.GrabAny(reqs, dungeonItems), AchievementCategory.Explorer);

            RegisterAchievement($"{id}_OBSESSIVE_DEVOTION", NpcKillCondition.Kill(reqs, true, NPCID.CultistBoss), AchievementCategory.Slayer);

            RegisterAchievement($"{id}_STAR_DESTROYER", NpcKillCondition.KillAll(reqs, true, [NPCID.LunarTowerNebula, NPCID.LunarTowerSolar, NPCID.LunarTowerStardust, NPCID.LunarTowerVortex]), true, AchievementCategory.Slayer);

            RegisterAchievement($"{id}_CHAMPION_OF_TERRARIA", NpcKillCondition.Kill(reqs, true, NPCID.MoonLordCore), AchievementCategory.Slayer);
        }
    }
}
