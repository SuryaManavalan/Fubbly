using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propulsion : MonoBehaviour
{

    Vector3 touchPos;
    public Rigidbody2D rb;
    public float magnitude = 0.2f;
    Camera camera;
    GameObject[] objects;

    private void Start()
    {
        camera = Camera.main;
        objects = GameObject.FindGameObjectsWithTag("ball");
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            touchPos = Input.mousePosition;
            touchPos = camera.ScreenToWorldPoint(touchPos);
            //transform.position = Vector2.Lerp(transform.position, touchPos, magnitude);

            rb.AddForce((transform.position - touchPos) * magnitude);
        }

        if (Input.GetMouseButton(1))
        {
            foreach (var obj in objects)
            {
                obj.GetComponent<Rigidbody2D>().AddForce((obj.transform.position - transform.position) * 8);
            }
        }

        if (Input.GetMouseButton(2))
        {
            foreach (var obj in objects)
            {
                obj.GetComponent<Rigidbody2D>().AddForce(-(obj.transform.position - transform.position) * 8);
            }
        }
    }
}
