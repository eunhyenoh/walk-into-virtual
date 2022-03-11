using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cont : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Score1.coinAmount -= 1;
        Debug.Log("test");
        Destroy(gameObject);
        
    }
}
