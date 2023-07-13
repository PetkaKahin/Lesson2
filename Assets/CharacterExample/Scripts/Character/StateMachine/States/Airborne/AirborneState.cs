using UnityEngine;

public class AirborneState : MovementState
{
    private AirborneStateConfig _airborneStateConfig;
    private RunningStateConfig _runningStateConfig;

    public AirborneState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    {
        _airborneStateConfig = character.Config.AirborneStateConfig;
        _runningStateConfig = character.Config.RunningStateConfig;
    }
        

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _runningStateConfig.CurrentSpeed;

        View.StartAirborne();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopAirborne();
    }

    public override void Update()
    {
        base.Update();

        Data.YVelocity -= _airborneStateConfig.BaseGravity * Time.deltaTime;
    }
}
