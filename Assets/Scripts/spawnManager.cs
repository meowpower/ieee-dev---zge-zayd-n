using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject AppleSpawner;
    public GameObject applePrefab;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(applePrefab, AppleSpawner.transform.position, gameObject.transform.rotation);
        }
    }
}
