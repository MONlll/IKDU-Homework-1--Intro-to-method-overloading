using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ageIncrease : MonoBehaviour

{
       public int myAge = 24; 
    void Start()
    {
         Debug.Log("My current age is: 24");
        
        IncreaseAge(myAge);
        
       
        IncreaseAge(myAge, 5); 
    }
    void IncreaseAge(int currentAge)
    {
        currentAge += 1; 
        Debug.Log("My age next year is: " + currentAge);
    }
    void IncreaseAge(int currentAge, int yearsToAdd)
    {
        currentAge += yearsToAdd; 
        Debug.Log("My age in " + yearsToAdd + " years is: " + currentAge);
    }
}