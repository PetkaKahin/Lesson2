using System;
using UnityEngine;

[Serializable]
public class MovementStateConfig
{
    [SerializeField, Range(0, 10)] private float _speed;
    [SerializeField, Range(0, 20)] private float _fastSpeed;
    [SerializeField, Range(0, 5)] private float _slowSpeed;

    public float Speed => _speed;
    public float FastSpeed => _fastSpeed;
    public float SlowSpeed => _slowSpeed;
}
