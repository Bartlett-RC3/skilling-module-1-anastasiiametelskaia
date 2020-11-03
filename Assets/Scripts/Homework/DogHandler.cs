using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC9Dogs;

public class DogHandler : MonoBehaviour
{
    Class1 Teddy, Daisy, Max;

    // Start is called before the first frame update
    void Start()
    {
        Teddy = new Class1("Teddy", "Chihuahua");
        Daisy = new Class1("Daisy", "Irish Wolfhound");
        Max = new Class1("Max", "Poodle");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Teddy.GetName());
        Teddy.Walking();

    }
}
