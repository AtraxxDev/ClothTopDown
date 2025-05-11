using UnityEngine;

public class InventoryInput : MonoBehaviour
{
    [SerializeField] private GameObject inventoryPanel;

    private bool isOpen = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ToggleInventory();
        }
    }

    private void ToggleInventory()
    {
        isOpen = !isOpen;
        inventoryPanel.SetActive(isOpen);
    }
}
