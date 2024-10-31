using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMelee : MonoBehaviour
{
    [SerializeField] private Animator anim;
    
    [SerializeField] private float meleeSpeed;
    
    [SerializeField] private float damage;
    
    float timeUntilMelee;

    private void Update()
    {
        if (timeUntilMelee <= 0f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetTrigger("Attack");
                timeUntilMelee = meleeSpeed;
            }
        }
        else 
        {
            timeUntilMelee -= Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            //other.GetComponet<enemy>().Takedamage(damage);
            Debug.Log("Enemy hit");
        }
    }


}
