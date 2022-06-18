using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MovementSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement(); 
    }

    void PlayerMovement() { 
        var horizontalMovement = Input.GetAxis("Horizontal");
        var verticalMovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontalMovement, verticalMovement, 0) * Time.deltaTime * MovementSpeed;
    }
}
