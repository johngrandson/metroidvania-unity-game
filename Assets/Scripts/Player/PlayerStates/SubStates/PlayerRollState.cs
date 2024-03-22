using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRollState : PlayerAbilityState
{
    private float currentVelocity = .5f;

    public PlayerRollState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();

        isAbilityDone = true;
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

        float targetVelocity = playerData.rollVelocity * player.FacingDirection;
        float smoothVelocity = Mathf.SmoothDamp(player.RB.velocity.x, targetVelocity, ref currentVelocity, playerData.rollSmoothTime);

        player.SetVelocityX(targetVelocity);
    }

    public override void Exit()
    {
        base.Exit();
    }
}
