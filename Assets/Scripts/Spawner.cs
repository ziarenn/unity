using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning_sc : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 2f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject Ground_1 = Instantiate(prefab, transform.position, Quaternion.identity);

    }

}