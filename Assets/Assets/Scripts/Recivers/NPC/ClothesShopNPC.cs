using UnityEngine;

public class ClothesShopNPC : NPCInteraction
{
    [SerializeField] private ShopSystem shopSystem;
    [SerializeField] private GameObject shopUIPanel;
    [SerializeField] private ShopChoicePanel choicePanel;


    public override void StartInteraction()
    {
        base.StartInteraction();
        shopUIPanel.SetActive(true);
        choicePanel.OpenChoice(shopSystem);
    }

    public override void EndInteraction()
    {
        base.EndInteraction();
        shopUIPanel.SetActive(false);

    }
}
