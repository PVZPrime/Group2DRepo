using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    [SerializeField]
    string levelToLoad = "LevelOne";
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
        //IF I hit a the play button I go to level 1
        if (collision.gameObject.tag == "Play")
        {

            SceneManager.LoadScene(levelToLoad);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}