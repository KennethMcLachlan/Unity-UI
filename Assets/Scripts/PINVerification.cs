using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PINVerification : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _createPINField;

    [SerializeField]
    private TMP_InputField _enterPINField;

    [SerializeField]
    private TextMeshProUGUI _debugText;

    private int _PINNumber;
    private int _enteredPIN;

    private void Start()
    {
        _debugText.text = "";
    }

    public void CreatePIN()
    {
        if (_createPINField.text.Length < 4)
        {
            _debugText.text = "4 digits required";
            _createPINField.text = "";
        }
        else
        {
            _PINNumber = int.Parse(_createPINField.text);
            Debug.Log(_PINNumber);
            _debugText.text = "";
        }
    }

    public void EnteredPIN()
    {
        _enteredPIN = int.Parse(_enterPINField.text);

        if (_PINNumber == _enteredPIN)
        {
            _debugText.text = "Correct PIN entered";
        }
        else
        {
            _debugText.text = "Try Again";
            _enterPINField.text = "";
        }

    }
}
