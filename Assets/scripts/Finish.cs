using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FInish : MonoBehaviour
{
    private AudioSource finishSound;
    private bool LevelCompleted = false;
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !LevelCompleted)
        {
            finishSound.Play();
            LevelCompleted = true;
            Invoke("CompleteLevel", 2f);
        }
    }   

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
