using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class DestroyCar : MonoBehaviour
    {

        public HealthBar healthbar;
        public float currHealth;


        private float Count = 3;
        private void OnTriggerEnter2D(Collider2D Vehicle)
        {
            if (Vehicle.tag == "Player")
            {
                currHealth -= currHealth % 3;
                healthbar.SetHealth(currHealth);
               Count--;
            }

            if (Count == 0)
            {
                Destroy(Vehicle.gameObject);
            }
        }
    }



