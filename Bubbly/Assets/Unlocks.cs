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
              sp.color = new Color(0.407f, 0.635f, 0.988f);
              break;
          case 2:
              sp.color = new Color(0.898f, 0.870f, 0.467f);
              break;
            case 3:
                sp.color = new Color(0.905f, 0.619f, 0.929f);
                break;
            case 4:
                sp.color = Color.black;
                break;
            default:
                sp.color = Color.white;
              break;
      }
    }
}
