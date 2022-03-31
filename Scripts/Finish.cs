using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public string sceneName;
    private AudioSource FinishSound;

    private bool levelCompleted = false;
    private void Start()
    {
        FinishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name =="Player"  && !levelCompleted)
        {
            FinishSound.Play();
             levelCompleted = true;
            Invoke("CompleteLevel", 2f);
        }
    }

    private void CompleteLevel()
    {
       SceneManager.LoadScene(sceneName);

    }
}
