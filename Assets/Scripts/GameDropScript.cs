using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameDropScript : MonoBehaviour, IDropHandler
{
    private Image _thisImage;

    private void Start()
    {
        _thisImage = GetComponent<Image>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == "Image_Bomb")
        {
            eventData.pointerDrag.GetComponent<GameDraggable>().originalPosition = _thisImage.rectTransform.localPosition;
        }
    }
}
