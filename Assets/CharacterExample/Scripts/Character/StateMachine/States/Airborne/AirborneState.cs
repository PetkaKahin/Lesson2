using UnityEngine;

public class AirborneState : MovementState
{
    private AirborneStateConfig _airborneStateConfig;

    public AirborneState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    {
        _airborneStateConfig = character.Config.AirborneStateConfig;
    }

    public override void Enter()
    {
        base.Enter();

        Data.Speed = Data.Speed;

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
