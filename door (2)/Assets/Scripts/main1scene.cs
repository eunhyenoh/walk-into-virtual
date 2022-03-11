using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class main1scene : MonoBehaviour
{
  
    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("Main 1");
    }
}

