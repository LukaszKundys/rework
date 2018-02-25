using SmartLocalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class HUDBattleSceneDetails : MonoBehaviour
{
    private const string _objectivesLabelLocId = "HUD_objectivesLabel";
    private const string _questsLabelLocId = "HUD_questsLabel";
    private const string _acceptButtonLabelLocId = "HUD_acceptButtonLabel";
    private const string _cancelButtonLabelLocId = "HUD_cancelButtonLabel";

    public GameObject ObjectivePrefab;

    public TextMeshProUGUI Title;
    public Image Thumbnail;
    public Transform ObjectivesContainer;
    public TextMeshProUGUI ObjectivesLabel;
    public TextMeshProUGUI QuestsLabel;
    public TextMeshProUGUI AcceptButtonLabel;
    public TextMeshProUGUI CancelButtonLabel;

    private BattleSceneData sceneData;
    
    public void SetData(PlayerPreferencesManager playerPreferencesManager, BattleSceneData data)
    {
        sceneData = data;
        Title.text = data.SceneTitle;
        Thumbnail.sprite = data.SceneThumbnail;

        int objectivesAmount = data.Objectives.Count;
        int questsAmount = data.Quests.Count;

        ObjectivesLabel.text = LanguageManager.Instance.GetTextValue(_objectivesLabelLocId);

        ProgressData progressData = playerPreferencesManager.LoadProgressData();

        for (int i = 0; i < objectivesAmount; i++)
        {
            GameObject objective = GameObject.Instantiate(ObjectivePrefab);
            objective.transform.SetParent(ObjectivesContainer);
            objective.transform.localScale = Vector3.one;
            objective.transform.SetSiblingIndex(i + 1);
            objective.GetComponent<HUDBattleSceneObjective>().Label.text = data.GetObjectiveById(i).Name;
            objective.GetComponent<HUDBattleSceneObjective>().SetToggle(progressData.GetLevelDataById(data.TargetSceneName).GetObjectiveById(i).Completed);
        }

        QuestsLabel.text = LanguageManager.Instance.GetTextValue(_questsLabelLocId);

        for (int i = 0; i < questsAmount; i++)
        {
            GameObject quest = GameObject.Instantiate(ObjectivePrefab);
            quest.transform.SetParent(ObjectivesContainer);
            quest.transform.localScale = Vector3.one;
            quest.transform.SetSiblingIndex(i + objectivesAmount + 2);
            quest.GetComponent<HUDBattleSceneObjective>().Label.text = data.GetQuestById(i).Name;
            quest.GetComponent<HUDBattleSceneObjective>().SetToggle(progressData.GetLevelDataById(data.TargetSceneName).GetQuestById(i).Completed);
        }

        AcceptButtonLabel.text = LanguageManager.Instance.GetTextValue(_acceptButtonLabelLocId);
        CancelButtonLabel.text = LanguageManager.Instance.GetTextValue(_cancelButtonLabelLocId);

        //AcceptButtonLabel.GetComponentInParent<UIButton>().OnClick.AddListener(OnAcceptClicked);
        //CancelButtonLabel.GetComponentInParent<UIButton>().OnClick.AddListener(OnCancelClicked);

        //if (data.MapConversation != null)
        //    Card._Common._ConversationsManager.StartConversation(data.MapConversation);
    }

    private void OnAcceptClicked()
    {
        //if (Card._Common._ConversationsManager.CurrentConversation != null)
        //    Card._Common._ConversationsManager.ClearCurrentConversation();

        //GetComponent<UINotification>().HideNotification(false);
        //Card._Common._TimeManager.WaitSomeTime(0.5f, LoadScene);
    }

    private void OnCancelClicked()
    {
        //if (Card._Common._ConversationsManager.CurrentConversation != null)
        //    Card._Common._ConversationsManager.ClearCurrentConversation();
    }

    private void LoadScene()
    {
        //GameObject loadingScreen = Card._Common._ResourcesManager.LoadAndInstantiatePrefab("UI", "LoadingScreen", UIManager.GetMasterCanvas().gameObject.transform);
        //Card._Common._SceneManager._ChangeScene(sceneData.TargetScene, new BattleInitData(sceneData), true, loadingScreen.GetComponent<LoadingScreen>());
    }
}