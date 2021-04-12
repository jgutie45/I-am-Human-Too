using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI_Random : MonoBehaviour
{
    // Basic
    public float rotationSpeed = 60f;
    List<Transform> visibleTargets;
    public UnityEngine.AI.NavMeshAgent agent;
    [HideInInspector]
    public GameObject player;
    public LayerMask Player, whatIsGround;
    public int damageToPlayer = 1;

    // Patrolling
    [HideInInspector]
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    // Attacking
    public float timeBetweenAttacks = 1f;
    bool alreadyAttacked;

    // States
    public float attackRange = 1.25f;
    bool playerInAttackRange;
    
    private void Awake()
    {
        player = GameObject.Find("Player");
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        visibleTargets = GetComponent<FieldOfView>().visibleTargets;
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
        if (!walkPointSet) SearchWalkPoint();
        if (walkPointSet) agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        // Walkpoint reached, then set false, find another walkpoint
        if (distanceToWalkPoint.magnitude < 1f) walkPointSet = false;
    }

    private void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        // Check if random walkpoint is out side of map
        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround)) walkPointSet = true;
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.transform.position);
    }

    private void AttackPlayer()
    {
        // Make sure enemy doesn't move
        agent.SetDestination(transform.position);
        // Approching to player
        transform.LookAt(player.transform);

        if(!alreadyAttacked) 
        {
            // TODO: knock down the player(zombie)
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
            player.GetComponent<PlayerMovement>().TakeDamage(damageToPlayer);
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
