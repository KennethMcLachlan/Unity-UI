using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _username;

    [SerializeField]
    private TMP_InputField _password;

    [SerializeField]
    private TextMeshProUGUI _outputText;

    public void InputFieldUsername()
    {
        PlayerPrefs.SetString("name", _username.text);
    }

    public void InputFieldPassword()
    {
        PlayerPrefs.SetString ("password", _password.text);
    }

    public void OutputText()
    {
        _outputText.text = "Username: " + PlayerPrefs.GetString("name") + " Password: " + PlayerPrefs.GetString("password");
    }
    
}
