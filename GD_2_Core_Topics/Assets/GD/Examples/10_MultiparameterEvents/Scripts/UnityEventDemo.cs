using System;
using UnityEngine;
using UnityEngine.Events;

public class PickupEventArgs : EventArgs
{
    public int value;
    public GameObject pickedUpObject;
}

public class GDUnityEvent : UnityEvent<EventArgs>
{
}

public class CustomUnityEvent : UnityEvent<string>
{
}

public class UnityEventDemo : MonoBehaviour
{
    private GDUnityEvent someEvent;
    private float timeSinceLastEventSecs;

    private void Start()
    {
        if (someEvent == null)
            someEvent = new GDUnityEvent();

        someEvent.AddListener(SomeFunction);
    }

    private void Update()
    {
        timeSinceLastEventSecs += Time.deltaTime;

        if (timeSinceLastEventSecs > 2)
        {
            timeSinceLastEventSecs -= 2;
            someEvent.Invoke(new PickupEventArgs());
        }
    }

    private void SomeFunction(EventArgs gameEventArgs)
    {
        Debug.Log(gameEventArgs);
    }
}

/*
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
*/