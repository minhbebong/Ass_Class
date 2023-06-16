using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject gun;
    [SerializeField]
    private Transform point;
    [SerializeField]
    private float rotateSpeed;
    [SerializeField] private float moveSpeed;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private AudioSource shootingSound;

    private float rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotation = gun.transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)) {
            rotation += rotateSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotation -= rotateSpeed * Time.deltaTime;
        }
        gun.transform.rotation = Quaternion.Euler(Vector3.forward * rotation);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= Vector3.up * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        GameObject cloneBullet = Instantiate(bullet, point.position, point.rotation);
        shootingSound.Play();
    }
}
