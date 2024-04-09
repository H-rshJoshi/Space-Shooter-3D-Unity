using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public AudioSource bulletsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var clone = Instantiate(bullet, transform.position, bullet.transform.rotation);
            bulletsound.Play();
            Destroy(clone, 2.5f);
        }
    }
}
