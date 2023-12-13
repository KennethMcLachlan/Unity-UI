using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
public class TileGameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textField;
    [SerializeField] private int _score;
    [SerializeField] private GameObject[] _items;
    private GameObject _grid;

    private void Start()
    {
        _textField.text = "";
        _score = 0;
        _grid = GameObject.Find("Grid");

        for (int i = 0; i < 15; i++)
        {
            GameObject item = Instantiate(_items[Random.Range(0, 3)], transform.position, Quaternion.identity);
            item.transform.SetParent(_grid.transform);
        }
    }
    public void ScoreTotal(int value)
    {
        _score += value;
        _textField.text = _score.ToString("00");
    }
}
