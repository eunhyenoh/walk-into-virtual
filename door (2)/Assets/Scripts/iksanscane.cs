using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class iksanscane : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("toooohooo");
    }
}

