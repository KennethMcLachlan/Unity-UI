using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameDraggable : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    private Image _image;
    [SerializeField] private Image _imageDrop;
    public Vector3 originalPosition;

    private void Start()
    {
        _image = GetComponent<Image>();
        originalPosition = _image.rectTransform.localPosition;
        Debug.Log(originalPosition);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void ResetPosition()
    {
        _image.rectTransform.localPosition = originalPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        ResetPosition();
        _image.raycastTarget = true;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _image.raycastTarget = false;
    }
}
