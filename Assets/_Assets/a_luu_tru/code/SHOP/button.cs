using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public static class button 
{
    public static void AddEventListener<T>(this Button button, T param, Action<T> Onclck)
    {
        button.onClick.AddListener(delegate(){
            Onclck(param);
        });
    }
}
