using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField]
    private CustomList ListOfItems;
    [SerializeField]
    private MoneyPool _MoneyPool;    
    [SerializeField]
    private MessageSystem _MessageSystem;

    private ProductItem ItemToPurchase;

    private const string NOT_ENOUGH_MONEY = "Not enough money!";

    private const string SUBMIT_PURCHASE = "Submit purchase?";

    public static Shop Instance = null;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance == this)
        {
            Destroy(gameObject);
        }
    }

    public void OnBuyClick(ProductItem item)
    {
        TryToBuy(item);
    }
    public void TryToBuy(ProductItem item)
    {
        int price = item.GetPrice();
        if (price == 0)
        {
            ListOfItems.RemoveItem(item);
            return;
        }
        if (!_MoneyPool.CanProceed(price))
        {
            _MessageSystem.ShowMessage(NOT_ENOUGH_MONEY);
            return;
        }
        ItemToPurchase = item;
        _MessageSystem.OnCloseMessage += OnCloseMessage;
        _MessageSystem.ShowMessage(SUBMIT_PURCHASE, true);
    }

    private void OnCloseMessage(bool result)
    {
        _MessageSystem.OnCloseMessage -= OnCloseMessage;
        if (result)
        {
            _MoneyPool.Proceed(ItemToPurchase.GetPrice());
            ListOfItems.RemoveItem(ItemToPurchase);
        }
        ItemToPurchase = null;
    }
}
