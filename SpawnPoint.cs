using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject asteroid;
    float timer;
    float timer2;//for asteroid
    float speedAsteroid = -0.3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.7f)
        {
            var clone = Instantiate(asteroid, transform.position, asteroid.transform.rotation);
            clone.GetComponent<AsteroidMovment>().asteroid_speed = speedAsteroid;
            Destroy(clone,6f);
            timer = 0;
        }
        //increasing the speed of the asteroid
        timer2 += Time.deltaTime;
        if (timer2 > 10)
        {
            speedAsteroid = speedAsteroid - 0.07f;
            timer2 = 0;
        }
    }
}
