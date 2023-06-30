using UnityEngine;

public class SumTill50 : MonoBehaviour
{
    #region Variables

    public int Sum = 50;
    private int _defaultPress = 0;
    private bool _newGame;
    private int _number;
    private int _press;

    #endregion

    #region Unity lifecycle

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

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Increment(1);
            _press++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Increment(2);
            _press++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Increment(3);
            _press++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Increment(4);
            _press++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Increment(5);
            _press++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Increment(6);
            _press++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Increment(7);
            _press++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            Increment(8);
            _press++;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Increment(9);
            _press++;
        }

        if (_number >= Sum)
        {
            Debug.Log(
                $"Молодец. Цель достигнута. Число достигло {_number}. Сделано {_press} ходов. `Пробел` чтобы начать сначала");
            _newGame = true;
        }
    }

    #endregion

    #region Private methods

    private void Increment(int number)
    {
        _number += number;
        Debug.Log($"Число {number}. Итого {_number}.");
    }

    private void Restart()
    {
        Debug.Log("Введи десятичное число от 1 до 9");
        _newGame = false;
        _number = 0;
        _press = _defaultPress;
    }

    #endregion
}