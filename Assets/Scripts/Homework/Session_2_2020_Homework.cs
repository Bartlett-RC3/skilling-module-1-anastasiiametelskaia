using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session_2_2020_Homework : MonoBehaviour
{

    string[] colours = { "red", "green", "yellow", "black", "white" };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(colours[1]);

        for (int counter = 0; counter < colours.Length; counter = counter + 1)
        {
            Debug.Log("The current color is " + counter);
            Debug.Log(colours[counter]);
        }

        int sum = 0;
        for (int i = 1; i < 100; i= i+2)
        {
            sum += i;
        }
        Debug.Log("all odd numvers to 100 added togheter is:" + sum);

        foreach (var currentColour in colours)
        {
            Debug.Log("Going over the rainbow with " + currentColour);
        }

        int whilecounter = 0;
        string rainbow = "Rainbow colours: ";

        while (whilecounter < colours.Length)
        {
            rainbow += colours[whilecounter];
            whilecounter++;
        }
        Debug.Log(rainbow);


        for (int i = 0; i < 100; i++)
        {
            if (i%2 == 0)
            {
                Debug.Log("Whole number:" + i);
            }
            else
            {
                Debug.Log("Odd number" + i);
            }
        }

        bool question1Anwer = true;
        bool question2Answer = true;
        bool question3Answer = false;

        if (question1Anwer && question2Answer)
        {
            Debug.Log("Both answers are true");
        }

        if (question1Anwer || question3Answer)
        {
            Debug.Log("One of the abswers is true");
        }

        if (question1Anwer || question2Answer || question3Answer)
        {

        }

        if (question1Anwer == true)
        {
            if (question2Answer == true)
            {
                if (question3Answer == false)
                {

                }
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
