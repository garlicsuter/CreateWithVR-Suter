using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentEdits : MonoBehaviour
{
    public int lowestBottle = 1;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 99; i > lowestBottle; i--)
        {
            Debug.Log(i + "bottle of ketchup on the wall");
        }
        Debug.Log("1 bottle of ketchup on the wall");
    }
      
    // Update is called once per frame
    void Update()
    {
        
    }
}
