using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float forceUp;
    public float maxVelocity;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void ForceUp()
    {
        rb.AddForce( forceUp*new Vector3(0, 1, 0), ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision other)
    {
        ForceUp();
    }
    private void Update()
    {
        Vector3 currentVelocity = rb.velocity;
        currentVelocity.y = Mathf.Min(currentVelocity.y, maxVelocity);
        rb.velocity = currentVelocity;
        Debug.Log(rb.velocity.y);
    }
}
