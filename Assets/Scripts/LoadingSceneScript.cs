using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSceneScript : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;

    [SerializeField]
    private TextMeshProUGUI _textField;

    [SerializeField]
    private float _percentage;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(LoadSceneScreen());
        }
    }

    IEnumerator LoadSceneScreen()
    {
        AsyncOperation asyncload = SceneManager.LoadSceneAsync("SampleScene");

        while (!asyncload.isDone)
        {
            yield return null;

            _slider.value = asyncload.progress;
            _textField.text = asyncload.progress.ToString("00%");
            Debug.Log("%" + asyncload.progress);

        }
    }
}
