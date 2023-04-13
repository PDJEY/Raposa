using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * speed*Time.deltaTime, Input.GetAxis("Vertical") * speed*Time.deltaTime, 0);

        controller.Move(movement);
    }
}
