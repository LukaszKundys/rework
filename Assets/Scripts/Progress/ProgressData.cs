using System.Collections.Generic;

[System.Serializable]
public class ProgressData
{
    public List<LevelData> LevelsData = new List<LevelData>();

    public LevelData GetLevelDataById(BattleScenesManager.SceneName sceneName)
    {
        return LevelsData.Find(level => level.SceneName == sceneName);
    }
}