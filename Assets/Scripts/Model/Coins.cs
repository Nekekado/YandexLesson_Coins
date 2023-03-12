using System;
using UnityEngine;

public class Coins
{
    private int _amount;

    public int Amount => _amount;
    public event Action CoinsChanged;

    public Coins(int count)
    {
        _amount = count;
    }

    public void OnPickupCoin()
    {
        _amount++;
        CoinsChanged?.Invoke();
    }

    public bool TryDiscard(int price)
    {
        if (_amount < price)
            return false;

        _amount -= price;

        CoinsChanged?.Invoke();

        return true;
    }
}
