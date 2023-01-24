using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController playerController;
    public GameOverController gameOverController;
    public AudioSource audioSourceCoin;
    public AudioSource audioSourceGameOver;
    public Score score;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Collectable")
        {
            audioSourceCoin.Play();
            score.AddScore(1);
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Obstacles")
        {
            audioSourceGameOver.Play();
            playerController.enabled = false;
            gameOverController.GameOver();
        }    
    }
}
