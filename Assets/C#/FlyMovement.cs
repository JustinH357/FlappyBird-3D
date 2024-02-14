using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class FlyMovement : MonoBehaviour
{
    [SerializeField] float flyUp = 100f;
    [SerializeField] float flyDown = -50f;
    [SerializeField] float flyStraight = 10f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //StartFlyingStraight();
    }

    void Update()
    {
        ProcessFlyUp();
        rb.velocity = new Vector3 (flyStraight,0,0);
    }

    // want user to press key to go up
    void ProcessFlyUp() {
        if (Input.GetKey(KeyCode.Space)) {
            StartFlyingUp();
        } 
        else {
            StartFlyingDown();
        }
    }

    void StartFlyingUp() {
        rb.AddRelativeForce(Vector3.up * flyUp * Time.deltaTime);
    }

    void StartFlyingDown() {
        rb.AddRelativeForce(Vector3.up * flyDown * Time.deltaTime);
    }

    // void StartFlyingStraight() {
    //     (Vector3.right * flyStraight * Time.deltaTime);
    // }
}
