using UnityEngine;
using System.Collections;

public class ballProperties : MonoBehaviour
{
    public string color;
    public Color realColor;
    // Use this for initialization
    void Start()
    {
        realColor = this.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
