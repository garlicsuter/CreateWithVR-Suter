using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    
    //public Texture myTexture1;
    //public Texture myTexture2;
    //public Texture myTexture3;
    //public Texture myTexture4;
    //private Renderer myRenderer;
    //public Mesh theReticle;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0, 222, 50);
        //myRenderer = GetComponent<Renderer>();

        //Call SetColor using the shader property name "_Color" and setting the color to red
        //myRenderer.material.SetColor("_Color", Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1, 3, 1, Space.Self);
        //theReticle.transform.Rotate(2, 4*Time.deltaTime, 8,Space.World);
        
        //myRenderer.material.mainTexture = myTexture1;
        //myRenderer.material.mainTexture = myTexture2;
        //myRenderer.material.mainTexture = myTexture3;
        //myRenderer.material.mainTexture = myTexture4;
        //myRenderer.material.SetColor("_Color", Color.blue);
    }

    public void DoRotate()
    {
        transform.Rotate(1, 3, 1, Space.Self);
    }
}
