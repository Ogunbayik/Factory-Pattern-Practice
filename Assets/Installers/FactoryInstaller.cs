using UnityEngine;
using Zenject;

public class FactoryInstaller : MonoInstaller
{
    [SerializeField] private GameObject _fireball;
    [SerializeField] private GameObject _iceball;
    [SerializeField] private GameObject _lightningball;
    public override void InstallBindings()
    {
        Container.BindFactory<FireSpell, FireSpell.Factory>()
            .FromComponentInNewPrefab(_fireball);
        Container.BindFactory<IceSpell, IceSpell.Factory>()
            .FromComponentInNewPrefab(_iceball);
        Container.BindFactory<LightningSpell, LightningSpell.Factory>()
            .FromComponentInNewPrefab(_lightningball);

        Container.Bind<SpellFactory>().AsSingle();
    }
}