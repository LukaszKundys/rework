using UnityEngine;
using Zenject;

public class MapManager : MonoBehaviour
{
    private PlayerPreferencesManager _playerPreferencesManager;
    private ProgressData _progressData;

    [Inject]
    private void Construct(PlayerPreferencesManager playerPreferencesManager)
    {
        _playerPreferencesManager = playerPreferencesManager;
    }

    private void Start()
    {
        _progressData = _playerPreferencesManager.LoadProgressData();


    }
}
