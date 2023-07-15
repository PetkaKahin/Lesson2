public class SlowRunningState : BaseRunningState
{
    public SlowRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character) { }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = Config.SlowSpeed;
    }

    public override void Update()
    {
        base.Update();

        if (IsCtrlDown)
            return;

        StateSwitcher.SwitchState<RunningState>();
    }
}
