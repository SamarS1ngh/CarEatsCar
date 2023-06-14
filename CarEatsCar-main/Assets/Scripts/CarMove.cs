using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _frontTireRB;
    [SerializeField] private Rigidbody2D _backTireRB;
    [SerializeField] private Rigidbody2D carRB;
    [SerializeField] private float _speed = 400f;
    [SerializeField] private float _rotationSpeed = 300f;

    private float _moveInput;

    private void Update()
    {
        _moveInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        _frontTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _backTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        carRB.AddTorque(-_moveInput * _rotationSpeed * Time.fixedDeltaTime);
    }
}