using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    //public Camera camera;
    //private NavMeshAgent agent;
    //public NavMeshSurface surface;

    //void Start()
    //{
    //    agent = GetComponent<NavMeshAgent>();
    //    surface.transform.position = agent.transform.position;
    //    surface.BuildNavMesh();
    //}

    //void Update()
    //{
    //    if(Input.GetMouseButtonDown(0))
    //    {
    //        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;

    //        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
    //        {
    //            agent.SetDestination(hit.point);
    //        }
    //    }

    //    if(Vector3.Distance(transform.position, surface.transform.position) > 20f)
    //    {
    //        surface.transform.position = agent.transform.position;
    //        surface.BuildNavMesh();
    //    }
    //}

    private NavMeshAgent agent;
    public Transform[] points;
    private int index;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(points[index].position);
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, points[index].position) < 1.5f)
        {
            index++;
            if (index >= points.Length)
                index = 0;

            agent.SetDestination(points[index].position);
        }
    }

}
