using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTrail : MonoBehaviour
{
    public GameObject myTrail;
    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintSingle()
    {
        myTrail = GameObject.FindGameObjectWithTag("Trail");
        myTrail.GetComponent<TrailRenderer>().BakeMesh(new Mesh(), true);
    }
}
