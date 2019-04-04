using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interaction : MonoBehaviour
{
    GameObject[] balls;
    ArrayList redBalls;
    ArrayList greenBalls;
    public GameObject scoreText;
    int score;
    public int up;
    public int counter;
    int down;
    public GameObject restartButton;

    AudioSource sounds;

    public bool scored;

    // Start is called before the first frame update
    void Start()
    {
        sounds = this.gameObject.GetComponent<AudioSource>();

        scored = false;
        restartButton.transform.GetChild(0).gameObject.SetActive(false);
        restartButton.SetActive(false);
        balls = GameObject.FindGameObjectsWithTag("buble");
        redBalls = new ArrayList();
        greenBalls = new ArrayList();

        for (int i = 0; i < balls.Length; i++)
        {
            if(balls[i].GetComponent<ballProperties>().color == "red")
            {
                redBalls.Add(balls[i]);
            }else if (balls[i].GetComponent<ballProperties>().color == "green")
            {
                greenBalls.Add(balls[i]);
            }
        }

        counter = greenBalls.Count;
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(0.2f);
        counter -= up;
        score = 0;
        up = 0;
        down = 0;
    }

    private void Update()
    {
        if(!scored){
            score = (up + down)*10;
            scoreText.GetComponent<Text>().text = "" + score;
        }
        if (counter - up < 1)
        {
            restartButton.SetActive(true);

            if(!scored){
                scored = true;

                if(down > -1){
                restartButton.transform.GetChild(0).gameObject.SetActive(true);

                switch (PlayerPrefs.GetInt("Complexity", 8))
                {
                    case 8:
                    score += 5;
                    restartButton.transform.GetChild(0).gameObject.GetComponent<Text>().text += "5";
                    break;
                    case 20:
                    score += 15;
                    restartButton.transform.GetChild(0).gameObject.GetComponent<Text>().text += "15";
                    break;
                    case 35:
                    score += 30;
                    restartButton.transform.GetChild(0).gameObject.GetComponent<Text>().text += "30";
                    break;
                    }
            }

                scoreText.GetComponent<Text>().text = "" + score;
                PlayerPrefs.SetInt("Score", (PlayerPrefs.GetInt("Score", 0) + score));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        for(int i = 0; i < redBalls.Count; i++)
        {
            if (redBalls[i].Equals(collision.gameObject))
            {
                sounds.clip = Resources.Load<AudioClip>("sploosh1");
                sounds.Play();
                GameObject instance = Instantiate(Resources.Load("RedParticles")) as GameObject;
                instance.transform.position = collision.gameObject.transform.position;
                Destroy(collision.gameObject);
                down--;
            }
        }

        for (int i = 0; i < greenBalls.Count; i++)
        {
            if (greenBalls[i].Equals(collision.gameObject))
            {
                sounds.clip = Resources.Load<AudioClip>("sploosh2");
                sounds.Play();
                GameObject instance = Instantiate(Resources.Load("GreenParticles")) as GameObject;
                instance.transform.position = collision.gameObject.transform.position;
                Destroy(collision.gameObject);
                up++;
            }
        }
    }
}
