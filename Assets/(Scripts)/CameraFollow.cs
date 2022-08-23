using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _player = default;
    private Vector3 offset = default;

    private void Start()
    {
        offset = transform.position - _player.position;
    }

    private void Update()
    {
        transform.position = _player.position + offset;
    }
}
