using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    private ShopSystem currentShop;

    [SerializeField] private InventorySystem playerInventory;
    [SerializeField] private CoinManager coinManager;
    [SerializeField] private List<ShopSlotUI> slotUIs;
    [SerializeField] private TMP_Text shopName;

    public void OpenShop(ShopSystem shopToUse)
    {
        currentShop = shopToUse;
        shopName.text = shopToUse.ShopName.ToString();
        Refresh();
    }

    public void CloseShop()
    {
        currentShop = null;
    }

    private void Refresh()
    {
        if (currentShop == null) return;

        for (int i = 0; i < slotUIs.Count; i++)
        {
            if (i < currentShop.Items.Count)
            {
                var item = currentShop.Items[i];
                slotUIs[i].Initialize(item, OnBuyClicked);
                slotUIs[i].gameObject.SetActive(true);
            }
            else
            {
                slotUIs[i].Clear();
            }
        }
    }

    private void OnBuyClicked(ItemData item)
    {
        if (!coinManager.HasEnough(item.buyPrice))
        {
            Debug.Log("No tienes suficiente oro.");
            return;
        }

        if (!playerInventory.AddItem(item))
        {
            Debug.Log("Inventario lleno.");
            return;
        }

        coinManager.Spend(item.buyPrice);
        Debug.Log($"Compraste: {item.displayName}");
    }


}
