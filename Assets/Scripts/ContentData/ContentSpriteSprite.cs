using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ContentSpriteSprite : ContentBase
{
    public Sprite Sprite1;
    public Sprite Sprite2;

    public override void Init(ProductItem contentView, int number)
    {
        base.Init(contentView, number);
        contentView.ApplySprites(new List<Sprite>() { Sprite1, Sprite2 });
    }
}
