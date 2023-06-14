using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _frontTireRB;
    [SerializeField] private Rigidbody2D _backTireRB;
    [SerializeField] private Rigidbody2D _frontTireRB1;
    [SerializeField] private Rigidbody2D _backTireRB1;
    [SerializeField] private Rigidbody2D carRB;
    [SerializeField] private float _speed = 400f;
    [SerializeField] private float _rotationSpeed = 300f;


    private void Update()
    {

    }

    /*private void FixedUpdate() {
      _frontTireRB.AddTorque(-moveInput * _speed * Time.fixedDeltaTime);
      _frontTireRB1.AddTorque(-moveInput * _speed * Time.fixedDeltaTime);
      _backTireRB.AddTorque(-moveInput * _speed * Time.fixedDeltaTime);
      _backTireRB1.AddTorque(-moveInput * _speed * Time.fixedDeltaTime);
          carRB.AddTorque(moveInput* _rotationSpeed * Time.fixedDeltaTime);
     }
  }
    */
}