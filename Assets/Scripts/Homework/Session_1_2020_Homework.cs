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

private int OverallNumberOfFloors (int _FirstNumber, int _SecondNumber)
{
    int SumResult = _FirstNumber + _SecondNumber;
    return SumResult;
}
    // DECLARING a function 
    void Start()
    {
    int SumResult = OverallNumberOfFloors(NumberOfLivingFloors,NumberOfOfficeFloors);
        Debug.Log("Overall Number Of Floors is:" + SumResult.ToString());
    }

    // Dictionary 
  Dictionary<int, string> TypeOfTheBuilding = new Dictionary<int, string>();
  TypeOfTheBuilding.Add(55, "Skyscraper");
  TypeOfTheBuilding.Add(3, "Parking");
  TypeOfTheBuilding.Add(6, "ResidentialHouse");

  foreach (KeyValuePair<int, string> keyValue in TypeOfTheBuilding)
  {
        Console.WriteLine(keyValue.Key + "-" + keyValue.Value);
  }
string Type = TypeOfTheBuilding[3];
TypeOfTheBuilding[3] = "ShoppingMall";

