using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    private float countDown;
    [SerializeField]
    private GameObject enemy;
    private float timer;
    [SerializeField]
    private ScoreUI scoreUI;
    private int score;

    private void Awake()
    {
        instance = this;

    }
    public void AddScore()
    {
        score++;
        scoreUI.UpdateScoreText(score);

    }

    // Start is called before the first frame update
    void Start()
    {
        scoreUI.UpdateScoreText(score);

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Spawn();
            timer = countDown;
        }
    }
    private void Spawn()
    {
        GameObject cloneEnemy = Instantiate
            (enemy, new Vector2(Random.Range(transform.position.x - 5f, transform.position.x + 5f), transform.position.y), transform.rotation);
    }
}