using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenech : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("church");
    }
}