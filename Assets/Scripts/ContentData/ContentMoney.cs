using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ContentMoney: ContentBase
{
    public int Money = 0;

    public override void Init(ProductItem contentView, int number)
    {
        base.Init(contentView, number);
        contentView.ApplyMoney(Money);
    }
    public override int GetPrice()
    {
        return -Money;
    }
}

