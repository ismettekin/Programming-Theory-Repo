using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1Car : Car 
{
    private Rigidbody f1Rb;

    private void Start() 
    {
        f1Rb = GetComponent<Rigidbody>();
        
    }

    protected override void MoveCar(float speed, float userInput)
    {
        f1Rb.AddForce(Vector3.forward * speed * userInput * Time.deltaTime, ForceMode.Impulse);
        base.MoveCar(speed, userInput);
    }


}
