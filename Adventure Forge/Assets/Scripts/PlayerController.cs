using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour
{

    Vector3 direction = new Vector3(0, 0, 0);
    Rigidbody rb;

    public int speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
        direction.Normalize();

        rb.AddForce(direction * speed);

        if (direction.x != 0 || direction.z != 0)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}
