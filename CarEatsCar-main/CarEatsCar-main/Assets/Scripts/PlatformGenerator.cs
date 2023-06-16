using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject newplatform;
    public Transform generationPoint;

    private float platformWidth;

     void Start() {
       platformWidth = newplatform.GetComponent<BoxCollider2D>().size.x; 
    }
}
