using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minimap : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private GameObject _enemy;
    [SerializeField]
    private Image _enemyPosition;
    [SerializeField]
    private Image _mapPosition;


    void Update()
    {
        _mapPosition.rectTransform.localPosition = new Vector3(-1 * _player.transform.position.x, -1 *  _player.transform.position.z, 0);
        _enemyPosition.rectTransform.localPosition = new Vector3(_enemy.transform.position.x, _enemy.transform.position.z, 0);
    }
}
