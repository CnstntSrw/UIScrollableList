using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPool : MonoBehaviour
{
    [SerializeField]
    private int _MoneyAmount = 1000;

    public int MoneyAmount { get => _MoneyAmount;}

    public bool CanProceed(int money)
    {
        return _MoneyAmount - money >= 0;
    }

    public void Proceed(int money)
    {
        _MoneyAmount -= money;
    }
}
