using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioClip gameOverSound;
    public AudioClip gameMilestoneSound;
    public AudioClip gameStartSound;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void playGameOverSound()
    {
        if (gameOverSound != null)
            AudioSource.PlayClipAtPoint(gameOverSound, Camera.main.transform.position);
    }

    public void playGameMilestoneSound()
    {
        if (gameMilestoneSound != null)
            AudioSource.PlayClipAtPoint(gameMilestoneSound, Camera.main.transform.position);
    }

    public void playGameStartSound()
    {
        if (gameStartSound != null)
            AudioSource.PlayClipAtPoint(gameStartSound, Camera.main.transform.position);
    }
}
