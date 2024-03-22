using UnityEngine;

[CreateAssetMenu(fileName = "New NPC Data", menuName = "Data/NPC Data/Base Data")]
public class NPCData : ScriptableObject
{
    [Header("Move State")]
    public float movementVelocity = 1f;
    public float movementCooldown = 6f;
}
