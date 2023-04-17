using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] private Waffle _waffle;

    [SerializeField] private Transform _position;

    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs)
    public void Start()
    {
        var toaster = FindObjectOfType<Toaster>();
        toaster.TimerIsUp += OnTimerIsUp;
    }

    public void Update()
    {
        
    }

    private void OnTimerIsUp(Toaster toaster)
    { 
        Instantiate(_waffle, _position);
        toaster.TimerIsUp -= OnTimerIsUp;
    }
}