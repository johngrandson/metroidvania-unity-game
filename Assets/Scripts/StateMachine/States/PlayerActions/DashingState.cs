//using System.Collections;

//public class DashingState : State<PlayerState>
//{
//    public DashingState(Player player, InputSystem inputSystem, StateMachine<PlayerState> stateMachine)
//        : base(player, inputSystem, stateMachine, PlayerState.Dashing)
//    {
//    }

//    public override IEnumerator Dash()
//    {
//        if (!Player.isGrounded)
//        {
//            if (StateType == PlayerState.Falling)
//                yield break;

//            StateMachine.SetState(this);

//            Player.animator.SetTrigger("Dash");

//        }

//        yield break;
//    }
//}
