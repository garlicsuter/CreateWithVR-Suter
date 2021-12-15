using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentEdits : MonoBehaviour
{
    //My Name is Max Tieu ^-^
    int lowBottle = 1;

    // Start is called before the first frame update
    void Start()
    {
        for (int numBottle = 99; numBottle>lowBottle; numBottle--)
        {
            Debug.Log(numBottle + " Bottles of Ketchup on the Wall");
        }
        Debug.Log("1 Bottle of Ketchup on the Wall");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
