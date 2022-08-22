using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTiles : MonoBehaviour
{
    [SerializeField] private GameObject _tiles = default;
    [SerializeField] private GameObject _spawnPoint = default;

    public void SpawningTiles()
    {
        GameObject Tiles = Instantiate(_tiles, _spawnPoint.transform.position, Quaternion.identity);
    }
}
