using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObstacleBehaviour : MonoBehaviour
{
    [SerializeField] private Vector3 _minScale;
    [SerializeField] private Vector3 _maxScale;
    [SerializeField] private float _scaleDuration;

    private float _currentScaleTime;
    
    private void Update()
    {
        _currentScaleTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentScaleTime, _scaleDuration) / _scaleDuration;
        transform.localScale = Vector3.Lerp(_minScale, _maxScale, progress);
    }
}
