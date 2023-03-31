using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPins : MonoBehaviour
{
    public GameObject pinsPrefab;
    public GameObject pins;

    public TMPro.TextMeshProUGUI scoreText;
    public TMPro.TextMeshProUGUI highScoreText;

    // Update is called once per frame
    public void ResetThePins()
    {
        if (pins != null)
        {
            Destroy(pins);
        }
        //Destroy(gameObject);
        pins = GameObject.Instantiate(pinsPrefab, transform.position, transform.rotation);
        // Assign 
        foreach (ScoringSystem s in pins.GetComponentsInChildren<ScoringSystem>())
        {
            s.scoreText = scoreText;
            s.highScoreText = highScoreText;
            StrikeDetection.Instance.pinCount = 0;
        }
        
        
    }

	public void Update()
	{
        if (Input.GetKeyDown(KeyCode.C))
        {
            ResetThePins();
        }
	}
}
