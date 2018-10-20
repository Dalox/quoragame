using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkControl : MonoBehaviour {

	public Transform[] points;
	private int destPoint;
	private UnityEngine.AI.NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		agent.autoBraking = false;
		GotoNextPoint();
	}

	void GotoNextPoint(){
		if (points.Length == 0)
		{
			return;
		}

		agent.destination = points[destPoint].position;

		destPoint = (destPoint + 1) % points.Length;
	}
	
	// Update is called once per frame
	void Update () {
		if(!agent.pathPending && agent.remainingDistance < 0.5f){
			GotoNextPoint();
		}
	}
}
