using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuBalls : MonoBehaviour
{
    void Update()
    {
        Rigidbody2D rigidbody = this.GetComponent<Rigidbody2D>();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") + Input.acceleration.x, Input.GetAxis("Vertical") + Input.acceleration.y, 0.0f);
        rigidbody.AddForce(movement * 10);
    }
}
