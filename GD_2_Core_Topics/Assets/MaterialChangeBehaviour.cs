using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChangeBehaviour : MonoBehaviour
{
    private Material material;

    // Start is called before the first frame update
    private void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    public void SetSomethingElse(string name, int value, bool target)
    {
    }

    public void SetMaterial()
    {
        material.color = Color.red;
    }
}