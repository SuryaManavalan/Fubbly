using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public int amount;

    void Awake()
    {
        amount = PlayerPrefs.GetInt("Complexity", 8);
        (Instantiate(Resources.Load("smallgreenBall")) as GameObject).transform.position = new Vector3(Random.Range(-3, 3), Random.Range(-8, 8), 0); //instantiate one small green ball no matter what

        for(int i = 0;i < amount; i++)
        {
            int x = Random.Range(-3, 3);
            int y = Random.Range(-8, 8);
            int check = Random.Range(0, 100);

            if(check < 80)
            {
                float xPad = Random.Range(0, 0.75f);
                float yPad = Random.Range(0, 0.75f);

                GameObject instance = Instantiate(Resources.Load(randomBall())) as GameObject;
                instance.transform.position = new Vector3(x + xPad, y + yPad, 0);
            }
        }
    }

    string randomBall()
    {
        string ballName = "";

        int color = Random.Range(0, 3);
        int size = Random.Range(0, 5);

        if(size < 2)
        {
            ballName += "small";
        }else if(size > 3)
        {
            ballName += "big";
        }

        if(color == 0)
        {
            ballName += "redBall";
        }else if (color == 1)
        {
            ballName += "brownBall";
        }else if (color == 2)
        {
            ballName += "greenBall";
        }

        return ballName;
    }
}
