using UnityEngine;

public class NPCState
{
    protected NPC npc;
    protected NPCStateMachine stateMachine;
    protected NPCData npcData;

    protected bool isAnimationFinished;
    protected float startTime;

    private string animBoolName;

    public NPCState(NPC npc, NPCStateMachine stateMachine, NPCData npcData, string animBoolName)
    {
        this.npc = npc;
        this.stateMachine = stateMachine;
        this.npcData = npcData;
        this.animBoolName = animBoolName;
    }

    public virtual void Enter()
    {
        DoChecks();
        npc.Animator.SetBool(animBoolName, true);
        startTime = Time.time;
        isAnimationFinished = false;
    }

    public virtual void Exit()
    {
        npc.Animator.SetBool(animBoolName, false);
    }

    public virtual void LogicUpdate()
    {

    }

    public virtual void PhysicsUpdate()
    {
        DoChecks();
    }

    public virtual void DoChecks() { }
}
