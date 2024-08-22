using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Animal
{
    [SerializeField] private float horseSpeed = 4f; // Slower speed for the slug

    private void Start()
    {
        // Set the slug's speed to be slower
        speed = horseSpeed;

    }
}
