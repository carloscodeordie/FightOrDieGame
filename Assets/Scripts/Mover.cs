using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target != null) {
            GetComponent<NavMeshAgent>().SetDestination(target.position);
        }
    }
}
