using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slug : Animal // INHERITANCE
{
    [SerializeField] private float slugSpeed = 2f; // POLYMORPHISM

    private void Start()
    {
        // Set the slug's speed to be slower
        speed = slugSpeed;
        
    }
}
