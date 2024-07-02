using System;
using UnityEngine;

public class SwitchCampfireState : MonoBehaviour
{
    private ParticleSystem[] particle;
    private int index;

    private void Awake()
    {
        particle = GetComponentsInChildren<ParticleSystem>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        particle[index++ % particle.Length].Stop();
        particle[index % particle.Length].Play();
    }
}