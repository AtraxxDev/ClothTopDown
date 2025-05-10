using UnityEngine;

public enum ItemType
{
    Hat,
    Glasses,
    Shirt,
    Scarf,
    Weapon
}

[CreateAssetMenu(fileName = "New Item", menuName = "Items/ItemData")]
public class ItemData : ScriptableObject
{
    public string itemId;
    public string displayName;
    public ItemType type;
    public Sprite icon;
    public Sprite spriteVisual;
    public int buyPrice;
    public int sellPrice;
}
