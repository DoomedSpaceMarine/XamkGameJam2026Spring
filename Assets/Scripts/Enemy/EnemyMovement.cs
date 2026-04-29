using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    
    [SerializeField] Transform player;

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
    }
}
