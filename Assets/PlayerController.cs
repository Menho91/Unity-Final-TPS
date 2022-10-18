using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 5f;
    float gravity = 5f;
    Transform Cam;
    Vector3 CamForward, CamRight;

    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -20)
        {
            transform.position = new Vector3(50, 1, 5);
        }
        CamForward = Vector3.Scale(Cam.forward, new Vector3(1, 0, 1)).normalized;
        CamRight = Vector3.Scale(Cam.right, new Vector3(1, 0, 1)).normalized;
        if (Input.GetKey(KeyCode.A) == true)
        {
            transform.Translate(-CamRight * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.Translate(CamRight * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W) == true)
        {
            transform.Translate(CamForward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            transform.Translate(-CamForward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space) == true)
        {
            transform.Translate(Vector3.up * gravity * Time.deltaTime);
        }

    }
}
