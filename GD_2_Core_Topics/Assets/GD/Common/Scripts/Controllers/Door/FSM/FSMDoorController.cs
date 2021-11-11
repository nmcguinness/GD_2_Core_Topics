using GD.State;
using System;
using UnityEngine;

public class FSMDoorController : MonoBehaviour
{
    //accessible to the inspector and IStates
    [Tooltip("Instance of DoorTranslationParameters used to open/close door")]
    public DoorTranslationParameters movementParameters;

    //accessible to the IStates
    [HideInInspector]
    public float currentDisplacement = 0;

    //accessible to the IStates
    [HideInInspector]
    public Vector3 displacedPosition;

    //accessible to the IStates
    [HideInInspector]
    public bool IsToggleRequestReceived;

    //hidden from inspector and IStates
    private StateMachine stateMachine;

    private void Awake()
    {
        stateMachine = new StateMachine();

        var closed = new StandClosed(this);
        var opening = new OpeningDoor(this);
        var opened = new StandOpen(this);
        var closing = new ClosingDoor(this);

        stateMachine.AddTransition(closed, opening, HasReceivedOpenRequest());

        stateMachine.AddTransition(opening, opened, HasFullyDisplaced());
        stateMachine.AddTransition(opened, closing, HasReceivedCloseRequest());
        stateMachine.AddTransition(closing, closed, HasFullyDisplaced());

        Func<bool> HasReceivedOpenRequest() => () => IsToggleRequestReceived;
        Func<bool> HasReceivedCloseRequest() => () => IsToggleRequestReceived;
        Func<bool> HasFullyDisplaced() => () => currentDisplacement >= movementParameters.maximum;

        stateMachine.SetState(closed);
    }

    private bool HasReceivedOpenRequest()
    {
        return IsToggleRequestReceived;
    }

    private void Update()
    {
        stateMachine.Update();
    }

    public void HandleDoorToggle()
    {
        IsToggleRequestReceived = true;
    }
}