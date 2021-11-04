using ARVR.Ticks;
using GD.Ticks;
using UnityEngine;

public class ScaleChangeBehaviour : MonoBehaviour, IHandleTicks
{
    public void HandleTick()
    {
        Debug.Log($"Tick...{Time.realtimeSinceStartup}");
    }

    // This function is called when the behaviour becomes disabled or inactive
    private void OnDisable()
    {
        TimeTickSystem.Instance.UnregisterListener(
            TimeTickSystem.TickRateMultiplierType.Four, HandleTick);
    }

    // This function is called when the object becomes enabled and active
    private void OnEnable()
    {
        TimeTickSystem.Instance.RegisterListener(
            TimeTickSystem.TickRateMultiplierType.Four, HandleTick);
    }
}