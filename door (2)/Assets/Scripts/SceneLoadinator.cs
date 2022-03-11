using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class SceneLoadinator : MonoBehaviour
{
    // Start is called before the first frame update
    void LoadScene()
    {
        SceneManager.LoadScene("SceneChange");
    }
   
    /*
    public Text Textfield;

    public void SetText(string text)
    {
        Textfield.text = text;
    }
    */
}
