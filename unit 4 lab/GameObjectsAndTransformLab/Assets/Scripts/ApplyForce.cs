using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    private Rigidbody _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(Vector3.right * 500);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.name);
    }
}
