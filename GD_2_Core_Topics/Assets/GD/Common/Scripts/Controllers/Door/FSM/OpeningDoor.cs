using GD.State;
using UnityEngine;

public class OpeningDoor : IState
{
    private FSMDoorController doorController;

    public OpeningDoor(FSMDoorController doorController)
    {
        this.doorController = doorController;
    }

    public void OnEnter()
    {
        doorController.displacedPosition = doorController.transform.position;
    }

    public void Update()
    {
        doorController.currentDisplacement += doorController.movementParameters.increment;
        var easedIncrement = doorController.movementParameters.increment *
                        doorController.movementParameters.easeOpenCloseCurve.Evaluate(
                            doorController.currentDisplacement / doorController.movementParameters.maximum);

        doorController.transform.Translate(doorController.movementParameters.direction * easedIncrement, Space.Self);
    }

    public void OnExit()
    {
    }
}