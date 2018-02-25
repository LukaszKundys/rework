using DoozyUI;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class HUDMapButton : MonoBehaviour
{
    private PlayerPreferencesManager _playerPreferencesManager;

    private Image _image;
    private UIButton _button;

    public BattleSceneData Data;

    [Inject]
    private void Construct(PlayerPreferencesManager playerPreferencesManager)
    {
        _playerPreferencesManager = playerPreferencesManager;
    }

    private void Awake()
    {
        _image = GetComponentInChildren<Image>();
        _button = GetComponentInChildren<UIButton>();
        
        _button.OnPointerEnter.AddListener(OnPointerEnter);
        _button.OnPointerExit.AddListener(OnPointerExit);
        
        _button.OnClick.AddListener(OnClick);
    }

    private void OnPointerExit()
    {
        _image.color = Color.white;
    }

    private void OnPointerEnter()
    {
        _image.color = Color.blue;
    }

    private void OnDestroy()
    {
        _button.OnPointerEnter.RemoveAllListeners();
        _button.OnPointerExit.RemoveAllListeners();
        _button.OnClick.RemoveAllListeners();
    }

    public void OnClick()
    {
        UINotification notification = UIManager.ShowNotification("BattleSceneDetails", -1, false);
        notification.GetComponent<HUDBattleSceneDetails>().SetData(_playerPreferencesManager, Data);
    }
}
