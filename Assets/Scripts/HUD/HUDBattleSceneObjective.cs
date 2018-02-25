using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDBattleSceneObjective : MonoBehaviour
{
    public TextMeshProUGUI Label { get; private set; }
    public Toggle Checker { get; private set; }

    private void Awake()
    {
        Label = GetComponentInChildren<TextMeshProUGUI>();
        Checker = GetComponentInChildren<Toggle>();
    }

    public void SetToggle(bool value)
    {
        Checker.isOn = value;
    }
}
