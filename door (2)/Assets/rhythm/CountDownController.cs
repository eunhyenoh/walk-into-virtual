using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;



public class CountDownController : MonoBehaviour

{

    public int countdownTime;

    public Text countdownDisplay;

    public string levelToLoad;

    // Start is called before the first frame update

    void Start()

    {

        StartCoroutine(CountDownToStart());

    }



    IEnumerator CountDownToStart()

    {

        while (countdownTime > 0)
        {

            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);



            countdownTime--;

            if (countdownTime <= 0)

            {

                Application.LoadLevel(levelToLoad);

            }



        }



        countdownDisplay.text = "STOP!";

        // GameController.instance.BeginGame();

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);

    }

}