using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class FlyMovement : MonoBehaviour
{
    [SerializeField] float flyUp = 100f;
    [SerializeField] float flyDown = -50f;
    [SerializeField] float flyStraight = 100f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProcessFlyUp();
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
}
