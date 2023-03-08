using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Wall3")
        {
            Destroy(this);
        }
    }
}
