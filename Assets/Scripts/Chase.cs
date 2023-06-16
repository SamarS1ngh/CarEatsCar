using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    [SerializeField] private GameObject meteor;
    [SerializeField] private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        transform.position = Vector2.MoveTowards(transform.position, meteor.transform.position, speed * Time.deltaTime);
          }
}
