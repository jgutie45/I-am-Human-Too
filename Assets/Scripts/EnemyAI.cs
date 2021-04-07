using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Basic
    public float rotationSpeed = 60f;
    List<Transform> visibleTargets;
    public UnityEngine.AI.NavMeshAgent agent;
    public Transform player;
    public LayerMask Player;

    // Patrolling
    [HideInInspector]
    public Vector3 patrollingSpot;
    bool atPatrollingSpot;

    // Attacking
    public float timeBetweenAttacks = 1f;
    bool alreadyAttacked;

    // States
    public float attackRange = 1.25f;
    bool playerInAttackRange;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        visibleTargets = GetComponent<FieldOfView>().visibleTargets;
        // patrollingSpot = new Vector3(11f, transform.position.y, 2f);
        patrollingSpot = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, Player);

        // player is not insight nor in attack range
        if(visibleTargets.Count == 0 && !playerInAttackRange) Patrolling();
        // player within sight, but not in attack range, should chase player now
        if(visibleTargets.Count != 0 && !playerInAttackRange) ChasePlayer();
        // player in sight and in attack range, hit him now
        if(visibleTargets.Count != 0 && playerInAttackRange) AttackPlayer();

    }

    private void Patrolling()
    {
        Vector3 dis2patrollingSpot = transform.position - patrollingSpot;
        if(dis2patrollingSpot.magnitude < 1f)
        {
            // Debug.Log("AI at the patrolling spot");
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        else
        {
            // back to the patrolling spot
            agent.SetDestination(patrollingSpot);
        }
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    private void AttackPlayer()
    {
        // Make sure enemy doesn't move
        agent.SetDestination(transform.position);
        // Approching to player
        transform.LookAt(player);

        if(!alreadyAttacked) 
        {
            // TODO: knock down the player(zombie)
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    // Editor visualization helper
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
