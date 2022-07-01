using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ContentBase 
{
    public int Price;
    public virtual void Init(ProductItem contentView, int index) 
    {
        contentView.SetPrice(Price);
        contentView.SetNumber(index);
        contentView.SetContent(this);
    }
    public virtual int GetPrice()
    {
        return Price;
    }
}
