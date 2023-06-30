using TMPro;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    public TMP_Text Text;
    public int DefaultMax = 1000;
    public int DefaultMin = 1;
    private int _defaultPress = 0;


    private int _guess;
    private int _max;
    private int _min;
    private bool _newGame;
    private int _press;

    #endregion

    #region Unity lifecycle

    private void _setText(string text)
    {
        Text.text = text;
    }

    private void Start()
    {
        Restart();
    }

    private void Update()
    {
        if (_newGame)
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
            _setText($"Поздравляю! Я угадал! Твоё число {_guess}. Сделано {_press} ходов! Нажми пробел чтобы начать новую игру. Значения min, max и guess будут сброшены.");
            _newGame = true;
        }
    }

    #endregion

    #region Private methods

    private void AskAboutGuess()
    {
        _setText($"Твоё число {_guess}?");
    }

    private void CalculateGuess()
    {
        _guess = (_min + _max) / 2;
    }

    private void Restart()
    {
        _max = DefaultMax;
        _min = DefaultMin;
        _press = _defaultPress;
        _setText($"Привет! Загадай число от {_min} до {_max}");
        CalculateGuess();
        AskAboutGuess();
        _newGame = false;
        //ctrl + R + M, быстро создать метод на повторяющиеся строки.
    }

    #endregion
}