using UnityEngine;

public class ShopChoicePanel : MonoBehaviour
{
    [SerializeField] private GameObject shopUI;
    [SerializeField] private GameObject sellUI;

    private ShopSystem currentShop;

    public void OpenChoice(ShopSystem shop)
    {
        currentShop = shop;
    }

    public void OnBuyClicked()
    {
        gameObject.SetActive(false);
        shopUI.SetActive(true);
        shopUI.GetComponent<ShopUI>().OpenShop(currentShop);
    }

    public void OnSellClicked()
    {
        gameObject.SetActive(false);
        sellUI.SetActive(true);
        sellUI.GetComponent<SellUI>().OpenSell();
    }
}
