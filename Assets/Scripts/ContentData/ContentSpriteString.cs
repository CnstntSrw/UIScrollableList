using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ContentSpriteString : ContentBase
{
    public Sprite Sprite1;
    public string Text1 = "";

    public override void Init(ProductItem contentView, int number)
    {
        base.Init(contentView, number);
        contentView.ApplySprites(new List<Sprite>() { Sprite1 });
        contentView.ApplyStrings(new List<string>() { Text1 });
    }
}
