using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public string _tagName ;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Spawn();
        }
    }
    private void Spawn()
    {
        ObjectPooler.Instance.SpawnFromPool(_tagName, new Vector3(0,0,0), Quaternion.identity);
    }
}
