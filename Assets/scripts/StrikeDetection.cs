using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeDetection : MonoBehaviour
{
    public int pinCount = 0;

    Coroutine c = null;

    public TMPro.TextMeshProUGUI scoreText;

    public static StrikeDetection Instance;

    // waits for 2 seconds and then resets pinCount to zero and sets c to null.
    IEnumerator startTimer()
    {
        yield return new WaitForSeconds(2);        
        pinCount = 0;
        c = null;
        
    }
    // checks if c is null and starts the startTimer() coroutine if it is.
    public void CountDown()
    {
        if (c == null)
        {
            c = StartCoroutine(startTimer());
        }
    }
    // changes the score text to display the current score.
    void ChangeBack()
    {
        scoreText.text = "" + ScoringSystem.score;
    }
    //method is called when a pin has been knocked down. It increments pinCount, calls CountDown(), and checks if all pins have been knocked down

    public void PinOver()
    {
        pinCount++;
        CountDown();
        if (pinCount == 10)
        {
            scoreText.text = "STRIKE!";
            AudioSource strk = GetComponent<AudioSource>();
            strk.Play();
            ResetBall.max ++;
            Invoke("ChangeBack", 2);
        }
        
    }

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }
}
