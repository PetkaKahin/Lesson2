public class RunningState : BaseRunningState
{
    public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character) { }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = Config.Speed;
    }

    public override void Update()
    {
        base.Update();

        if (IsShiftDown)
            StateSwitcher.SwitchState<FastRunningState>();

        if (IsCtrlDown)
            StateSwitcher.SwitchState<SlowRunningState>();
    }
}
