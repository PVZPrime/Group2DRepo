using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToWinScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        enemies.Length = 0;
        GameObject.FindGameObjectsWithTag("finish");
    }
}
