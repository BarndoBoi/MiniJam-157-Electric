using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameOver : MonoBehaviour
{   
    [SerializeField] private GameObject endScreen;
    private void Start()
    {   
        Timer timer = FindObjectOfType<Timer>();
        
        if (timer != null)
        {
            timer.OnTimerDone += OnTimerFinished;
        }
    }

    private void OnTimerFinished()
    {
        if (endScreen != null)
        {
            endScreen.SetActive(true);
        }
    }
}
