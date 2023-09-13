using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float xSpeed = 1f;
    [SerializeField] float ySpeed = 0f;
    [SerializeField] float zSpeed = 1f;

    void Start()
    {
        PrintTutorial();
    }


    void Update()
    {
        MovePlayer();
    }

    void PrintTutorial()
    {
        Debug.Log("press WASD OR up-/left-/down-/right-arrow to move the player.\n" +
                  "Don't hit the walls!\n");
    }

    void MovePlayer()
    {
        transform.Translate(
    Input.GetAxis("Horizontal") * xSpeed * Time.deltaTime,
    ySpeed * Time.deltaTime,
    Input.GetAxis("Vertical") * zSpeed * Time.deltaTime);
    }
}
