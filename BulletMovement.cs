using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletspeed;
    public GameObject explosion;
    public GameObject meteorDestroySound;
    //GameObject clone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + bulletspeed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            var clone2 = Instantiate(meteorDestroySound, transform.position, transform.rotation);
            Destroy(clone2, 2f);
            Destroy(collision.gameObject);
            ScoreSystem.score++;
            var clone = Instantiate(explosion,transform.position,explosion.transform.rotation);
            //StartCoroutine(AfterExplode());
            Destroy(gameObject);
        }
    }
    /*IEnumerator AfterExplode()
    {
        yield return new WaitForSeconds(2f);
        Destroy(clone);
    }*/
}
    
