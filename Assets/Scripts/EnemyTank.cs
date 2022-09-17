using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace OneHourJam386
{
    public class EnemyTank : MonoBehaviour
    {
        private NavMeshAgent _agent;

        private GameObject[] _flags;

        private Vector3 _target;

        private void Awake()
        {
            _agent = GetComponent<NavMeshAgent>();
            _flags = GameObject.FindGameObjectsWithTag("Flag");
        }

        private void SetTask()
        {
            var r = _flags[Random.Range(0, _flags.Length)];
            _agent.SetDestination(r.transform.position);
            _target = r.transform.position;
        }

        private void Start()
        {
            SetTask();
        }

        private void Update()
        {
            if (Vector3.Distance(transform.position, _target) < 2f)
            {
                SetTask();
            }
        }
    }
}