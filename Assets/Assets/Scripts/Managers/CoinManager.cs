using UnityEngine;
using System;

public class CoinManager : MonoBehaviour
{
    public event Action<int> OnCoinsChanged;

    [SerializeField] private int currentCoins;
    public int CurrentCoins => currentCoins;

    public bool HasEnough(int amount) => currentCoins >= amount;

    public void Spend(int amount)
    {
        if (HasEnough(amount))
        {
            currentCoins -= amount;
            OnCoinsChanged?.Invoke(currentCoins);
        }
    }

    public void Add(int amount)
    {
        currentCoins += amount;
        OnCoinsChanged?.Invoke(currentCoins);
    }
}
