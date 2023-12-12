using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseManagerScript : MonoBehaviour
{
    [SerializeField]
    private AudioMixer _audioMixer;
    [SerializeField]
    private GameObject _ball;

    [SerializeField]
    private GameObject _spawnPoint;

    [SerializeField]
    private GameObject _settingsMenu;

    [SerializeField]
    private Slider _sliderVolume;

    [SerializeField]
    private Slider _sliderBrightness;

    [SerializeField]
    private Image _blackOverlay;

    private bool _dropBall = true;
    private bool _menuActive;
    void Start()
    {
        SwitchMenu();
        StartCoroutine(DropBallRoutine());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TurnOffMenu();
        }
    }

    public void AdjustVolume()
    {
        _audioMixer.SetFloat("BackgroundMusic", _sliderVolume.value);
    }

    public void AdjustBrightness()
    {
        var tempColor = _blackOverlay.color;
        tempColor.a = _sliderBrightness.value;
        _blackOverlay.color = tempColor;
    }

    public void TurnOffMenu()
    {
        _menuActive = !_menuActive;
        if (_menuActive == true)
        {
            Time.timeScale = 0;
            SwitchMenu();
        }

        if (_menuActive == false)
        {
            Time.timeScale = 1;
            SwitchMenu();
        }
    }
    
    public void SwitchMenu()
    {
        if (_menuActive == true)
        {
            _settingsMenu.SetActive(true);
        }

        if (_menuActive == false)
        {
            _settingsMenu.SetActive(false);
        }
    }

    IEnumerator DropBallRoutine()
    {
        while (_dropBall == true)
        {
            GameObject ball = Instantiate(_ball, _spawnPoint.transform.position, _spawnPoint.transform.rotation);
            yield return new WaitForSeconds(1f);
            Destroy(ball, 1.0f);
        }
    }

    //private void PauseGame()
    //{
    //    Time.timeScale = 0;
    //    _settingsMenu.SetActive(true);
    //}

    //public void ResumeGame()
    //{
    //    Time.timeScale = 1;
    //    _settingsMenu.SetActive(false);
    //}
}
