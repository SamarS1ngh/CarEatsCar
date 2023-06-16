using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyCar : MonoBehaviour
    {   
        private float Count = 5;

        private void OnTriggerEnter2D(Collider2D Vehicle)
        {
            if (Vehicle.tag == "Player")
            {
              
               Count--;
            }

            if (Count == 0)
            {
            Debug.Log("sdvsk");
                Destroy(Vehicle.gameObject);
            }
        }
    }



