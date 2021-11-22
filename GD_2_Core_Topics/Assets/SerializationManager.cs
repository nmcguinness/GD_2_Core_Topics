using GD.Utilities;
using System.Collections.Generic;
using UnityEngine;

public class SerializationManager : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int x = 10;

        int newValue = x.DoSomething(10, true);

        var dataOut = new DemoSerializationTransform(new Vector3(1, 2, 3),
            new Vector3(4, 5, 6), new Vector3(10, 11, 12));
        SerializationUtility.Save("transform_data.xml", dataOut);

        var dataIn = SerializationUtility.Load("transform_data.xml",
            typeof(DemoSerializationTransform)) as DemoSerializationTransform;

        Debug.Log(dataIn);

        List<DemoSerializationTransform> list;

        var dataIn2 = SerializationUtility.Load("transform_data_list.xml",
            typeof(List<DemoSerializationTransform>))
            as List<DemoSerializationTransform>;
    }
}