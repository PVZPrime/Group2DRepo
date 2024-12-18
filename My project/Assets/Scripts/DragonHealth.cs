using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragonHealth : MonoBehaviour
{
    [SerializeField]
    float health = 25;
    float maxHP;
    Image healthBar;
    //reduce the enemy health when hit by a player bullet
    //destroy the enemy if their health gets reduced to 0
    // Start is called before the first frame update
    void Start()
    {
        maxHP = health;
        healthBar = GetComponentsInChildren<Image>()[1];
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            health -= 1;
            healthBar.fillAmount = health / maxHP;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
