using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public Image sound;

    private void Start()
    {
        switch (PlayerPrefs.GetInt("Mute", 0))
        {
            case 0:
                sound.sprite = Resources.Load<Sprite>("musicnote");
                break;
            default:
                sound.sprite = Resources.Load<Sprite>("musicnoteslash");
                break;
        }
    }

    public void playButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void variantButton()
    {
        SceneManager.LoadScene("menuVariant");
    }

    public void muteButton()
    {

        switch (PlayerPrefs.GetInt("Mute", 0))
        {
            case 0:
                PlayerPrefs.SetInt("Mute", 1);
                sound.sprite = Resources.Load<Sprite>("musicnoteslash");
                break;
            default:
                PlayerPrefs.SetInt("Mute", 0);
                sound.sprite = Resources.Load<Sprite>("musicnote");
                break;
        }
    }
}
