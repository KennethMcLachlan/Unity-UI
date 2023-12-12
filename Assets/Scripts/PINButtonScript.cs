using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PINButtonScript : MonoBehaviour
{
    [SerializeField]
    private int _buttonValue;

    [SerializeField]
    private PINNumberScript _pinNumber;
    void Start()
    {
        
    }

    public void DisplayButtonValue()
    {
        _pinNumber.AddDigit(_buttonValue.ToString());
    }
}
