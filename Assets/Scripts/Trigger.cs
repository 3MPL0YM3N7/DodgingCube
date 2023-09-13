using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    Dropper[] droppers;
    void Start()
    {
        droppers = FindObjectsOfType<Dropper>();
    }

    void OnTriggerEnter(Collider other)
    {
        foreach (Dropper dropper in droppers)
        { 
            dropper.setDropperDown();
        }
    }
}
