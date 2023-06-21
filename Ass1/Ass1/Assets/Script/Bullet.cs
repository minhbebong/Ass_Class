using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float margin;

    private Camera cam;
    private Vector2 screenBound;
    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private GameObject animation;

    private void Awake()
    {
        cam = Camera.main;
        screenBound = cam.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        if (transform.position.x - margin > screenBound.x || transform.position.x + margin < - screenBound.x)
        {
            //destroy(gameobject);
            gameObject.SetActive(false);
        }
        if (transform.position.y - margin > screenBound.y || transform.position.y + margin < - screenBound.y)
        {
            //destroy(gameobject);
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.AddScore();
        Instantiate(animation, transform.position, transform.rotation);
        Destroy(collision.gameObject);
        //destroy(gameobject);
        gameObject.SetActive(false);
    }
}