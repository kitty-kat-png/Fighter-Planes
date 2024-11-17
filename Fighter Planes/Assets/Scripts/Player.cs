using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      {
          PlayerPrefs.SetInt("Lives", 3); //setting players initial lives.
      }
  }
    }

    // Update is called once per frame
    void Update()
    {
      Lives = PlayerPrefs.GetInt("Lives");

 GameObject.Find("livesUI").GetComponent<Text>().text = "Lives : " + Lives;
}
    }
}
