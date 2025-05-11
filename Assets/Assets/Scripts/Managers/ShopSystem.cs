using UnityEngine;
using System.Collections.Generic;


public class ShopSystem : MonoBehaviour
{
    [SerializeField] private List<ItemData> itemsForSale = new();
    public string ShopName;

    public IReadOnlyList<ItemData> Items => itemsForSale;
}
