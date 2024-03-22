using System.Collections;
using UnityEngine;

public class NPC : MonoBehaviour
{
    #region State Variables
    public NPCStateMachine StateMachine { get; private set; }
    public int FacingDirection { get; private set; }
    #endregion

    #region Components
    public Animator Animator { get; private set; }
    #endregion

    #region Other Variables
    public Vector2 CurrentVelocity { get; private set; }
    #endregion

    #region Unity Callback Functions
    protected virtual void Awake()
    {
        StateMachine = new NPCStateMachine();
    }

    protected virtual void Start()
    {
        Animator = GetComponent<Animator>();

        FacingDirection = 1;
    }

    protected virtual void Update()
    {
        if (StateMachine != null && StateMachine.CurrentState != null)
        {
            StateMachine.CurrentState.LogicUpdate();
        }
    }

    protected virtual void FixedUpdate()
    {
        if (StateMachine != null && StateMachine.CurrentState != null)
        {
            StateMachine.CurrentState.PhysicsUpdate();
        }
    }
    #endregion

    #region Set Functions
    public void SetVelocityX(float velocity)
    {
        CurrentVelocity = new Vector2(velocity, CurrentVelocity.y);
    }
    
    public void Flip()
    {
        FacingDirection *= -1;

        transform.Rotate(0.0f, 180.0f, 0.0f);
    }
    #endregion
}
