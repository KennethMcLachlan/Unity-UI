using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;

    [SerializeField]
    private TextMeshProUGUI _textField;

    
    private void Update()
    {
        _textField.text = _slider.value.ToString();
    }
}
