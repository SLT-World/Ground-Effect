using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] float InstantiateRange = 5;

    Vector3 ToLocation;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (Random.Range(-50, 50) == 0) { ToLocation = Random.insideUnitCircle * 100; }
        transform.position = Vector3.MoveTowards(transform.position, ToLocation, 5f * Time.deltaTime);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, InstantiateRange);
    }
}
