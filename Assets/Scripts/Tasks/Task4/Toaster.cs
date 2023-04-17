using System;
using UnityEngine;

public class Toaster : MonoBehaviour
{
    // TODO: Создайте событие TimerIsUp и вызывайте его, когда таймер вышел
    public delegate void ToasterHandler(Toaster toaster);
    public event ToasterHandler TimerIsUp;
    public float Timer { get; private set; } = 10; // Таймер готовности вафли
    private bool _isTimerUp; 

    private void Update()
    {
        // Если таймер вышел - выходим из метода
        if (_isTimerUp)
        {
            TimerIsUp?.Invoke(this);
            return;
        }
        
        // Если таймер не вышел
        if (Timer > 0)
        {
            // Отнимаем время, прошедшее за кадр
            Timer -= Time.deltaTime;
        }
        else
        {
            // Таймер вышел
            _isTimerUp = true;
        }
    }
}