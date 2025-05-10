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
    public string itemId; // �nico: "hat_01", "shirt_02"
    public string displayName;
    public Sprite icon;         // �cono del inventario
    public ItemType type;
    public Sprite spriteVisual; // El sprite que se asignar� al SpriteRenderer del personaje
}
