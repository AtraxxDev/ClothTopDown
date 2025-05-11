using UnityEngine;

public class PlayerApparence : MonoBehaviour
{
    [SerializeField] private EquipmentSystem equipment;
    [SerializeField] private SpriteRenderer hatRenderer;
    [SerializeField] private SpriteRenderer hairRenderer;
    [SerializeField] private SpriteRenderer glassesRenderer;
    [SerializeField] private SpriteRenderer shirtRenderer;
    [SerializeField] private SpriteRenderer scarfRenderer;
    [SerializeField] private SpriteRenderer weaponRenderer;

    private void OnEnable()
    {
        equipment.OnItemEquipped += UpdateVisual;
    }

    private void OnDisable()
    {
        equipment.OnItemEquipped -= UpdateVisual;
    }

    private void UpdateVisual(ItemData item)
    {
        switch (item.type)
        {
            case ItemType.Hat: hatRenderer.sprite = item.spriteVisual; break;
            case ItemType.Hair: hairRenderer.sprite = item.spriteVisual; break;
            case ItemType.Glasses: glassesRenderer.sprite = item.spriteVisual; break;
            case ItemType.Shirt: shirtRenderer.sprite = item.spriteVisual; break;
            case ItemType.Scarf: scarfRenderer.sprite = item.spriteVisual; break;
            case ItemType.Weapon: weaponRenderer.sprite = item.spriteVisual; break;
        }
    }
}
