using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectEventListener : MonoBehaviour
{
    // Start is called before the first frame update
    private Action disable_event, enable_event;


    public void setOnDisableEvent(Action ev)
    {
        disable_event = ev;
    }

    public void setOnEnableEvent(Action ev)
    {
        enable_event = ev;
    }

    private void OnDisable()
    {
        disable_event?.Invoke();
    }

    private void OnEnable()
    {
        enable_event?.Invoke();
    }
}
