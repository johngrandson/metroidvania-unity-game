using UnityEngine;

[CreateAssetMenu(fileName = "New Player Data", menuName = "Data/Player Data/Base Data")]
public class PlayerData : ScriptableObject
{
    [Header("Move State")]
    public float movementVelocity = 4f;

    [Header("Jump State")]
    public float jumpVelocity = 9f;
    public int amountOfJumps = 2;

    [Header("Roll State")]
    public float rollVelocity = 5f;
    public float rollSmoothTime = 0.05f;

    [Header("Check Variables")]
    public float groundCheckRadius = 0.3f;
    public LayerMask whatIsGround;
}
