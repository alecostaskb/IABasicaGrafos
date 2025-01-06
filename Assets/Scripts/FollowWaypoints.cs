using UnityEngine;
using UnityEngine.AI;

public class FollowWaypoints : MonoBehaviour
{
    public GameObject wpManager;
    private GameObject[] waitPoints;
    private GameObject currentNode;

    private NavMeshAgent navAgent;

    private void Start()
    {
        Time.timeScale = 5.0f;
        waitPoints = wpManager.GetComponent<WPManager>().waypoints;
        currentNode = waitPoints[0];

        navAgent = GetComponent<NavMeshAgent>();
    }

    public void GotoRuin()
    {
        navAgent.SetDestination(waitPoints[1].transform.position);
    }

    public void GotoRock()
    {
        navAgent.SetDestination(waitPoints[3].transform.position);
    }

    public void GotoHeli()
    {
        navAgent.SetDestination(waitPoints[2].transform.position);
    }

    public void GotoFactory()
    {
        navAgent.SetDestination(waitPoints[0].transform.position);
    }
}