using SmartLocalization;
using UnityEngine;

[System.Serializable]
public class ObjectiveData
{
    public string NameLocId;
    [HideInInspector]
    public bool Completed = false;

    public string Name { get { return LanguageManager.Instance.GetTextValue(NameLocId); } }
}