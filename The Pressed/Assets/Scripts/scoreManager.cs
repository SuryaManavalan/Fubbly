using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public GameObject scoreText;
    
    void Update()
    {
        scoreText.gameObject.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("Score", 0);
    }
}