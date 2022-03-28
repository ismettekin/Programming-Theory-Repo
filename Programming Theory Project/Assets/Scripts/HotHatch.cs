using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotHatch : Car
{
    private Rigidbody hotHatchRb;
    void Start()
    {
        hotHatchRb = GetComponent<Rigidbody>();
    }

    protected override void MoveCar(float speed, float userInput)
    {
        //hotHatchRb.velocity = new Vector3(0,0, userInput) * speed;
        hotHatchRb.AddForce(Vector3.forward * speed * userInput * Time.deltaTime, ForceMode.Impulse);
        base.MoveCar(speed, userInput);
    }
}
