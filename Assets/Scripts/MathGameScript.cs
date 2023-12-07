using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MathGameScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI[] _textFields;

    [SerializeField]
    private TMP_InputField _inputField;

    private int _number1;
    private int _number2;
    private int _hiddenAnswer;

    private void Start()
    {
        GenerateNewQuestion();

    }

    private void CalculateAnswer()
    {
        _hiddenAnswer = _number1 + _number2;
    }

    public void AnswerQuestion()
    {
        if (int.Parse(_inputField.text) == _hiddenAnswer)
        {
            _textFields[2].text = "Correct!";
        }
        else
        {
            _textFields[2].text = "Wrong. The correct answer is " + _hiddenAnswer;
        }
    }

    public void GenerateNewQuestion()
    {
        _number1 = Random.Range(1, 50);
        _number2 = Random.Range(1, 50);
        _textFields[0].text = _number1.ToString();
        _textFields[1].text = _number2.ToString();
        _textFields[2].text = "Solve";
        CalculateAnswer();
    }
}
