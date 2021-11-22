using UnityEngine;
using UnityEngine.Events;

public class UnityEventDemo : MonoBehaviour
{
    private UnityEvent someEvent;
    private float timeSinceLastEventSecs;

    private void Start()
    {
        if (someEvent == null)
            someEvent = new UnityEvent();

        someEvent.AddListener(SomeFunction);
    }

    private void Update()
    {
        timeSinceLastEventSecs += Time.deltaTime;

        if (timeSinceLastEventSecs > 2)
        {
            timeSinceLastEventSecs -= 2;
            someEvent.Invoke();
        }
    }

    private void SomeFunction()
    {
        Debug.Log("Something happened...");
    }
}