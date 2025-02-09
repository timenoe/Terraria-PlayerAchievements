using System;
using System.IO;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;

namespace PlayerAchievements.Systems
{
    /// <summary>
    /// System to enforce rules
    /// </summary>
    public class RuleSystem : ModSystem
    {
        /// <summary>
        /// File to store Hardcore player deaths
        /// </summary>
        public static string HardcoreDeathFilePath => $"{ModLoader.ModPath}/PlayerAchievements.nbt";


        public override bool CanWorldBePlayed(PlayerFileData playerData, WorldFileData worldFileData)
        {
            if (HasDiedHardcore(playerData))
                return false;

            return true;
        }

        public override string WorldCanBePlayedRejectionMessage(PlayerFileData playerData, WorldFileData worldData) => "PlayerAchievements: This Hardcore player has previously died";

        /// <summary>
        /// Checks if a Hardcore player has died before
        /// </summary>
        /// <param name="playerData">Player file data</param>
        /// <returns>True if the player has died before</returns>
        private static bool HasDiedHardcore(PlayerFileData playerData)
        {
            if (!FileUtilities.Exists(HardcoreDeathFilePath, false))
                return false;

            TagCompound tag = TagIO.FromFile(HardcoreDeathFilePath);
            if (tag == null)
                return false;

            try
            {
                bool died = tag.GetBool(playerData.Player.name);
                if (!died)
                    return false;
                
                // Remove death tag if player was deleted and created again
                if (playerData.GetPlayTime() == TimeSpan.Zero)
                {
                    tag.Remove(playerData.Player.name);
                    TagIO.ToFile(tag, HardcoreDeathFilePath);
                    
                    return false;
                }

                return true;
            }

            // Will throw exception is the key type exists but is not a bool
            // Can only happen if the file has been tampered with
            catch (IOException)
            {
                return false;
            }
        }
    }
}
