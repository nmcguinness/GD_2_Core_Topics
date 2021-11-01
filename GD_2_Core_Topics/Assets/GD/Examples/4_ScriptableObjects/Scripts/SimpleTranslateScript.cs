using GD.ScriptableTypes;
using UnityEngine;

/// <summary>
/// Translates a target object's RigidBody using either local or SO variable value
/// Objective:
/// - Demonstrate how a ScriptableObject (FloatVariable) can be shared across all game objects and changed (on some event) using method of FloatVariable
///
/// </summary>
public class SimpleTranslateScript : MonoBehaviour
{
    [SerializeField]
    private ListStringVariable levelObjectives;

    [SerializeField]
    private FloatReference moveSpeed;

    [SerializeField]
    [Range(1, 10)]
    private float triggerSpeedDelta = 1;

    [SerializeField]
    private LayerMask triggerLayerMask;

    //set in Awake using GetComponent
    private Rigidbody rb;

    // Called when the script is being loaded
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Called once every fixed update
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * moveSpeed.Value * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((1 << other.gameObject.layer & triggerLayerMask.value) != 0)
        {
            //adding to the shared SO value
            moveSpeed.Variable.Add(triggerSpeedDelta);
        }

        //Add code to Set() the value of the FloatVariable when the attached game object crosses the line
    }
}