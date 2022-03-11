using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ddffd : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("towerfd");
    }
}
