using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toohooscene : MonoBehaviour
{
 
    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("toooohooo");
    }
}
