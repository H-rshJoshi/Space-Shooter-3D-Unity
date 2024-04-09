using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterExplode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AfterExplodes());  
    }
    IEnumerator AfterExplodes()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(gameObject);
    }

    // Update is called once per frame
    
}
