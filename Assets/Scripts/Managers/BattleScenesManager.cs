using System.Collections.Generic;
using UnityEngine;

public class BattleScenesManager : MonoBehaviour
{
    public enum SceneName { Tutorial01, Tutorial02, Tutorial03 }

    private List<BattleSceneData> battleScenesDataFiles;

    private void Awake()
    {
        BattleSceneData[] allFiles = Resources.FindObjectsOfTypeAll<BattleSceneData>();
        battleScenesDataFiles = new List<BattleSceneData>(allFiles);
    }

    public BattleSceneData GetBattleSceneDataById(SceneName sceneName)
    {
        return battleScenesDataFiles.Find(data => data.TargetSceneName == sceneName);
    }
}