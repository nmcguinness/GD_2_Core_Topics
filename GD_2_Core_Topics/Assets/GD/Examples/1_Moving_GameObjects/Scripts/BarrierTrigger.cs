using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
    }
}