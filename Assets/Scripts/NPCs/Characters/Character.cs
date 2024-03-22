using System.Collections;
using UnityEngine;

public class Character : NPC
{
    public NPCIdleState IdleState { get; private set; }
    public NPCMoveState MoveState { get; private set; }

    [Header("State Variables")]
    [SerializeField] protected NPCData npcData;
    [SerializeField] public Transform[] waypoints;
    private int currentWaypointIndex;


    protected override void Awake()
    {
        base.Awake();

        IdleState = new NPCIdleState(this, StateMachine, npcData, "idle");
        MoveState = new CharacterMoveState(this, StateMachine, npcData, "move");
    }

    protected override void Start()
    {
        base.Start();

        StateMachine.Initialize(IdleState);
        StartCoroutine(ChangeStateEveryXSeconds(npcData.movementCooldown));
    }

    private IEnumerator ChangeStateEveryXSeconds(float seconds)
    {
        while (true)
        {
            yield return new WaitForSeconds(seconds);

            if (StateMachine.CurrentState == MoveState)
            {
                if (Mathf.Abs(waypoints[currentWaypointIndex].position.x - transform.position.x) < 0.1f)
                {
                    StateMachine.ChangeState(IdleState);
                }
            }
            else if (StateMachine.CurrentState == IdleState)
            {
                StateMachine.ChangeState(MoveState);
            }
        }
    }

    public void UpdateCurrentWaypointIndex()
    {
        currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
    }

    public int CurrentWaypointIndex
    {
        get { return currentWaypointIndex; }
    }

}