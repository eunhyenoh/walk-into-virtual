using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dddff : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("Main 1");
    }
}
