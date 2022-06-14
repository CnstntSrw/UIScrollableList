using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Serializable]
public class ContentStringString :  ContentBase
{
    public string Text1 = "";
    public string Text2 = "";

    public override void Init(ProductItem contentView, int number)
    {
        base.Init(contentView, number);
        contentView.ApplyStrings(new List<string>() { Text1 , Text2});
    }
}
