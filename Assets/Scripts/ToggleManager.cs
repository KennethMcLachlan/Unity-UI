using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleManager : MonoBehaviour
{
    [SerializeField]
    private Toggle[] _toggle;

    [SerializeField]
    private Sprite[] _dinoPics;

    [SerializeField]
    private Image _imagePlaceHolder;

    [SerializeField]
    private TextMeshProUGUI _textField;
    void Start()
    {
        _textField.text = "Select your difficulty";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleEasyTrue()
    {
        if (_toggle[0].isOn == true)
        {
            _imagePlaceHolder.sprite = _dinoPics[0];
            _textField.text = "You can outrun dinosaurs";
        }
    }

    public void ToggleMediumTrue()
    {
        if (_toggle[1].isOn == true)
        {
            _imagePlaceHolder.sprite = _dinoPics[1];
            _textField.text = "You have a decent chance to survive";
        }
    }

    public void ToggleHardTrue()
    {
        if (_toggle[2].isOn == true)
        {
            _imagePlaceHolder.sprite = _dinoPics[2];
            _textField.text = "Prepare to die";
        }
    }
}
