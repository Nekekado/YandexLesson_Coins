using System;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private CompositeRoot _compositeRoot;
    [SerializeField] private Text _countOfCoins;

    private void Update()
    {
        _countOfCoins.text = _compositeRoot.GetCountOfCoins().ToString();
    }
}
