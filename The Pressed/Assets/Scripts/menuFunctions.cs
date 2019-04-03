using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuFunctions : MonoBehaviour
{
    public Image difficulty;
    public Image colored;

    private void Start() {
        switch (PlayerPrefs.GetInt("Color", 0))
      {
          case 1:
              colored.color = Color.blue;
              break;
          case 2:
              colored.color = Color.yellow;
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
                PlayerPrefs.SetInt("Complexity", 20);
              difficulty.sprite = Resources.Load <Sprite> ("difficulty2");
              break;
          case 20:
                PlayerPrefs.SetInt("Complexity", 35);
              difficulty.sprite = Resources.Load <Sprite> ("difficulty3");
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
                PlayerPrefs.SetInt("Color", 2);
              colored.color = Color.yellow;
              break;
          case 2:
                PlayerPrefs.SetInt("Color", 0);
              colored.color = Color.white;
              break;
          default:
                PlayerPrefs.SetInt("Color", 1);
             colored.color = Color.blue;
              break;
      }
    }
}
