using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocks : MonoBehaviour
{

    SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        sp = this.GetComponent<SpriteRenderer>();
        switch (PlayerPrefs.GetInt("Color", 0))
      {
          case 1:
              sp.color = Color.blue;
              break;
          case 2:
              sp.color = Color.yellow;
              break;
          default:
                sp.color = Color.white;
              break;
      }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
