using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterTile : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager = default;
    [SerializeField] private GameObject _tiles = default;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _gameManager.IncreaseScore();
            Destroy(_tiles, 1f);
        }
    }
}
