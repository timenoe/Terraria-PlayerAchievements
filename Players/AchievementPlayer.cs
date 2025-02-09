using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using PlayerAchievements.Systems;

namespace PlayerAchievements.Players
{
    /// <summary>
    /// Player to save custom data
    /// </summary>
    public class AchievementPlayer : ModPlayer
    {
        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            if (Player.difficulty == PlayerDifficultyID.Hardcore)
            {
                TagCompound tag = new()
                {
                    [Player.name] = true
                };
                TagIO.ToFile(tag, RuleSystem.HardcoreDeathFilePath);
            }
        }
    }
}