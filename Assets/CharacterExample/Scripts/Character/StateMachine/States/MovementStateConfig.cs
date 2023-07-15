using System;
using UnityEngine;

[Serializable]
public class MovementStateConfig
{
    [SerializeField, Range(0, 10)] private float _speed;
    [SerializeField, Range(0, 20)] private float _fastSpeed;
    [SerializeField, Range(0, 5)] private float _slowSpeed;

    public float Speed 
    {
        get
        {
            CurrentSpeed = _speed;
            return _speed;
        }
    }
    public float FastSpeed
    {
        get
        {
            CurrentSpeed = _fastSpeed;
            return _fastSpeed;
        }
    }
    public float SlowSpeed
    {
        get
        {
            CurrentSpeed = _slowSpeed;
            return _slowSpeed;
        }
    }

    public float CurrentSpeed { get; private set; }
}
