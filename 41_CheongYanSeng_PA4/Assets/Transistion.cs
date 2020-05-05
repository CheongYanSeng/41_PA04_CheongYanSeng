using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transistion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CubeTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CubeTime()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
