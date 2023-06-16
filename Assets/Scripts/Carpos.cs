using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpos : MonoBehaviour
{
    public Vector3 initialPosition;
    void Start()
    {
        initialPosition = transform.position;
    }

 void OnTriggerEnter2D(Collider2D other){
    if(other.CompareTag("Finish")){
    transform.position = initialPosition;
  }
}}
