using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject _prefabToBeSpawnned;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Spawn();
        }
    }
    private void Spawn()
    {
        Instantiate(_prefabToBeSpawnned, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
