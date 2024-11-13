using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 9f, 0), Quaternion.identity);
    }



    private void Start()
        {
          gameOver = false;
          PlayerPrefs.SetInt("Lives", 3); //initial lives
        }

    public int lives;

      void start ()
      {
        updateui();
      }

      void updateui ()
      {
        Lives = PlayerPrefs.GetInt("Lives");
         GameObject.Find("livesUI").GetComponent<Text>().text = "Lives : " + Lives;
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
          Destory (this.GameObject);
        }
      }

    }
