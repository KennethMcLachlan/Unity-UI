using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggablesScript : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    private Image _image;
    private void Start()
    {
        _image = GetComponent<Image>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        var temp = _image.color;
        temp.a = 0.5f;
        _image.color = temp;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        var temp = _image.color;
        temp.a = 1.0f;
        _image.color = temp;
    }
}
