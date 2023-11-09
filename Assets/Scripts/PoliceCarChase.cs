using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class PoliceCarChase : MonoBehaviour
{
    public NavMeshAgent agent; // 경찰차의 NavMeshAgent 컴포넌트
    public Transform target; // 플레이어 자동차의 Transform
    public float refreshTargetDuration = 3.0f;
    public float policeLifetime = 15.0f;

    private void Start()
    {
        StartCoroutine(SetTarget());
    }

    public IEnumerator SetTarget()
    {
        while (policeLifetime > 0)
        {
            agent.SetDestination(target.position);
            policeLifetime -= refreshTargetDuration;
            yield return new WaitForSeconds(refreshTargetDuration);
        }
        gameObject.SetActive(false);
    }
}