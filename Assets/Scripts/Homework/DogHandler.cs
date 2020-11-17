using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC9Dogs;
using System;

public class DogHandler : MonoBehaviour
{
    Class1 Teddy, Daisy, Max, Pred; 

    // Start is called before the first frame update
    void Start()
    {

       
        Teddy = new Class1("Teddy", "Chihuahua");
        Daisy = new Class1("Daisy", "Irish Wolfhound");
        Max = new Class1("Max", "Poodle", 100);

        Pred = new Class2("Pred", "like");
        
        if (Pred is Class2)
          (Pred as Class2).predator = 10;

        var classss = new Classxxx();

        IClass1 class1 = classss;

        IClass1 class2 = Teddy;

        class1.Move();
        class2.Move();

        Max.SetHeight(105);
        Max.pros3 = 100;
       

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Teddy.GetName());
        Teddy.Walking();

    }
}
