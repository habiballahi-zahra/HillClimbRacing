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
    [SerializeField] private float _jumpingSpeed = 500f;
    private float _moveInput;


    private void Update()
    {
        _moveInput = Input.GetAxisRaw("Horizontal");




        if (Input.GetButtonDown("Jump"))
        {
            _carRB.AddForce(new Vector2(_carRB.velocity.x,_jumpingSpeed));
 
        }



        if (_moveInput == 0 && Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
                _moveInput = -1; // Move left
            }
            else
            {
                _moveInput = 1; // Move right
            }
        }
    }
    private void FixedUpdate()
    {
        _frontTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _backTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _carRB.AddTorque(-_moveInput * _rotationSpeed * Time.fixedDeltaTime);
    }

 
}
