using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caps : MonoBehaviour
{

    int counter = 0;
    Rigidbody rb;
    void Start()
    {
        
        transform.position = new Vector3(10, 5, 6);
        rb = GetComponent<Rigidbody>();
        rb.mass = 0;
    }


    private int sum(int a, int b)
    {
        int c = a + b;

        return c;
    }

    
    void Update()
    {
        /// Debug.Log("UPDATE");
        counter = sum(counter, 3); 
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
