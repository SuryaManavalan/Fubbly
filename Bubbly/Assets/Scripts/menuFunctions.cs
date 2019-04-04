using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuFunctions : MonoBehaviour
{
    public Image difficulty;
    public Image colored;
    public Text nextScore;

    int next;

    private void Start() {

        switch (PlayerPrefs.GetInt("Color", 0))
        {
            case 1:
              colored.color = new Color(0.407f, 0.635f, 0.988f);
              break;
            case 2:
              colored.color = new Color(0.898f, 0.870f, 0.467f);
              break;
            case 3:
                colored.color = new Color(0.905f, 0.619f, 0.929f);
                break;
            case 4:
                colored.color = Color.black;
                break;
            default:
             colored.color = Color.white;
              break;
        }

      switch (PlayerPrefs.GetInt("Complexity", 8))
      {
          case 8:
              difficulty.sprite = Resources.Load <Sprite> ("difficulty1");
              break;
          case 20:
              difficulty.sprite = Resources.Load <Sprite> ("difficulty2");
              break;
          case 35:
              difficulty.sprite = Resources.Load <Sprite> ("difficulty3");
              break;
      }

        next = 200;
        if (PlayerPrefs.GetInt("Score", 0) >= 200)
            next = 1000;
        if (PlayerPrefs.GetInt("Score", 0) >= 1000)
            next = 5000;
        if (PlayerPrefs.GetInt("Score", 0) >= 5000)
            next = 10000;
        if (PlayerPrefs.GetInt("Score", 0) >= 10000)
            next = 50000;
        if (PlayerPrefs.GetInt("Score", 0) >= 50000)
            next = 100000;
        if (PlayerPrefs.GetInt("Score", 0) >= 100000)
            next = 100001;

        nextScore.text += "" + next;

        if (next > 100000)
            nextScore.text = "Everything Unlocked!";
    }
    
    public void backButton()
    {
        SceneManager.LoadScene(0);
    }

    public void difficultySelect()
    {
        switch (PlayerPrefs.GetInt("Complexity", 8))
      {
          case 8:
                if(next >= 1000)
                {
                    PlayerPrefs.SetInt("Complexity", 20);
                    difficulty.sprite = Resources.Load<Sprite>("difficulty2");
                }
                else
                {
                    PlayerPrefs.SetInt("Complexity", 8);
                    difficulty.sprite = Resources.Load<Sprite>("difficulty1");
                }
              break;
          case 20:
                if(next >= 50000)
                {
                    PlayerPrefs.SetInt("Complexity", 35);
                    difficulty.sprite = Resources.Load<Sprite>("difficulty3");
                }
                else
                {
                    PlayerPrefs.SetInt("Complexity", 8);
                    difficulty.sprite = Resources.Load<Sprite>("difficulty1");
                }
                break;
          case 35:
                PlayerPrefs.SetInt("Complexity", 8);
              difficulty.sprite = Resources.Load <Sprite> ("difficulty1");
              break;
      }
    }
    public void colorSelect()
    {
        switch (PlayerPrefs.GetInt("Color", 0))
      {
          case 1:
                if (next >= 10000)
                {
                    PlayerPrefs.SetInt("Color", 2);
                    colored.color = new Color(0.898f, 0.870f, 0.467f);
                }
                else
                {
                    PlayerPrefs.SetInt("Color", 0);
                    colored.color = Color.white;
                }
                break;
          case 2:
                if(next >= 100000)
                {
                    PlayerPrefs.SetInt("Color", 3);
                    colored.color = new Color(0.905f, 0.619f, 0.929f);
                }
                else
                {
                    PlayerPrefs.SetInt("Color", 0);
                    colored.color = Color.white;
                }
                break;
            case 3:
                if (next >100000)
                {
                    PlayerPrefs.SetInt("Color", 4);
                    colored.color = Color.black;
                }
                else
                {
                    PlayerPrefs.SetInt("Color", 0);
                    colored.color = Color.white;
                }
                break;
            case 4:
                PlayerPrefs.SetInt("Color", 0);
                colored.color = Color.white;
                break;
            default:
                if (next >= 2500)
                {
                    PlayerPrefs.SetInt("Color", 1);
                    colored.color = new Color(0.407f, 0.635f, 0.988f);
                }
                else
                {
                    PlayerPrefs.SetInt("Color", 0);
                    colored.color = Color.white;
                }
              break;
      }
    }
}
