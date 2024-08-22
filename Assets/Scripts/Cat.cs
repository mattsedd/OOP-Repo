using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    [SerializeField] private float catSpeed = 4f; // Slower speed for the slug

    private void Start()
    {
        // Set the slug's speed to be slower
        speed = catSpeed;

    }
}
