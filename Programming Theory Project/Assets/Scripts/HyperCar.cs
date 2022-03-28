using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperCar : Car
{
    private Rigidbody hyperCarRb;

    private void Start() 
    {
        hyperCarRb = GetComponent<Rigidbody>();   
    }

    protected override void MoveCar(float speed, float userInput)
    {
        hyperCarRb.AddForce(Vector3.forward * speed * userInput * Time.deltaTime, ForceMode.Impulse);
        base.MoveCar(speed, userInput);
    }
}
