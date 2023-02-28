using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    public GameObject ballObject;
    public Vector3 originalBallPos;
    private int resetCount = 0;

    // Start is called before the first frame update
    private void Start()
    {
        originalBallPos = ballObject.transform.position;

    }

    // Update is called once per frame
    public void ResetTheBall()
    {
        if (resetCount < 3)
        {
        ballObject.transform.position = originalBallPos;
        resetCount++;
        }
    }
}