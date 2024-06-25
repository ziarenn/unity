using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawning_trees : MonoBehaviour
{
    public GameObject prefab;
    public float minSpawnRate = 5f;
    public float maxSpawnRate = 8f;
    public float[] zPositions = { -1f, -4f };


    private void OnEnable()
    {
        ScheduleNextSpawn();
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject Tree = Instantiate(prefab, transform.position, Quaternion.identity);
        Vector3 randomPosition = Tree.transform.position;
        randomPosition.z = zPositions[Random.Range(0, zPositions.Length)];
        Tree.transform.position = randomPosition;

        ScheduleNextSpawn();
    }
    private void ScheduleNextSpawn()
    {
        float spawnRate = Random.Range(minSpawnRate, maxSpawnRate);
        Invoke(nameof(Spawn), spawnRate);
    }

}