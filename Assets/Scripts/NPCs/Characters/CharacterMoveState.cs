using UnityEngine;

public class CharacterMoveState : NPCMoveState
{
    private Character character;

    public CharacterMoveState(Character npc, NPCStateMachine stateMachine, NPCData npcData, string animBoolName) : base(npc, stateMachine, npcData, animBoolName)
    {
        character = npc;
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        float direction = Mathf.Sign(character.waypoints[character.CurrentWaypointIndex].position.x - character.transform.position.x);

        if (direction != character.FacingDirection)
        {
            character.Flip();
            character.SetVelocityX(npcData.movementVelocity * character.FacingDirection);
        }

        character.SetVelocityX(npcData.movementVelocity * direction);

        if (Mathf.Abs(character.waypoints[character.CurrentWaypointIndex].position.x - character.transform.position.x) < 0.1f)
        {
            character.StateMachine.ChangeState(character.IdleState);
            character.UpdateCurrentWaypointIndex();
        }
    }
}