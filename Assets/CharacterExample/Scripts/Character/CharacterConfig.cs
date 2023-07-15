using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private MovementStateConfig _runningStateConfig;
    [SerializeField] private AirborneStateConfig _airborneStateConfig;

    public AirborneStateConfig AirborneStateConfig => _airborneStateConfig;
    public MovementStateConfig RunningStateConfig => _runningStateConfig;
}
