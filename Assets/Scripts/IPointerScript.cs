using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IPointerScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Button _chargebutton;
    [SerializeField] private TextMeshProUGUI _textField;
    [SerializeField] private Animator _anim;

    private bool _isCharging;

    [SerializeField] private float _charge;
    [SerializeField] private float _chargeRate = 33.3f;

    private void Start()
    {
        _textField.text = "No Charge";
    }
    private void Update()
    {
        Charging();
        ChangeSpeedAnim();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Mouse pointer down");
        _isCharging = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Mouse pointer up");
        _isCharging = false;
    }

    private void ChangeSpeedAnim()
    {
        if (_charge < 33f)
        {
            _anim.speed = 1;
        }

        if (_charge > 33f && _charge < 66f)
        {
            _anim.speed = 2;
        }

        if ( _charge > 66)
        {
            _anim.speed = 4;
        }
    }

    private void Charging()
    {
        if (_isCharging == true)
        {
            if (_charge <= 100)
            {
                _charge += _chargeRate * Time.deltaTime;
            }
        }
        _slider.value = _charge;
        _textField.text = "Charging...";

        if (_isCharging == false)
        {
            if (_charge >= 0)
            {
                _charge -= _chargeRate * 5 * Time.deltaTime;
            }
            _slider.value = _charge;
            _textField.text = "No Charge";
        }
    }
}
