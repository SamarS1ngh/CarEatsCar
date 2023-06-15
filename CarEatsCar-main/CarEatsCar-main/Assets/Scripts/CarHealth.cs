using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour
{
    
    public HealthBar healthbar;

    public float maxHealth = 100;
    public float currHealth;


    private void Start() {
        currHealth = maxHealth;
        healthbar.setMaxHealth(maxHealth);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Enemy Car")){
            currHealth -= 20;
            healthbar.SetHealth(currHealth);
        }
    }
}
