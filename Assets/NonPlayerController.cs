using UnityEngine;
using UnityEngine.AI;

public class NonPlayerController : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CastRay", 2.0f, 0.7f);
    }

    // Update is called once per frame
    void CastRay()
    {
        // random ray cast
        Ray ray = cam.ScreenPointToRay(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit)) {
            agent.SetDestination(hit.point);
        }

        
    }

}
