using UnityEngine;

//NYC
public class RigidbodyAddForce : MonoBehaviour
{
   
    [Space]
    [SerializeField]
    [Tooltip("Set the magnititude of the force applied in the local forward direction")]
    [Range(1, 200)]
    private float forceMultiplier = 100;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Called when the script is being loaded
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Called once every fixed update (based on refresh rate of Physics system - see Edit/Project Settings/Time)
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * forceMultiplier * Time.deltaTime); //ForceMode?
    }
}
