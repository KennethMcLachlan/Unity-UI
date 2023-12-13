using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileButtonManager : MonoBehaviour
{
    [SerializeField] private int _value;
    [SerializeField] private TileGameManager _gameManager;
    [SerializeField] private Image _cover;
    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<TileGameManager>();
    }
    public void SendScore()
    {
        _gameManager.ScoreTotal(_value);
        _cover.gameObject.SetActive(false);
    }
}
