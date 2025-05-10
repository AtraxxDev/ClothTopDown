using UnityEngine;
using UnityEngine.UI;
using System;

public class InventorySlotUI : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Button btn;

    private ItemData currentItem;
    private Action<ItemData> onClickCallback;

    public void Initialize(ItemData item, Action<ItemData> onClick)
    {
        currentItem = item;
        icon.sprite = item.icon;
        onClickCallback = onClick;

        btn.onClick.RemoveAllListeners();
        btn.onClick.AddListener(() => onClickCallback?.Invoke(currentItem));
    }

    public void Clear()
    {
        currentItem = null;
        icon.sprite = null;
        btn.onClick.RemoveAllListeners();
    }
}
