using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField]
    private Transform transform;

    [SerializeField]
    private FloatVariable rotationAngle;     //private float rotationAngle = 1;

    [SerializeField]
    private Vector3 rotationAxis = Vector3.up;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(rotationAxis, rotationAngle.Value);
    }
}