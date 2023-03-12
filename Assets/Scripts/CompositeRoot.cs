using UnityEngine;

public class CompositeRoot : MonoBehaviour
{
    public int GetCountOfCoins()
    {
        return PlayerPrefs.GetInt("Coins", 0);
    }

    public void SetCountOfCoins(int amount)
    {
        PlayerPrefs.SetInt("Coins", amount);
    }
}
