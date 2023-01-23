// made by Hamzah

using UnityEngine;
using TMPro;

/*
  this class is used to set up a timer for the game, 
  its made to count up to a certian number or vice versa, 
  when the timer hits the number that is picked by the dev, 
  it starts flashing to let the player know that they ran out of time, 
  this class also prints out the time on the screen
*/ 
public class Timer : MonoBehaviour {
    //NOTE: This script needs some knowledge about unity and C# to be understood 

    
    public bool countDown = true;

    public float timerDuration = 3f * 60f; //Duration of the timer in seconds
    private float timer;

    public float flashDuration = 1f; //The full length of the flash
    private float flashTimer;

    //all the UI elements used to make up the timer 
    public TextMeshProUGUI firstMinute;
    public TextMeshProUGUI secondMinute;
    public TextMeshProUGUI separator;
    public TextMeshProUGUI firstSecond;
    public TextMeshProUGUI secondSecond;

    //This is called on the first frame 
    private void Start() {
        ResetTimer();
    }

    //checks if the time limit is over, if the time limit is over it starts flashing
    void Update() {
        if (countDown && timer > 0) {
            timer -= Time.deltaTime;
            UpdateTimerDisplay(timer);
        } else if (!countDown && timer < timerDuration) {
            timer += Time.deltaTime;
            UpdateTimerDisplay(timer);
        } else {
            FlashTimer();
        }
    }
    //resets timer every level
    private void ResetTimer()
    {
        if (countDown)
        {
            timer = timerDuration;
        }
        else
        {
            timer = 0;
        }
        SetTextDisplay(true);
    }
    //display all the timer UI elements
    private void SetTextDisplay(bool enabled)
    {
        firstMinute.enabled = enabled;
        secondMinute.enabled = enabled;
        separator.enabled = enabled;
        firstSecond.enabled = enabled;
        secondSecond.enabled = enabled;
    }

    // updates the display
    private void UpdateTimerDisplay(float time) {
        if (time < 0) {
            time = 0;
        }

        //this is for the display
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        //this is for updating each UI element of the timer
        string currentTime = string.Format("{00:00}{01:00}", minutes, seconds);
        firstMinute.text = currentTime[0].ToString();
        secondMinute.text = currentTime[1].ToString();
        firstSecond.text = currentTime[2].ToString();
        secondSecond.text = currentTime[3].ToString();
    }

    //this is what causes the flashing when the timer is over and also sets the speed of the flashing
    private void FlashTimer() {
        //the timer came to an end by counting down
        if (countDown && timer != 0) {
            timer = 0;
            UpdateTimerDisplay(timer);
        }

        //the timer came to an end by counting up
        if (!countDown && timer != timerDuration) {
            timer = timerDuration;
            UpdateTimerDisplay(timer);
        }

        //switches on and off the UI elements of timer to create a flashing effect
        if (flashTimer <= 0) {
            flashTimer = flashDuration;
        } else if (flashTimer <= flashDuration / 2) {
            flashTimer -= Time.deltaTime;
            SetTextDisplay(true);
        } else {
            flashTimer -= Time.deltaTime;
            SetTextDisplay(false);
        }
    }
}