using System;
using UnityEngine;
using Zenject;

public class CompositeRoot : MonoBehaviour
{
    [Inject] private Coins _coins;

    private void Awake()
    {
        _coins.CoinsChanged += SetCountOfCoins;
    }

    public int GetCountOfCoins()
    {
        return PlayerPrefs.GetInt("Coins", 0);
    }

    public void SetCountOfCoins()
    {
        PlayerPrefs.SetInt("Coins", _coins.Amount);
    }
}
