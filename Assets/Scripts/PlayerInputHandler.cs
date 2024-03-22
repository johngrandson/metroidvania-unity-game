using UnityEngine.InputSystem;
using UnityEngine;
using System.Collections;

public class PlayerInputHandler : MonoBehaviour
{    
    public Vector2 RawMovementInput { get; private set; }
    public int NormalizedInputX { get; private set; }
    public int NormalizedInputY { get; private set; }
    public bool JumpInput { get; private set; }
    public bool RollInput { get; private set; }

    [SerializeField] private float inputHoldTime = 0.2f;
    [SerializeField] private float rollCooldown = 4f;

    private float jumpInputStartTime;
    private float rollInputStartTime;
    private float nextRollTime;
    private bool canRoll = true;

    private void Update()
    {
        CheckJumpInputHoldsTime();
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        RawMovementInput = context.ReadValue<Vector2>();

        NormalizedInputX = (int)(RawMovementInput * Vector2.right).normalized.x;
        NormalizedInputY = (int)(RawMovementInput * Vector2.up).normalized.y;
    }
    public void OnJumpInput(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            JumpInput = true;
            jumpInputStartTime = Time.time;
        }
    }

    public void UseJumpInput() => JumpInput = false;

    private void CheckJumpInputHoldsTime()
    {
        if (Time.time >= jumpInputStartTime + inputHoldTime)
        {
            JumpInput = false;
        }
    }

    public void OnAttackInput(InputAction.CallbackContext context)
    {
    }

    public void OnDashInput(InputAction.CallbackContext context)
    {
    }

    public void OnRollInput(InputAction.CallbackContext context)
    {
        bool isGrounded = GetComponent<Player>().CheckIfGrounded();

        if (canRoll && isGrounded)
        {
            RollInput = true;
            StartCoroutine(RollCooldown());
            nextRollTime = Time.time + rollCooldown;
        }
    }

    public void SetRollInputToFalse() => RollInput = false;

    public bool CanRoll() => canRoll;

    public float GetRollRemainingCooldown()
    {
        float remaining = nextRollTime - Time.time;
        return Mathf.Max(remaining, 0);
    }

    public bool CheckRollCooldown()
    {
        if (Time.time - rollInputStartTime > rollCooldown)
        {
            return true;
        }

        return false;
    }

    public IEnumerator RollCooldown()
    {
        canRoll = false;

        yield return new WaitForSeconds(rollCooldown);

        canRoll = true;
    }
}
