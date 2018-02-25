using System.Collections.Generic;

[System.Serializable]
public class LevelData
{
    public BattleScenesManager.SceneName SceneName;
    public List<ObjectiveData> Objectives = new List<ObjectiveData>();
    public List<ObjectiveData> Quests = new List<ObjectiveData>();

    public ObjectiveData GetObjectiveById(int id)
    {
        return Objectives[id];
    }

    public ObjectiveData GetQuestById(int id)
    {
        return Quests[id];
    }
}
