using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverCar : MonoBehaviour
{


    [SerializeField] private Rigidbody2D _frontTireRB;
    [SerializeField] private Rigidbody2D _backTireRB;
    [SerializeField] private Rigidbody2D _carRB;
    [SerializeField] private float _rotationSpeed = 300f;
    [SerializeField] private float _speed = 100f;
    private float _moveInput;
    private void Update()
    {
        _moveInput = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        _frontTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _backTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _carRB.AddTorque(-_moveInput * _rotationSpeed * Time.fixedDeltaTime);
    }
}
