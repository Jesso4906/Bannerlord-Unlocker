// this is added to the top of the Tick method in the SteamAchievementService class. 
// the hasUnlockered boolean must be created.

if (!this.hasUnlockered)
{
	for (uint i = 0U; i < SteamUserStats.GetNumAchievements(); i += 1U)
	{
		SteamUserStats.SetAchievement(SteamUserStats.GetAchievementName(i));
	}
	
	this.hasUnlockered = true;
}