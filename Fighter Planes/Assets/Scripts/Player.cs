using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      Lives = PlayerPrefs.GetInt("Lives");

 GameObject.Find("livesUI").GetComponent<Text>().text = "Lives : " + Lives;
}
    }
    void OnCollisionEnter(Collision collision)
    {
      if (collision.GameObject.CompareTag("Enemy"))
      {
        lives -= 1;
        lives = PlayerPrefs.GetInt("lives")
         PlayerPrefs.SetInt("Lives", lives);

      if (lives <= 0)
      {
        gameOver = true
        Debug.Log ("Game Over")
        Destroy (this.GameObject);
      }
    }

  }

}
