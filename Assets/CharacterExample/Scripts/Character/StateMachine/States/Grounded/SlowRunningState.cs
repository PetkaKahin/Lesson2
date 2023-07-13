public class SlowRunningState : RunningState
{
    public SlowRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character) { }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = Config.SlowSpeed;
        Config.SetCurrentSpeed(Data.Speed);
    }
}
