using TMPro;
using UnityEngine;

public class CoinsUI : MonoBehaviour
{
    [SerializeField] private CoinManager coinManager;
    [SerializeField] private TMP_Text coinText;

    private void OnEnable()
    {
        coinManager.OnCoinsChanged += UpdateUI;
        UpdateUI(coinManager.CurrentCoins);
    }

    private void OnDisable()
    {
        coinManager.OnCoinsChanged -= UpdateUI;
    }

    private void UpdateUI(int newAmount)
    {
        coinText.text = newAmount.ToString();
    }
}
