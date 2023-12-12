using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PINNumberScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _textField;
    private string _secretPIN = "1234";
    private string _actualPIN;
    void Start()
    {
        _textField.text = "Enter PIN...";
    }

    public void AddDigit(string number)
    {
        _textField.text = "";
        _actualPIN += number;
        _textField.text = _actualPIN;
    }

    public void Submit()
    {
        if (_secretPIN == _actualPIN)
        {
            _textField.text = "PIN Accepted";
            _actualPIN = null;
        }
        else
        {
            _textField.text = "Invalid PIN";
            _actualPIN = null;
        }
    }

    public void Clear()
    {
        _textField.text = "";
        _actualPIN = null;
    }
}
