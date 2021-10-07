using UnityEngine;

//NYC
public class RigidbodyAddForce : MonoBehaviour
{
    [Header("hgfhgf")]
    [Space]
    [SerializeField]
    [Tooltip("Set the magnititude of the force applied in the local forward direction")]
    [Range(1, 200)]
    private float forceMultiplier = 100;

    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Called when the script is being loaded
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        //#if UNITY_EDITOR
        //        Debug.Log("sdfsdf");
        //#endif
    }

    // Called once every fixed update (based on refresh rate of Physics system - see Edit/Project Settings/Time)
    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * forceMultiplier * Time.deltaTime); //ForceMode?
    }
}