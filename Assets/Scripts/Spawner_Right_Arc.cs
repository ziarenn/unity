using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawning_Arc_r : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 8f;

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
        GameObject Arc_r = Instantiate(prefab, transform.position, Quaternion.identity);

    }

}