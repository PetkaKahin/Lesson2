public class FastRunningState : BaseRunningState
{
    public FastRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character) { }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = Config.FastSpeed;
    }

    public override void Update()
    {
        base.Update();

        if (IsShiftDown)
            return;

        StateSwitcher.SwitchState<RunningState>();
    }
}
