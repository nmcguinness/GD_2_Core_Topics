using GD.ScriptableTypes;
using UnityEngine;

/// <summary>
/// Parameters used to translate a door along a user-defined direction
/// </summary>
/// <see cref="https://docs.unity3d.com/ScriptReference/AnimationCurve-ctor.html"/>
[CreateAssetMenu(menuName = "Scriptable Objects/Parameters/Door/Translation")]
public class DoorTranslationParameters : ScriptableGameObject
{
    [Tooltip("Amount by which to translate door each update ")]
    [Range(0.01f, 0.5f)]
    public float increment = 0.02f;

    [Tooltip("Maximum amount by which to translate door")]
    [Range(0.25f, 100)]
    public float maximum = 2;

    [Tooltip("Normalised direction in which to translate door")]
    public Vector3 direction = Vector3.up;

    [Tooltip("Curve used to ease door open")]
    public AnimationCurve easeOpenCloseCurve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
}