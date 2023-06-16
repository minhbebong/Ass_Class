using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private float duration = 0.12f;
    private SpriteRenderer boom;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        boom = GetComponent<SpriteRenderer>();
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > duration)
        {
            boom.enabled = false;
            enabled = false;
        }
    }
}
