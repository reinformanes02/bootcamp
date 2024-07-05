using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jumpSound, coinSound, playerDeathSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("jump");
        coinSound = Resources.Load<AudioClip>("coinPickup");
        playerDeathSound = Resources.Load<AudioClip>("PlayerDeath");

        audioSrc = GetComponent<AudioSource>();
    }
    

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "coinPickup":
                audioSrc.PlayOneShot(coinSound);
                break;
            case "PlayerDeath":
                audioSrc.PlayOneShot(playerDeathSound);
                break;
        }
    }
}
