using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestDropDown : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown _dropDown;

    [SerializeField]
    private TextMeshProUGUI _textField;
    
    public void DropdownValue()
    {
        Debug.Log(_dropDown.value);
    }

    public void ChangeDifficulty()
    {
        if (_dropDown.value == 0)
        {
            _textField.text = "You have selected Easy";
        }

        if (_dropDown.value == 1)
        {
            _textField.text = "You have selected Medium";
        }

        if (_dropDown.value == 2)
        {
            _textField.text = "You have selected Hard";
        }
    }
}
