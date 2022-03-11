using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
        private void OnCollisionEnter(Collision other)
        {
            Score1.coinAmount -= 1;
            Destroy(gameObject);
        }
    }

