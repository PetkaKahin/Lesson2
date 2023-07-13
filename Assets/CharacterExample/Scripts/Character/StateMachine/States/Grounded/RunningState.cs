public class RunningState : GroundedState
{
    protected RunningStateConfig Config;

    public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => Config = character.Config.RunningStateConfig;

    public override void Enter()
    {
        base.Enter();

        View.StartRunning();
        Data.Speed = Config.Speed;
        Config.SetCurrentSpeed(Data.Speed);
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (Input.Movement.FastRun.ReadValue<float>() == 1)
            StateSwitcher.SwitchState<FastRunningState>();

        if (Input.Movement.SlowRun.ReadValue<float>() == 1)
            StateSwitcher.SwitchState<SlowRunningState>();

        if (IsHorizonatalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }
}
