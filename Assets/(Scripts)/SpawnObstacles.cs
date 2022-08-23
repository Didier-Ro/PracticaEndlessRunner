using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab = default;
    [SerializeField] private Transform _line1 = default;
    [SerializeField] private Transform _line2 = default;
    [SerializeField] private Transform _line3 = default;
    void Start()
    {
        int lineNumber = Random.Range(1, 3);

        switch (lineNumber)
        {
            case 1:
                GameObject obs = Instantiate(_obstaclePrefab, _line1.transform.position, Quaternion.identity);
                Destroy(obs, 10f);
                break;
            case 2:
                GameObject obs1 = Instantiate(_obstaclePrefab, _line2.transform.position, Quaternion.identity);
                Destroy(obs1, 10f);
                break;
            case 3:
                GameObject obs2 = Instantiate(_obstaclePrefab, _line3.transform.position, Quaternion.identity);
                Destroy(obs2, 10f);
                break;
        }
    }
}
