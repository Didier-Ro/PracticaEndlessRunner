using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNextPlatform : MonoBehaviour
{
    [SerializeField] private GameObject _tiles = default;
    [SerializeField] private Transform _spawnPoint = default;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
            Instantiate(_tiles, _spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
