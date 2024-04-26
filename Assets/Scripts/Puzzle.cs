using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{   
    private bool canTrigger = false;
 
    private void Update()
    {
        if (canTrigger && Input.GetKeyDown(KeyCode.E))
        {
            // launch puzzle
        }
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canTrigger = true;
        }
    }
 
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canTrigger = false;
        }
    }
}

