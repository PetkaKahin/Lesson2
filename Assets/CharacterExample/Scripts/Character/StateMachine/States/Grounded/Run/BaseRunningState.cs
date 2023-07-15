public class BaseRunningState : GroundedState
{
    private const float KeyDown = 1;

    protected MovementStateConfig Config;

    public BaseRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => Config = character.Config.RunningStateConfig;

    public override void Enter()
    {
        base.Enter();

        View.StartRunning();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizonatalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }

    public bool IsShiftDown => Input.Movement.FastRun.ReadValue<float>() == KeyDown;
    public bool IsCtrlDown => Input.Movement.SlowRun.ReadValue<float>() == KeyDown;
}
