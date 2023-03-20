﻿using UnityEngine;

public abstract class UIPanelBase : MonoBehaviour
{
    public string panelName;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void Show()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public abstract void OnReceive(UIEvent uiEvent, object obj);
}

