using UnityEngine;
using System.Collections;

public class ballProperties : MonoBehaviour
{
    public string color;
    public Color realColor;
    // Use this for initialization
    void Start()
    {
        realColor = new Color(0.898f, 0.870f, 0.467f);
    }
}
