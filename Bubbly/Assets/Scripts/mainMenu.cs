using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void playButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void variantButton()
    {
        SceneManager.LoadScene("menuVariant");
    }
}
