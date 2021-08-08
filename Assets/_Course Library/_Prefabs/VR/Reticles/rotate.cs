using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    //public GameObject ret;
    public Texture myTexture;
    private Renderer myRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0, 222, 50);
        myRenderer = GetComponent<Renderer>();

        //Call SetColor using the shader property name "_Color" and setting the color to red
        myRenderer.material.SetColor("_Color", Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(1, 3, 1, Space.Self);
        transform.Rotate(0, 4, 0,Space.World);
        myRenderer.material.mainTexture = myTexture;
    }
}
