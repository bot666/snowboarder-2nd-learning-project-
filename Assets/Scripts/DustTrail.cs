using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour

{
    public ParticleSystem trailParticle;
    bool trail = true;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Groud" && trail == true)
        {
            trailParticle.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        //if(collisionInfo.collider.tag == "Groud")
        if (other.gameObject.tag == "Groud")
        {
            trailParticle.Stop();
        }
    }
        public void DisableTrail()
        {
            trail = false;
        }
        
     //Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
