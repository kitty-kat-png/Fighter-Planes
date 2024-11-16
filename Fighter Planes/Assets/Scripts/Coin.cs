using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 2);
    }

    public void OnTriggerEnter2D(Collider2D whatIHit)
    {
        if (whatIHit.tag == "Player")
        {
            //Coin collected!
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(1);
            Destroy(this.gameObject);
        }
    }
    
}