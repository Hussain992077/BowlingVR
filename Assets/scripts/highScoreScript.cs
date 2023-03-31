using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class highScoreScript : MonoBehaviour
{

    public TMPro.TextMeshProUGUI highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = $"highScore : {PlayerPrefs.GetInt("highScore", 0)}";
    }
}
