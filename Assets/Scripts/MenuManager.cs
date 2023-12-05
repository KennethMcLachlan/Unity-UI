using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _topButton;

    [SerializeField]
    private GameObject _menuOne;

    [SerializeField]
    private GameObject _menuTwo;

    public void MenuSwap()
    {
        _menuOne.SetActive(false);
        _menuTwo.SetActive(true);

        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(_topButton, new BaseEventData(eventSystem));
    }
}
