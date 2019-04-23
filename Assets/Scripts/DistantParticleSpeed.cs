using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistantParticleSpeed : MonoBehaviour
{
    private ParticleSystem ps;
    public float flyingSpeed = 1;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        var main = ps.main;
        main.simulationSpeed = flyingSpeed;
    }
}
