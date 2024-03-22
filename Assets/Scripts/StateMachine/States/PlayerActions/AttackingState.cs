//using System.Collections;

//public class AttackingState : State<PlayerState>
//{
//    public AttackingState(Player player, InputSystem inputSystem, StateMachine<PlayerState> stateMachine)
//        : base(player, inputSystem, stateMachine, PlayerState.Attacking)
//    {
//    }

//    public override IEnumerator Attack()
//    {
//        if (Player.isGrounded)
//        {
//            Player.moveInput = 0;
//            Player.animator.SetTrigger("Attack");
//        }
        
//        yield break;
//    }
//}
