using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Onboarding : MonoBehaviour
{
    [SerializeField] private TMP_InputField[] _userInputFields;
    [SerializeField] private Button[] _buttons;
    [SerializeField] private GameObject _createAccount;
    [SerializeField] private GameObject _loginAccount;
    [SerializeField] private TextMeshProUGUI _debugText;
    [SerializeField] private string _username;
    [SerializeField] private string _password;

    void Start()
    {
        _debugText.text = "";
        _createAccount.SetActive(true);
        _loginAccount.SetActive(false);
    }

    void Update()
    {
        
    }

    public void LoginAccount()
    {
        if (_userInputFields[3].text == _username && _userInputFields[2].text == _password)
        {
            if (_username == "" || _password == "")
            {
                _debugText.text = "There is no account...";
                _userInputFields[3].text = "";
                _userInputFields[2].text = "";
            }
            else
            {
                _debugText.text = "Welcome " + _username + "!";
            }
        }
        
        if (_username == null ||  _password == null)
        {
            _debugText.text = "There is no account...";
            _userInputFields[3].text = "";
            _userInputFields[2].text = "";
        }

        if (_userInputFields[3].text != _username && _userInputFields[2].text != _password)
        {
            _debugText.text = "Username or Password are incorrect";
            _userInputFields[3].text = "";
            _userInputFields[2].text = "";
        }
    }
    public void CreateAccount()
    {
        if (_userInputFields[0].text.Length > 4 && _userInputFields[1].text.Length > 4)
        {
            _username = _userInputFields[0].text;
            _password = _userInputFields[1].text;
            _debugText.text = "Account succesfully created!";
            Debug.Log("Username: " + _username + " Password: " + _password);
            OpenLoginAccountMenu();
        }
        else
        {
            _debugText.text = "The Username and Password must be at least 4 characters or more.";
            _userInputFields[0].text = "";
            _userInputFields[1].text = "";
        }
        
    }

    public void OpenCreateAccountMenu()
    {
        _loginAccount.SetActive(false);
        _createAccount.SetActive(true);
    }

    public void OpenLoginAccountMenu()
    {
        _loginAccount.SetActive(true);
        _createAccount.SetActive(false);
    }
}
