using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyPoolView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _MoneyText;
    [SerializeField]
    private MoneyPool _MoneyPool;

    // Update is called once per frame
    void Update()
    {
        _MoneyText.text = _MoneyPool.MoneyAmount.ToString() + "$";
    }
}
