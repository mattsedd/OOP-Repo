using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Animal // INHERITANCE
{
    [SerializeField] private float horseSpeed = 4f; 

    protected override void Start() // POLYMORPHISM
    {
        base.Start(); 
        speed = horseSpeed; 

    }

    protected override void Move() // POLYMORPHISM
    {
        
        Vector3 movementDirection = movingForward ? transform.forward : -transform.forward;
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        
        Debug.Log("The horse is moving!");
    }


}
