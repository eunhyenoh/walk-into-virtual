using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;



public class NewBehaviourScript : MonoBehaviour

{

   // public float speed = 2.5f;

    // Start is called before the first frame update

    void Start()

    {

    }

    // Update is called once per frame

    void Update()

    {

     //   transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 5), transform.position.y, transform.position.z);



    }

    // 충돌이 발생하면 총알 오브젝트는 제거(파괴)

    private void OnCollisionEnter(Collision col)

    {

        // 게임오브젝트 제거(파괴)

        if (col.gameObject.name == "Enemy")
        {

            Destroy(col.gameObject);

        }

    }

  /*  public void ChangeScene()

    {

        if ("" == 0)

            SceneManager.LoadScene("")

    }*/

}