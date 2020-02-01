﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interaction : MonoBehaviour
{
    UnityEvent unityEventInteraction;
    private void Start()
    {
        if (unityEventInteraction == null)
        {
            unityEventInteraction = new UnityEvent();
        }
    }
    void InteractionEvent()
    {
        unityEventInteraction.Invoke();
    }
}
