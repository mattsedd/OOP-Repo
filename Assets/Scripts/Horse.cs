using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Animal // INHERITANCE
{
    [SerializeField] private float horseSpeed = 4f; // POLYMORPHISM

    private void Start()
    {
        // Set the slug's speed to be slower
        speed = horseSpeed;

    }
}
