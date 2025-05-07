using UnityEngine;

public class ClothesShopNPC: NPCInteraction
{
    public override void StartInteraction()
    {
        base.StartInteraction();
        Debug.Log("Interactue con el ShopKeeper");
    }

    public override void EndInteraction()
    {
        base.EndInteraction();
        Debug.Log("Deje de Interactuar con el ShopKeeper");

    }
}
