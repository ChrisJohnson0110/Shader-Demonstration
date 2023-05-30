using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleEffects : MonoBehaviour
{
    bool bParticlesPlaying = false; //bool for if particles should play

    private void Start()
    {
        ToggleParticles(); //ensure all start enabled
    }

    /// <summary>
    /// toggle all of the renderers on objects with the particlesystems tag
    /// </summary>
    public void ToggleParticles()
    {
        bParticlesPlaying = !bParticlesPlaying; //switch

        GameObject[] go = GameObject.FindGameObjectsWithTag("ParticleSystems");
        foreach (GameObject g in go)
        {
            if (bParticlesPlaying == true)
            {
                g.GetComponent<ParticleSystem>().Play();
            }
            else if (bParticlesPlaying == false)
            {
                g.GetComponent<ParticleSystem>().Stop();
            }
            
        }
    }


}
