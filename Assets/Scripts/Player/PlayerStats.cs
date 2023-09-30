using UnityEngine;

[CreateAssetMenu(fileName = "Player Stats", menuName = "Player/PlayerStats", order = 1)]
public class PlayerStats : ScriptableObject
{
    public float life = 100;
    [Space(10)]
    public ForceMode forceMode = ForceMode.Acceleration;
    public float speedForward = 40;
    public float speedDirections = 20;
    public float speedUp = 30;
    public float speedDown = 30;
    //[Space(10)]
    
}