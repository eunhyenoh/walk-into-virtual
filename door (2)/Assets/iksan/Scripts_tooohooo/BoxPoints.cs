using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPoints : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "TOHO")
        {
            KeepScore.Score += 1;
        }
    }
}
