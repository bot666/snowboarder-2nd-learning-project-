using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishLine;
    [SerializeField] float delayAmount = 2f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishLine.Play();
            GetComponent<AudioSource>().Play();
            Invoke("reloadScene", delayAmount);
        }
    }

    void reloadScene()
    {

        SceneManager.LoadScene(0);
    }
}
