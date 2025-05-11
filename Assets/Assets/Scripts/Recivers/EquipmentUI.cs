using UnityEngine;

public class EquipmentUI : MonoBehaviour
{
    [SerializeField] private InventoryUI inventoryUI;
    [SerializeField] private EquipmentSystem equipmentSystem;
    [SerializeField] private InventorySystem inventorySystem;
    [SerializeField] private EquipmentSlotUI[] slotUIs;


    private void OnEnable()
    {
        equipmentSystem.OnItemEquipped += UpdateSlot;
        RefreshAll();
    }

    private void OnDisable()
    {
        equipmentSystem.OnItemEquipped -= UpdateSlot;
    }

    private void Start()
    {
        foreach (var slot in slotUIs)
        {
            slot.Initialize(equipmentSystem.GetEquippedItem(slot.GetSlotType()), OnSlotClicked);
        }
    }

    private void UpdateSlot(ItemData item)
    {
        foreach (var slot in slotUIs)
        {
            if (slot.GetSlotType() == item.type)
            {
                slot.SetItem(item);
                break;
            }
        }
    }

    private void OnSlotClicked(ItemType type)
    {
        ItemData equippedItem = equipmentSystem.GetEquippedItem(type);
        if (equippedItem != null)
        {
            equipmentSystem.UnequipItem(type);           // Desequipa
            inventorySystem.AddItem(equippedItem);       // Lo regresa al inventario
            RefreshAll();                               
            inventoryUI.Refresh();
        }
    }

    public void RefreshAll()
    {
        foreach (var slot in slotUIs)
        {
            var equipped = equipmentSystem.GetEquippedItem(slot.GetSlotType());
            slot.SetItem(equipped);
        }
    }
}
