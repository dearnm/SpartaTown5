using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerMousePosition : MonoBehaviour
{
    SpriteRenderer renderer;

    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 movePlayerMousePosition = transform.position;
        Vector3 mousePosition = Input.mousePosition;

        if(movePlayerMousePosition.x < mousePosition.x)
        {
            renderer.flipX = false;
        }
        else if (movePlayerMousePosition.x > mousePosition.x)
        {
            renderer.flipX = true;
        }
    }
}
