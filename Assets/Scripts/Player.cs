using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof (BoxCollider2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;


    [SerializeField] private float _moveSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMovement(); 
    }

    void PlayerMovement() {
        //var horizontalMovement = Input.GetAxis("Horizontal");
        //var verticalMovement = Input.GetAxis("Vertical");
        //transform.position += new Vector3(horizontalMovement, verticalMovement, 0) * Time.deltaTime * _moveSpeed;
        _rigidbody.velocity = new Vector2(_joystick.Horizontal * _moveSpeed, _joystick.Vertical * _moveSpeed);
    }
}
