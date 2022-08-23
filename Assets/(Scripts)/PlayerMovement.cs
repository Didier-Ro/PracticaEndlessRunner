using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager = default;
    private Rigidbody _rigidbody = default;
    [SerializeField] private float _playerSpeed = 5;
    private bool _isJumping = default;
    [SerializeField] private float _forceUp = 5;
    private int _line1XPosition = -3;
    private int _line2Xposition = 0;
    private int _line3Xposition = 3;
    private int _linePosition = 1; 
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.Translate(transform.forward * _playerSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            _linePosition++;
            if (_linePosition == 3)
            {
                _linePosition = 2;
            }
            ChangePosition();
        }
        
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _linePosition--;
            if (_linePosition == -1)
            {
                _linePosition = 0;
            }
            ChangePosition();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        if (_isJumping)
        {
            _rigidbody.AddForce(transform.up * _forceUp, ForceMode.Impulse);
            _isJumping = false;
        }
    }

    private void ChangePosition()
    {
        if (_linePosition == 0)
        {
            transform.position = new Vector3(_line1XPosition,transform.position.y, transform.position.z);
        }

        if (_linePosition == 1)
        {
            transform.position = new Vector3(_line2Xposition,transform.position.y, transform.position.z);
        }

        if (_linePosition == 2)
        {
            transform.position = new Vector3(_line3Xposition,transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            _gameManager.GameOver();
        }
    }
}