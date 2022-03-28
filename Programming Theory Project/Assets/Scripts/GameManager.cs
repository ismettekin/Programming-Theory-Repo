using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool isGameActive = true;

    [SerializeField] GameObject cam;
    [SerializeField] GameObject car;
    [SerializeField] GameObject gameOverTitle;

    private Vector3 camOffset = new Vector3(0f, 2f, -5.5f);
    private void Awake() 
    {
        Instance = this;   
    }

    private void LateUpdate() 
    {
        cam.transform.position = car.transform.position + camOffset ;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.name == "Hot_hatch")
        {
            isGameActive = false;
        }
        
    }

  


}
