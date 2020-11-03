// LIBRARIES
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CODE STRUCTURE
public class Session_1_2020_Homework : MonoBehaviour
{   // 1. DECLARING VARIABLES
    public int NumberOfLivingFloors = 50; 
    public int NumberOfOfficeFloors = 5;

    public float BuildingArea = 300.25f;

    private string Location = "London, UK";
    public string TypeOfTheBuilding = "Skyscraper";

    private bool UndergroundParking = false;
    public bool PresenceOfASpiere = true; 

    public int[] NumbersOfFloorsForRent = new int [3];
    public float[] HeightOfTheFloors = { 2.7f, 3.3f, 4.5f };

    public List<int> TypesOfApparments = new List<int>();

    // видимость, тип возв. название  
    private int OverallNumberOfFloors(int _FirstNumber, int _SecondNumber)
    {
        int SumResult = _FirstNumber + _SecondNumber;
        return SumResult;
    }
    // DECLARING a function 
    private void Start()
    {

        if ((1==0) || (1==1))
        {
            Debug.Log("TRUE"); // ??? 
        }
        else
        {
            Debug.Log("FALSE");
        }

        foreach (var item in TypesOfApparments)
        {

        }

        for (int i = 0; i < 100;  i++)
        {
            Debug.Log((i).ToString());
        }

        int j = 0; 

        while (j < 100)
        {
            j++;
        }


        int SumResult = OverallNumberOfFloors(NumberOfLivingFloors, NumberOfOfficeFloors);
        Debug.Log("Overall Number Of Floors is:" + SumResult.ToString());
        Temp();
    }

    private void Update()
    {
        
    }


    private void Temp()
    {
            // Dictionary 
        Dictionary<int, string> TypeOfTheBuilding = new Dictionary<int, string>();
        TypeOfTheBuilding.Add(55, "Skyscraper");
        TypeOfTheBuilding.Add(3, "Parking");
        TypeOfTheBuilding.Add(6, "ResidentialHouse");

        foreach (var keyValue in TypeOfTheBuilding)
        {
           Debug.Log(keyValue.Key.ToString() + "-" + keyValue.Value);
        }
        string Type = TypeOfTheBuilding[3];
        TypeOfTheBuilding[3] = "ShoppingMall";
    }
}
