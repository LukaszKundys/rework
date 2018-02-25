using UnityEngine;
using Zenject;

public class MapInstaller :  MonoInstaller<MapInstaller>
{
    [SerializeField]
    private BattleScenesManager _battleScenesManager;
    [SerializeField]
    private MapManager _mapManager;
    [SerializeField]
    private PlayerPreferencesManager _playerPreferencesManager;

    public override void InstallBindings()
    {
        Container.BindInstance(_battleScenesManager).AsSingle();
        Container.BindInstance(_mapManager).AsSingle();
        Container.BindInstance(_playerPreferencesManager).AsSingle();
    }
}
