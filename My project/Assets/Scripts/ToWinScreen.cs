using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToWinScreen : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    string levelToLoad = "WinScreen";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        enemies.Length == 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //IF I hit the key, I go to the win screen.
        if (collision.gameObject.tag == "finish")
        {

            SceneManager.LoadScene(levelToLoad);

        }
    }
}
