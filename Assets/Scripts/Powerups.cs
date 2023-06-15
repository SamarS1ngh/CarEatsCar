using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
   public Rigidbody rb;
   public PowerBar powerbar;
   public float minpower = 0f;
   public float currpower;

    public float upwardForce = 10f;
    public float sidewaysForce = 5f;

   private void Start() {
    rb = GetComponent<Rigidbody>();
    currpower = minpower;
    powerbar.setMinPowerup(currpower);
   }

   private void FixedUpdate() {
    if(Input.GetKey(KeyCode.Space) && powerbar.slider.value > 0 ){

        rb.AddForce(Vector3.up * upwardForce, ForceMode.Force);


    }
   }

   private void OnTriggerEnter2D(Collider2D other) {
    if(other.CompareTag("Player Car")){
       currpower += 10f;
       powerbar.setPowerUp(currpower);
        Debug.Log("Powerup picked");
        Destroy(this.gameObject);

    }
   }
}
