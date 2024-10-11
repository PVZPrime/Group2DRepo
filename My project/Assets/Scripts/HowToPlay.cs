using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
    [SerializeField]
    string levelToLoad = "How To Play";
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //IF I hit a the how to play button I go to the how to play scene
        if (collision.gameObject.tag == "HowToPlay")
        {

            SceneManager.LoadScene(levelToLoad);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}