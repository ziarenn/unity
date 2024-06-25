using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton_Health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 3f;
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }
}
