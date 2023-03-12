using System;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] private CompositeRoot _compositeRoot;//

    private int _amount;

    public int Amount => _amount;
    public event Action CoinUpped;

    public Coins(int count)
    {
        _amount = count;
    }

    public void OnPickupCoin()
    {
        _amount++;
        _compositeRoot.SetCountOfCoins(_amount);//
    }

    public bool TryDiscard(int price)
    {
        if (_amount < price)
            return false;

        _amount -= price;

        _compositeRoot.SetCountOfCoins(_amount);//
        PlayerPrefs.SetInt("Coins", _amount);//

        return true;
    }
}
