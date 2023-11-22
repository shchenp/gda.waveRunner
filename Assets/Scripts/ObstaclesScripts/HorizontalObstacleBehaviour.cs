using System;
using UnityEngine;

public class HorizontalObstacleBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _movementDuration;

    [SerializeField]
    private float _sidestep;
    
    private Vector3 _startPoint;
    private Vector3 _endPoint;
    private float _currentMovementTime;

    private void Awake()
    {
        _startPoint = transform.position;
        _startPoint.x -= _sidestep;

        _endPoint = transform.position;
        _endPoint.x += _sidestep;
    }

    private void Update()
    {
        _currentMovementTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentMovementTime, _movementDuration) / _movementDuration;
        transform.position = Vector3.Lerp(_startPoint, _endPoint, progress);
    }
}
