using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float margin;
    private Camera cam;
    private Vector2 screenBound;

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
        
    }
    private void LateUpdate()
    {
        transform.position += -transform.up * speed * Time.deltaTime;
        if (transform.position.y + margin < -screenBound.y)
        {
            Destroy(gameObject);
        }
    }


}
