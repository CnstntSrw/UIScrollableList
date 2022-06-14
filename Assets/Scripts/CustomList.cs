using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class CustomList : MonoBehaviour
{
    [SerializeField]
    private Transform ContentParent;

	[SerializeField]
    public ProductItem ItemPrefab;

    [SerializeField]
    public MessageSystem MessageSystem;

    [SerializeReference, SerializeReferenceButton]
    public List<ContentBase> Contents = new List<ContentBase>();

    private List<ProductItem> _Items = new List<ProductItem>();

    private void Awake()
    {
        foreach (var content in Contents)
        {
            if (content != null)
            {
                var item = Instantiate(ItemPrefab, ContentParent);
                content.Init(item, Contents.IndexOf(content));
                item.OnTryToBuy += Shop.Instance.TryToBuy;
                _Items.Add(item);
            }
        }
    }

    public void RemoveItem(ProductItem item)
    {
        _Items.Remove(item);
        Destroy(item.gameObject);
        foreach (var productItem in _Items)
        {
            productItem.SetNumber(_Items.IndexOf(productItem));
        }
    }
}
