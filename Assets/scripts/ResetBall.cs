using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetBall : MonoBehaviour
{
    public TMPro.TextMeshProUGUI BallFrame;
    public GameObject ballObject;
    public Vector3 originalBallPos;
    public static int resetCount = 0;

    public static int max = 2;

    // Start is called before the first frame update
    private void Start()
    {
        originalBallPos = ballObject.transform.position;

    }

    // Update is called once per frame
    public void ResetTheBall()
    {
        if (resetCount < max)
        {
        ballObject.transform.position = originalBallPos;
        resetCount++;
        Frames();
        }
    }
    public void Frames()
    {
        BallFrame.text = resetCount.ToString();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ResetTheBall();
        }
    }
}