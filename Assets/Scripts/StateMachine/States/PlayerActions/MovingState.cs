//using System.Collections;
//using UnityEngine;
//using UnityEngine.InputSystem;

//public class MovingState : State<PlayerState>
//{
//    public MovingState(Player2 player, InputSystem inputSystem, StateMachine<PlayerState> stateMachine, PlayerState playerState) : base(player, inputSystem, stateMachine, PlayerState.Moving)
//    {
//    }

//    public override IEnumerator Move(InputAction.CallbackContext context)
//    {
//        Vector2 inputVector = context.ReadValue<Vector2>();
//        Player2.moveInput = inputVector.x;

//        if (Player.moveInput < 0)
//        {
//            Player.Transform.localScale = new Vector3(-Mathf.Abs(Player.Transform.localScale.x), Player.Transform.localScale.y, Player.Transform.localScale.z);
//        }
//        else if (Player.moveInput > 0)
//        {
//            Player.Transform.localScale = new Vector3(Mathf.Abs(Player.Transform.localScale.x), Player.Transform.localScale.y, Player.Transform.localScale.z);
//        }

//        yield break;
//    }
//}
