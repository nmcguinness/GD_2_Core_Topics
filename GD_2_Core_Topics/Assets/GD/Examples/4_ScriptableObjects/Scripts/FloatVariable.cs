using UnityEngine;

[CreateAssetMenu(
    fileName = "FloatVariable",
    menuName = "DKIT/Types/FloatVariable",
    order = 1)]
public class FloatVariable : ScriptableObject
{
    [SerializeField]
    private float value;

    public float Value
    {
        get
        {
            return this.value;
        }
    }
}

[System.Serializable]
internal class Weapon
{
}

//bool, Vector3, List<Weapon>