using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    private int _min;
    private int _max;
    private int _guess;
    private void Start()
    {
        _min = 1;
        _max = 1000;
        Debug.Log($"Привет! Загадай число от {_min} до {_max}");
        CalculateGuess();
        AskAboutGuess();
        //ctrl + R + M, быстро создать метод на повторяющиеся строки.
    }

    private void AskAboutGuess()
    {
        Debug.Log($"Твоё число {_guess}");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _max = _guess;
            CalculateGuess();
            AskAboutGuess();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _min = _guess;
            CalculateGuess();
            AskAboutGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Поздравляю! Я угадал! Твоё число {_guess}");
        }
    }

    private void CalculateGuess()
    {
        _guess = (_min + _max) / 2;
    }
}
