using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalObstacleBehaviour : MonoBehaviour
{
    [SerializeField] 
    private float _liftDuration;

    [SerializeField] 
    private float _steps;

    private Vector3 _startPosition;
    private Vector3 _endPosition;
    private float _currentLiftTime;

    private void Awake()
    {
        _startPosition = transform.position;

        _endPosition = transform.position;
        _endPosition.y += _steps;
    }

    private void Update()
    {
        _currentLiftTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentLiftTime, _liftDuration) / _liftDuration;
        var position = Vector3.Lerp(_startPosition, _endPosition, progress);
        transform.position = position;
    }
}
