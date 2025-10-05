using Terraria;
using TerrariaAchievementLib.Achievements;
using TerrariaAchievementLib.Players;
using TerrariaAchievementLib.Systems;

namespace PlayerAchievements.Systems
{
    /// <summary>
    /// Creates a helper AchievementSystem instance
    /// </summary>
    public class PlayerAchievementSystem : AchievementSystem
    {
        public override void OnModLoad()
        {
            if (Main.dedServ)
                return;

            base.OnModLoad();
            AchievementProgression.Enable(ProgressionRestriction.Player);
            HardestcorePlayer.Enable();
        }
    }
}
