using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rhytemscene : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("rhythm");
    }
}
