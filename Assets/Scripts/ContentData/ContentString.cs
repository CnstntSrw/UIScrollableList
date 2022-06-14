using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Serializable]
public class ContentString :  ContentBase
{
    public string Text1 = "";

    public override void Init(ProductItem contentView, int number)
    {
        base.Init(contentView, number);
        contentView.ApplyStrings(new List<string>() { Text1 });
    }
}
