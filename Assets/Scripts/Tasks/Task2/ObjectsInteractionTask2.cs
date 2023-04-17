using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)    
    [SerializeField] private GameObject _lamp;
    [SerializeField] private Transform _position;
    private void Awake()
    {
        Instantiate(_lamp, _position);
    }
}