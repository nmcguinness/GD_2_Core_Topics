using GD.State;

public class StandClosed : IState
{
    private FSMDoorController doorController;

    public StandClosed(FSMDoorController doorController)
    {
        this.doorController = doorController;
    }

    public void OnEnter()
    {
        doorController.currentDisplacement = 0;
        doorController.IsToggleRequestReceived = false;
    }

    public void Update()
    {
    }

    public void OnExit()
    {
    }
}