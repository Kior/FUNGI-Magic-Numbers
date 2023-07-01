using TMPro;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    public int DefaultMax = 1000;
    public int DefaultMin = 1;

    public TMP_Text Text;

    private int _guess;
    private bool _isNewGame;
    private int _max;
    private int _min;
    private int _press;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        Restart();
    }

    private void Update()
    {
        if (_isNewGame)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Restart();
            }

            return;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _max = _guess;
            _press++;
            CalculateGuess();
            AskAboutGuess();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _min = _guess;
            _press++;
            CalculateGuess();
            AskAboutGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            SetText(
                $"Поздравляю! Я угадал! Твоё число {_guess}. Сделано {_press} ходов! Нажми пробел чтобы начать новую игру. Значения min, max и guess будут сброшены.");
            _isNewGame = true;
        }
    }

    #endregion

    #region Private methods

    private void AskAboutGuess()
    {
        SetText($"Твоё число {_guess}?");
    }

    private void CalculateGuess()
    {
        _guess = (_min + _max) / 2;
    }

    private void Restart()
    {
        _max = DefaultMax;
        _min = DefaultMin;
        _press = 0;
        SetText($"Привет! Загадай число от {_min} до {_max}");
        CalculateGuess();
        AskAboutGuess();
        _isNewGame = false;
        //ctrl + R + M, быстро создать метод на повторяющиеся строки.
    }

    private void SetText(string text)
    {
        Text.text = text;
    }

    #endregion
}