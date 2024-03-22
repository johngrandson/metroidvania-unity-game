using UnityEngine;

public class NPCMoveState : NPCGroundedState
{
    public NPCMoveState(NPC npc, NPCStateMachine stateMachine, NPCData npcData, string animBoolName) : base(npc, stateMachine, npcData, animBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

        npc.transform.position += new Vector3(npc.CurrentVelocity.x, npc.CurrentVelocity.y, 0) * Time.fixedDeltaTime;
    }
}
