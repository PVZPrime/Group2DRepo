using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTitleScreen : MonoBehaviour
{
    [SerializeField]
    string levelToLoad = "TitleScreen";
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void Title()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void LevelTwo()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void LevelThree()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void LevelFour()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void LevelFive() {
        SceneManager.LoadSceneAsync(5);
    }
}