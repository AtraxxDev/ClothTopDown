using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class SellSlotUI : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private Button sellButton;

    private ItemData currentItem;
    private Action<ItemData> onSell;

    public void Initialize(ItemData item, Action<ItemData> onSellCallback)
    {
        currentItem = item;
        icon.sprite = item.icon;
        priceText.text = item.sellPrice.ToString();
        onSell = onSellCallback;

        sellButton.onClick.RemoveAllListeners();
        sellButton.onClick.AddListener(() => onSell?.Invoke(currentItem));
    }

    public void Clear()
    {
        icon.sprite = null;
        priceText.text = "";
        sellButton.onClick.RemoveAllListeners();
    }
}
