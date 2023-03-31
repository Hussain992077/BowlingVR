using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAudioScript : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip pin;
    public AudioClip lane;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pins")
        {
            audioSource.PlayOneShot(pin);
        }
        else if (collision.gameObject.tag == "lane")
        {
            audioSource.PlayOneShot(lane);
        }
    }
}
