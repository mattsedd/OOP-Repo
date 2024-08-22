using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal // INHERITANCE
{
    [SerializeField] private float catSpeed = 4f; // POLYMORPHISM

    private void Start()
    {
        // Set the slug's speed to be slower
        speed = catSpeed;

    }
}
