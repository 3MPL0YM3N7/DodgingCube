using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int collisionCount = 0;
    void OnCollisionEnter(Collision collision)
    {
        ++collisionCount;
        Debug.Log("You bumped into a thing " + collisionCount + " times!");
    }
}
