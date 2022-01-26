using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfettiEmitterScript : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;
    [SerializeField] private ParticleSystem particle2;
    [SerializeField] private ParticleSystem particle3;
    private void Start()
    {
        particle.Pause();
        particle2.Pause();
        particle3.Pause();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("goal"))
        {
            particle.Play();
            particle2.Play();
            particle3.Play();
        }
    }
}