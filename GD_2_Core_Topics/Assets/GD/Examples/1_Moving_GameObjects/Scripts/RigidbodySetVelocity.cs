using UnityEngine;

//NYC

public class RigidbodySetVelocity : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Set the magnititude of the force applied in the local forward direction")]
    [Range(1, 500)]
    private float forceMultiplier = 500;

    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Called when the script is being loaded
    private void Awake()
    {
        //rb = GetComponent<Rigidbody>();
        //rb.velocity = transform.forward * Time.deltaTime * forceMultiplier;
        GetComponent<Rigidbody>().velocity = transform.forward * Time.deltaTime * forceMultiplier;
    }

    // Called once every fixed update (based on refresh rate of Physics system - see Edit/Project Settings/Time)
    private void FixedUpdate()
    {
    }
}