using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playermovement : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Input.GetKeyDown(KeyCode.F))
            {
                Invoke("",0.1f);
                navMeshAgent.SetDestination(new Vector3(transform.position.x, transform.position.y, transform.position.z));
            }
            if (Physics.Raycast(ray, out hit, 100))
            {
                navMeshAgent.SetDestination(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            }
        }
    }
}
