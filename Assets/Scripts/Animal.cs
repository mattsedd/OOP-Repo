using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    protected float speed = 5f; // Movement speed
    protected float moveDuration = 2f; // Time to move in one direction before switching

    private float timeSinceDirectionChange;
    private bool movingForward = true;

    private void Start()
    {
        timeSinceDirectionChange = 0f;
    }

    private void Update()
    {
        // Update the time since the last direction change
        timeSinceDirectionChange += Time.deltaTime;

        // Check if it's time to switch direction
        if (timeSinceDirectionChange >= moveDuration)
        {
            // Switch direction
            movingForward = !movingForward;
            timeSinceDirectionChange = 0f; // Reset the timer
        }

        // Move in the current direction
        Move();
    }

    private void Move()
    {
        // Move forward or backward based on the current direction
        Vector3 movementDirection = movingForward ? transform.forward : -transform.forward;
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
    }
}
