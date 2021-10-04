using UnityEngine;

//NYC
public class TransformTranslate : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
