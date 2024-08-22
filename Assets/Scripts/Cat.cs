using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal // INHERITANCE
{
    [SerializeField] private float catSpeed = 4f;

    protected override void Start()
    {
        base.Start(); 
        speed = catSpeed; 

    }

    protected override void Move() // POLYMORPHISM
    {
       
        Vector3 movementDirection = movingForward ? transform.forward : -transform.forward;
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        
        Debug.Log("The cat is moving!");
    }


}
