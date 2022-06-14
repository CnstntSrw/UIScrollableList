using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MessageView : MonoBehaviour
{
    public event Action<bool> OnClose;
    [SerializeField]
    private TextMeshProUGUI _MessageText;
    [SerializeField]
    private Button _OKButton;
    [SerializeField]
    private Button _CancelButton;
    [SerializeField]
    private GameObject _Blocker;
    public void Show(string text, bool withCancel = false)
    {
        _Blocker.SetActive(true);
        _MessageText.text = text;
        if (withCancel)
        {
            _CancelButton.gameObject.SetActive(true);
        }
    }

    public void OnSubmit()
    {
        _CancelButton.gameObject.SetActive(false);
        _Blocker.SetActive(false);
        OnClose?.Invoke(true);
    }
    public void OnCancel()
    {
        _CancelButton.gameObject.SetActive(false);
        _Blocker.SetActive(false);
        OnClose?.Invoke(false);
    }
}
