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
    public string itemId; // único: "hat_01", "shirt_02"
    public string displayName;
    public Sprite icon;         // Ícono del inventario
    public ItemType type;
    public Sprite spriteVisual; // El sprite que se asignará al SpriteRenderer del personaje
}
