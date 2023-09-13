using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    bool isHit = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !isHit)
        {
            // Debug.Log("Bumped into a wall!");
            GetComponent<MeshRenderer>().material.color = Color.yellow;
            isHit = true;
        }
    }
}
