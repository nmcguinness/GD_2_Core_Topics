using UnityEngine;

public class UITextController : MonoBehaviour
{
    [SerializeField]
    private GameObject textObject;

    private TextAsset textAsset;

    // Start is called before the first frame update
    private void Start()
    {
        textAsset = textObject.GetComponent<TextAsset>();
    }
}