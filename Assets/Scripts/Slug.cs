using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slug : Animal
{
    [SerializeField] private float slugSpeed = 2f; // Slower speed for the slug

    private void Start()
    {
        // Set the slug's speed to be slower
        speed = slugSpeed;
        
    }
}
