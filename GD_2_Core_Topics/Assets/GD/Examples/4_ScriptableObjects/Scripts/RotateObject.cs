using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private FloatVariable rotationAngle;     //private float rotationAngle = 1;

    [SerializeField]
    private Vector3 rotationAxis = Vector3.up;

    // Update is called once per frame
    private void Update()
    {
        target.Rotate(rotationAxis, rotationAngle.Value);
    }
}