using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AsteroidMovment : MonoBehaviour
{
    // Start is called before the first frame update
    public float asteroid_speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + asteroid_speed);
        
    }

    public void restartbutton()
    {
        SceneManager.LoadScene(0);
    }
}
