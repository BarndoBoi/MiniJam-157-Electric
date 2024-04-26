using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] private float gameplaySeconds; //How long does the player have?
    public float secondsLeft {  get; private set; } //Tracks the remaining time
    private string timeString; //stores formatted time string, e.g. 1m 36s
    [SerializeField] private TextMeshProUGUI timerText; //Display the formatted string each update
    public delegate void TimerDone(); //Declare delegate that gets called when the timer hits zero
    public TimerDone OnTimerDone; //Instance of the timer that outside scripts should add functions into

    // Start is called before the first frame update
    void Start()
    {
        secondsLeft = gameplaySeconds;
    }

    // Update is called once per frame
    void Update()
    {
        secondsLeft -= Time.deltaTime;
        FormatSeconds();
        timerText.text = timeString;
        if (secondsLeft <= 0)
        {
            if (OnTimerDone != null)
                OnTimerDone(); //Invoke the delegate if it exists
        }
    }

    void FormatSeconds()
    {
        int minutes = (int) secondsLeft / 60; //Divide into minutes
        int seconds = (int) secondsLeft % 60; //Get modulo remainder for remaining seconds
        timeString = $"{minutes}:{seconds}";
    }

    public void ChangeSecondsLeft(float newSeconds)
    { //If we need to change the time for any reason, we've got this function
        secondsLeft = newSeconds;
    }
}
