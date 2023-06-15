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

    public void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("EnemyCar")){
            currHealth -= 20;
            healthbar.SetHealth(currHealth);
        }
    }
}
