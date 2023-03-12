using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CoinInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Coins>().To<Coins>().FromInstance(new Coins(PlayerPrefs.GetInt("Coins", 0)));
    }
}
