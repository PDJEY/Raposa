using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject ground;
    public float speed = 10f;
    public float jumpF = 10f;
    public float gravity = 100f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ground = GetComponent<GameObject>();
    }

    void Update()
    {
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");
        Debug.Log(hMove);
        rb.velocity = new Vector3(-(hMove * speed), rb.velocity.y, -(vMove * speed));
    }
    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
