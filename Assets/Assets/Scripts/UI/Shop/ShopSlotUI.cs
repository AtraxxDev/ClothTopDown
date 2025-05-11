using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ShopSlotUI : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private Button buyButton;

    private ItemData currentItem;
    private Action<ItemData> onBuy;

    public void Initialize(ItemData item, Action<ItemData> onBuyCallback)
    {
        currentItem = item;
        icon.sprite = item.icon;
        priceText.text = item.buyPrice.ToString();
        onBuy = onBuyCallback;

        buyButton.onClick.RemoveAllListeners();
        buyButton.onClick.AddListener(() => onBuy?.Invoke(currentItem));
    }

    public void Clear()
    {
        icon.sprite = null;
        priceText.text = "";
        buyButton.onClick.RemoveAllListeners();
    }
}
