using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    
   [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float delayAmount = 2f;
    [SerializeField] AudioClip crashSound;
    bool hasCrashed = false;
 
    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag == "Groud" && hasCrashed == false){

            FindObjectOfType<PlayerControll>().DisableControls();
            crashEffect.Play();
            FindObjectOfType<DustTrail>().DisableTrail();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
           Invoke("reloadScene",delayAmount);
           hasCrashed = true;
           
           
       } 
    }

    void reloadScene() {

        SceneManager.LoadScene(0);
    }
}
