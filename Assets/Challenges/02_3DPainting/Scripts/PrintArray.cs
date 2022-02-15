using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintArray : MonoBehaviour
{
    public GameObject[] TrailsArray;
    public GameObject SpawnHere;
    //public MeshFilter thisMesh;

    public GameObject[] BakedArray;





    public void PrintClicked()
    {
        TrailsArray = GameObject.FindGameObjectsWithTag("Trail");
        Debug.Log("Objects in TrailsArray: " + TrailsArray);

        foreach (GameObject Trail in TrailsArray)
        {
            //Instantiate(Trail, SpawnHere.transform.position, SpawnHere.transform.rotation);
            //Debug.Log("Instantiated: " + Trail);

            //TrailRenderer oldTrailComponent = Trail.GetComponent<TrailRenderer>();

            Trail.GetComponent<TrailRenderer>().BakeMesh(new Mesh(), true);
            //HappyTrails();

            //Need to change the tag of the objects with baked trail renderers?
            BakedArray = GameObject.FindGameObjectsWithTag("Trail");
            foreach(GameObject BakedTrail in BakedArray)
            {
                Instantiate(BakedTrail, SpawnHere.transform.position, Quaternion.identity);
                Debug.Log("Baked Instantiated");
            }
            
        }
    }

    //public void HappyTrails()
    //{
    //    currentTr.BakeMesh(tempMesh, true);
    //    MeshFilter f = currentTr.gameObject.AddComponent<MeshFilter>();
    //    f.mesh = tempMesh;
    //    currentTr.gameObject.AddComponent<MeshRenderer>();
    //    MeshCollider co = currentTr.gameObject.AddComponent<MeshCollider>();
    //    co.convex = true;
    //}

}
