using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
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

}