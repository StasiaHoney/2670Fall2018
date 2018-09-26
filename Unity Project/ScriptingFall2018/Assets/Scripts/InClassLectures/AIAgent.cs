using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIAgent : MonoBehaviour
{

	private NavMeshAgent agent;
	public Transform Destination;
	public Transform PostPoint;
	private Transform finalDestiation;
	public FloatData Speed;
	
	
	void Start ()
	{
		
		agent = GetComponent<NavMeshAgent>();
		finalDestiation = transform;
		agent.speed = Speed.Value;
	}

	private void OnTriggerEnter(Collider obj)
	{
		if(obj.transform == Destination)
			finalDestiation = Destination;
	}

	private void OnTriggerExit(Collider obj)
	{
		finalDestiation = PostPoint;
	}

	private void Update()
	{
		agent.destination = finalDestiation.position;
	}
}
