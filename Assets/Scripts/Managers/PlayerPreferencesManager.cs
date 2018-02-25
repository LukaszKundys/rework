using System.IO;
using UnityEngine;
using Zenject;

public class PlayerPreferencesManager : MonoBehaviour
{
    #region References
    private BattleScenesManager _battleScenesManager;
    #endregion

    private string pathToSaveFile;

    [Inject]
    private void Construct(BattleScenesManager battleScenesManager)
    {
        _battleScenesManager = battleScenesManager;
    }

    private void Awake()
    {
        pathToSaveFile = Application.streamingAssetsPath + "/save.json";

        if (!File.Exists(pathToSaveFile))
        {
            ProgressData save = new ProgressData();

            BattleSceneData sceneData = _battleScenesManager.GetBattleSceneDataById(BattleScenesManager.SceneName.Tutorial01);

            LevelData levelData = new LevelData();
            levelData.SceneName = sceneData.TargetSceneName;

            foreach (ObjectiveData objective in sceneData.Objectives)
                levelData.Objectives.Add(objective);

            foreach (ObjectiveData quest in sceneData.Quests)
                levelData.Quests.Add(quest);

            save.LevelsData.Add(levelData);

            string savedJson = JsonUtility.ToJson(save);

            File.WriteAllText(pathToSaveFile, savedJson);
        }
    }

    public ProgressData LoadProgressData()
    {
        return JsonUtility.FromJson<ProgressData>(File.ReadAllText(pathToSaveFile));
    }
}
