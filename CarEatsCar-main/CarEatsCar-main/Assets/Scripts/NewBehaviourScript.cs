using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MyNewBehaviourScript : MonoBehaviour
{
    public class NewBehaviourScript : MonoBehaviour
    {
        private float Count = 3;
        private void OnTriggerEnter2D(Collider2D Vehicle)
        {
            if (Vehicle.tag == "Player")
            {
                Count--;
            }

            if (Count == 0)
            {
                Destroy(Vehicle.gameObject);
            }
        }
    }

}

