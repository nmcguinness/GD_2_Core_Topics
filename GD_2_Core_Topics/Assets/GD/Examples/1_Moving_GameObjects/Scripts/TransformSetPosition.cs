using UnityEngine;

//NYC
public class TransformSetPosition : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        //gfx runs at 60Hz so deltaTime = 1/60 = 0.016 = 16ms
        //gfx runs at 100Hz so deltaTime = 1/100 = 0.01 = 10ms
        transform.position += transform.forward * Time.deltaTime;

        //Debug.Log(transform.position);
    }

    private void FixedUpdate()
    {
        //physics related changes to velocity, force, drag etc
    }
}