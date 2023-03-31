using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;
    public TMPro.TextMeshProUGUI highScoreText;
    public static  int score = 0;
    // Time to wait before removing the pin if it's down
    public float removeDelay = 2.0f;

    // Flag to track if the pin has been knocked down
    //public bool isHit = false;

    private void Start()
    {
       UpdateHighScore();
    }

    public bool dieing = false;
    //tracks whether the pin object is in the process of being destroyed or not.
    public void Update()
    {
        if (! dieing )
        { 
        if (IsPinDown())
        {
            //Debug.Log("Destroy");
            score++; //increment Score
            dieing = true;
            AddScore();
                StrikeDetection.Instance.PinOver(); // Reference to StrikeDetection Class
            //dieing = true;
            Destroy(this.gameObject, removeDelay); // Distroying the game object
            // RemovePinAfterDelay();
            
        }
        }
    }
    // calculate the angel between the pin and floor
	public bool IsPinDown()
    {
        Vector3 euler = transform.rotation.eulerAngles;
        return (euler.z > 5 && euler.z < 355);
    }

    IEnumerator RemovePinAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(removeDelay);
        Debug.Log("destroying pin:" + gameObject);
        // Remove the pin from the scene
        Destroy(gameObject);
    }
    // display score in UI
    public void AddScore()
    {
        scoreText.text = score.ToString();
        UpdateHighScore();
    }
    //display high score in UI
    public void UpdateHighScore()
    {
     if(score > PlayerPrefs.GetInt("highScore", 0)) //store the high score value 
        {
            PlayerPrefs.SetInt("highScore", score);
        }
        highScoreText.text = $"highScore: {PlayerPrefs.GetInt("highScore", 0)}";
    }
}
