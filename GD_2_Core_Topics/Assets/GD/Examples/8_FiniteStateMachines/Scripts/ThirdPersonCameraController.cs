using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target = null;

    [SerializeField]
    [Range(0.1f, 5)]
    private float lerpSpeed = 2;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, 0, target.position.z) + offset, Time.deltaTime * lerpSpeed);
    }
}