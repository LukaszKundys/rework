using SmartLocalization;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BattleSceneData", menuName = "Config Files/Add BattleSceneData file")]
public class BattleSceneData : ScriptableObject
{
    [Header("Identyfikator sceny")]
    public BattleScenesManager.SceneName TargetSceneName;
    [Header("Kod lokalizacji tekstu")]
    public string SceneTitleLocId;
    [Header("Miniatura sceny")]
    public Sprite SceneThumbnail;
    //[Header("Scena bitwy")]
    //public CustomSceneManager.ESceneName TargetScene;
    //[Header("Zablokowane pola")]
    //public List<BoardCoords> BlockedBoardFields = new List<BoardCoords>();
    [Header("Cele misji")]
    public List<ObjectiveData> Objectives = new List<ObjectiveData>();
    [Header("Zadania poboczne")]
    public List<ObjectiveData> Quests = new List<ObjectiveData>();
    //[Header("Rodzaj AI")]
    //public AIManager.EAIType AIType;
    //[Header("Konwersacja na scenie mapy")]
    //public Conversation MapConversation;
    //[Header("Rozmowa przed bitwą")]
    //public Conversation BattleConversation;
    //[Header("Przebieg wydarzeń w poszczególnych turach")]
    //public List<TurnData> Turns = new List<TurnData>();

    #region Properties
    public string SceneTitle { get { return LanguageManager.Instance.GetTextValue(SceneTitleLocId); } }
    #endregion

    public ObjectiveData GetObjectiveById(int id)
    {
        return Objectives[id];
    }

    public ObjectiveData GetQuestById(int id)
    {
        return Quests[id];
    }
}
