using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageSystem : MonoBehaviour
{
    public event Action<bool> OnCloseMessage;
    [SerializeField]
    MessageView _Message;

    void Awake()
    {
        _Message.OnClose += _Message_OnClose;
    }

    private void _Message_OnClose(bool isSubmitted)
    {
        _Message.gameObject.SetActive(false);

        OnCloseMessage?.Invoke(isSubmitted);
    }

    public void ShowMessage(string message, bool cancelButton = false)
    {
        _Message.gameObject.SetActive(true);
        _Message.Show(message, cancelButton);
    }
}
