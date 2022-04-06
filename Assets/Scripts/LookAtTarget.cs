using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for Jax
//Written by Paul Iradi
public class LookAtTarget : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target);
        }
    }

}
