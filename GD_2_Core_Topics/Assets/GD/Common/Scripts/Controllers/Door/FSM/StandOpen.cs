using GD.State;

public class StandOpen : IState
{
    private FSMDoorController doorController;

    public StandOpen(FSMDoorController doorController)
    {
        this.doorController = doorController;
    }

    public void OnEnter()
    {
        doorController.IsToggleRequestReceived = false;
    }

    public void Update()
    {
    }

    public void OnExit()
    {
        doorController.currentDisplacement = 0;
    }
}