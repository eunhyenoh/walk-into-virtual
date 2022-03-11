using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jejuscene : MonoBehaviour
{
 

    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("jeju");
    }
}

