using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProductItem : MonoBehaviour
{
    public event Action<ProductItem> OnTryToBuy;
    [SerializeField]
    protected Transform _Parent;
    [SerializeField]
    private TextMeshProUGUI _Price;
    [SerializeField]
    private TextMeshProUGUI _Number;
    [SerializeField]
    private Button _BuyButton;
    [SerializeField]
    private Image _Background;
    [SerializeField]
    private Color _Even;
    [SerializeField]
    private Color _Odd;

    private ContentBase _Content;

    public void SetContent(ContentBase content)
    {
        _Content = content;
    }
    public ContentBase GetContent()
    {
        return _Content;
    }
    public void ApplySprites(List<Sprite> spriteContents)
    {
        foreach (var sprite in spriteContents)
        {
            var instance = Instantiate(Resources.Load("SpritePrefab") as GameObject, _Parent);
            instance.GetComponent<Image>().sprite = sprite;
        }
    }
    public void ApplyStrings(List<string> stringContents)
    {
        foreach (var stringContent in stringContents)
        {
            var instance = Instantiate(Resources.Load("TextPrefab") as GameObject, _Parent);
            instance.GetComponent<TextMeshProUGUI>().text = stringContent;
        }
    }
    public void ApplyMoney(int intContent)
    {
        var _Moneytext = Instantiate(Resources.Load("TextPrefab") as GameObject, _Parent).GetComponent<TextMeshProUGUI>();
        _Moneytext.text = intContent.ToString() + "$";
    }

    public void SetPrice(int price)
    {
        if (price == 0)
        {
            _Price.text = "FREE";
            return;
        }
        _Price.text = price.ToString() + "$";
    }

    public void SetNumber(int index)
    {
        ChangeColor(index);
        _Number.text = (index + 1).ToString();
    }
    public void OnBuyClick()
    {
        OnTryToBuy?.Invoke(this);
    }
    public virtual int GetPrice()
    {
        //if (int.TryParse(_Price.text.Replace("$", String.Empty), out int result))
        //{
        //    return result;
        //}
        //return 0;
        return _Content.GetPrice();
    }

    private void ChangeColor(int index)
    {
        if (index % 2 == 0)
        {
            _Background.color = _Even;
        }
        else
        {
            _Background.color = _Odd;
        }
    }
}
