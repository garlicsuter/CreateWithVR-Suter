using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentEdits : MonoBehaviour
{
    public int lowestBottle = 1;
    
    void Start()
    {
        //This is zoey
        //blueberry jam is pretty neat
       for(int i = 99; i > lowestBottle; i--)
        {
            Debug.Log(i + "bottles of blueberry jam on the wall");
        }
        Debug.Log("1 bottle of blueberry on the wall");
    }
}
