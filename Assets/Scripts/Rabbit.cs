using UnityEngine;
using UnityEngine.AI;

public class Rabbit : MonoBehaviour
{
    private NavMeshAgent nav;
    private Transform target;
    private Animator ani;

    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("PlayerCapsule").transform;
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        nav.SetDestination(target.position);

        if (nav.remainingDistance <= 1.5f)
        {
            ani.SetBool("¦º¤`", true);
            nav.isStopped = true;
        }
    }
}
