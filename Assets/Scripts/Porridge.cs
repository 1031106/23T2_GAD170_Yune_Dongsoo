using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porridge : MonoBehaviour
{
    [SerializeField] private float temperature;


    private void Start()
    {
        temperature = 100;
    }
    private void Update()
    {
        // Computer running at 800 FPS... deltaTime will be 1/800 = 0.00125;
        // Computer running at  60 FPS... deltaTime will be 1/60  = 0.01667;
        // Computer running at  10 FPS... deltaTime will be 1/10  = 0.1;
        // int characterMovementSpeed = 5;
        // transform.position + Vector3.forward * characterMovementSpeed * Time.deltaTime;

        temperature = temperature - Time.deltaTime;

        if (temperature > 70)
        {
            Debug.Log("The temperature is too hot!" + (int)temperature);
            // "Debug.Log()" or "Print()";    

        }
        else if (temperature < 40)
        {
            Debug.Log("The temperature is too cold!");
        }
        else
        {
            Debug.Log("The temperature is just right!");
        }
        Debug.Log("The temperature as an integer is =" + (int)temperature + ".");
    }
}
