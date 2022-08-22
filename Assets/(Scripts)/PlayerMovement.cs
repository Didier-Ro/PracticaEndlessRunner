using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody = default;
    [SerializeField] private float _playerSpeed = 5;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        _rigidbody.AddForce(transform.forward * _playerSpeed);
    }
}