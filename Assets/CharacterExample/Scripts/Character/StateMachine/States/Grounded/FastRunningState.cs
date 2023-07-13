public class FastRunningState : RunningState
{
    public FastRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character) { }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = Config.FastSpeed;
        Config.SetCurrentSpeed(Data.Speed);
    }
}
