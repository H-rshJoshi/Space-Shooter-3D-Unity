using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class SpaceShipMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject GameOverUI;
    public AudioSource DestroySpaceShip;
    /*float timer;*/
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Xinput = Input.GetAxis("Horizontal");
        float Yinput = Input.GetAxis("Vertical");
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + Xinput* speed, -100f, 100f), transform.position.y, Mathf.Clamp(transform.position.z + Yinput* speed, -40f, 40f));
        /*timer += Time.deltaTime;
        if (timer > 15)
        {
            AsteroidMovment.asteroid_speed = (float)(AsteroidMovment.asteroid_speed + 0.05);
            timer = 0;
        }*/
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            DestroySpaceShip.Play();
            GameOverUI.SetActive(true);
        }
    }
}
