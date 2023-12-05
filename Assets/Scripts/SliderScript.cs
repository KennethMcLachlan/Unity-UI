using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;

    [SerializeField]
    private TextMeshProUGUI _textField;

    [SerializeField]
    private int _health;

    private void Start()
    {
        _health = 100;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_health >= 1)
            {
                _health -= 10;
                _slider.value = _health;
                _textField.text = _health.ToString();

            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (_health <= 99)
            {
                _health += 10;
                _slider.value = _health;
                _textField.text = _health.ToString();
            }
        }
    }
}
