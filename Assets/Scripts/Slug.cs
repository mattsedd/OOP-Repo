using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slug : Animal // INHERITANCE
{
    [SerializeField] private float slugSpeed = 4f;

    protected override void Start()
    {
        base.Start(); 
        speed = slugSpeed; 

    }

    protected override void Move() // POLYMORPHISM
    {
        
        Vector3 movementDirection = movingForward ? transform.forward : -transform.forward;
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        
        Debug.Log("The slug is moving!");
    }


}
