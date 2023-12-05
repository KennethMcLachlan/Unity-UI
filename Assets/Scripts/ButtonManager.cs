using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private Toggle _toggle;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ToggleTrue()
    {
        if (_toggle.isOn == true)
        {
            Debug.Log("Toggle is true");
        }
        else
        {
            Debug.Log("Toggle is false");
        }
    }
}
