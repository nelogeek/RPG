using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour 
{
    private UnityEngine.AI.NavMeshAgent agent;
    private float distance;
    private Animator animator;
    private Transform target;
    
    public bool alive;
    public Image background;
    public Image fill;
    public Image healthBar;

    private float curHealth;
    [SerializeField] private int maxHealth;

    public float detectionDistance = 20f;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform;
        alive = true;
        curHealth = maxHealth;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (alive)
        {
            distance = Vector3.Distance(target.position, transform.position);
            if (distance > detectionDistance)
            {
                agent.enabled = false;
                //animator.Play("wait");
                
            }
           

            if (2f < distance && distance < detectionDistance)
            {
                agent.enabled = true;
                agent.SetDestination(target.position);
                //animator.Play("run");
                animator.SetBool("isRunning", true);
            }
            else
            {
                animator.SetBool("isRunning", false);
            }

            if (distance <= 2f)
            {
                transform.LookAt(target.position);
                agent.enabled = false;
                animator.Play("attack");
                //animator.SetTrigger("attack");
            }

        }
        else
        {
            CloseHealthTab();
            animator.Play("die");
            
            agent.enabled = false;
           
        }
        
    }

    public void TakeDamage(float damage)
    {
        if (alive)
        {
            //animator.Play("getHit");
            animator.SetTrigger("getHit");
            curHealth -= damage;
            UpdateHealth((float)curHealth / (float)maxHealth);
            if (curHealth <= 0)
            {
                alive = false;
            }

        }
        
    }

    public void UpdateHealth(float fraction)
    {
        healthBar.fillAmount = fraction;
    }

    private void OnDestroy()
    {
        Destroy(gameObject);
    }

    private void CloseHealthTab()
    {
        healthBar.enabled = false;
        fill.enabled = false;
        background.enabled = false;
    }
}
