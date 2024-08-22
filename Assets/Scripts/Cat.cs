using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal // INHERITANCE
{
    [SerializeField] private float catSpeed = 4f;

    protected override void Start()
    {
        base.Start(); // Call base class Start method to ensure base initialization
        speed = catSpeed; // Set the horse's speed

    }

    protected override void Move() // POLYMORPHISM
    {
        // Optionally, add specific behavior for Horse movement
        // For example, you can modify the speed or movement logic
        Vector3 movementDirection = movingForward ? transform.forward : -transform.forward;
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        // Add additional behavior if needed
        Debug.Log("The cat is moving!");
    }


}
