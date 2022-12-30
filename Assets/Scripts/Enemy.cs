using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent myAgent;
    private float distance;
    private Animator myAnimator;
    public Transform target;


    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        distance = Vector3.Distance(target.position, transform.position);
        if (distance > 10)
        {
            myAgent.enabled = false;
            myAnimator.Play("Idle_SwordShield");
        }
        else if(1.5f < distance && distance < 10)
        {
            myAgent.enabled = true;
            myAgent.SetDestination (target.position);
            myAnimator.Play("Run_SwordShield");
        }
        else if(distance <= 1.5f)
        {
            myAgent.enabled = false;
            myAnimator.Play("NormalAttack01_SwordShield");
        }
    }
}
