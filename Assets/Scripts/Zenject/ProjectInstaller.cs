using SmartLocalization;
using Zenject;

public class ProjectInstaller : MonoInstaller<ProjectInstaller>
{
    public override void InstallBindings()
    {
        //Container.BindInstance<LanguageManager>(FindObjectOfType<LanguageManager>()).AsSingle();
    }
}
