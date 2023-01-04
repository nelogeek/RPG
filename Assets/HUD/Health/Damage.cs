using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damageCount = 10;

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine (FindObjectOfType<FirstPersonController>().Damage(damageCount));
    }
}
