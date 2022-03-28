using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{ 
    [SerializeField]
    private float carSpeed;
    public float CarSpeed
    {
       get {return carSpeed;}

        set 
        {
            carSpeed = value;
        }

   }

   private float verticalInput;

   private void Update() 
   {
       verticalInput = Input.GetAxis("Vertical"); 
   }
   private void FixedUpdate() 
   {
       if(GameManager.Instance.isGameActive == true) MoveCar(CarSpeed, verticalInput);  
   }

   protected virtual void MoveCar(float speed, float userInput) {}



   
    
}
