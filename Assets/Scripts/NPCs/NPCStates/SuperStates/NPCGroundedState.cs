public class NPCGroundedState : NPCState
{
    public NPCGroundedState(NPC npc, NPCStateMachine stateMachine, NPCData npcData, string animBoolName) : base(npc, stateMachine, npcData, animBoolName)
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
    }
}
