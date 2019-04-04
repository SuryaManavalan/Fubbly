using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonWorks : MonoBehaviour
{

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
