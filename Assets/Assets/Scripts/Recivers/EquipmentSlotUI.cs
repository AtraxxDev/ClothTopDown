using UnityEngine;
using UnityEngine.UI;
using System;

public class EquipmentSlotUI : MonoBehaviour
{
    [SerializeField] private ItemType slotType;
    [SerializeField] private Image icon;
    [SerializeField] private Button button;

    private Action<ItemType> onSlotClicked;

    public void Initialize(ItemData item, Action<ItemType> onClick)
    {
        onSlotClicked = onClick;
        SetItem(item);
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(() => onSlotClicked?.Invoke(slotType));
    }

    public void SetItem(ItemData item)
    {
        if (item != null && item.icon != null)
        {
            icon.sprite = item.icon;
            icon.enabled = true;
        }
        else
        {
            icon.sprite = null;
            icon.enabled = false;
        }
    }

    public ItemType GetSlotType() => slotType;
}
