using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easy_die_enemy : MonoBehaviour
{
    public Animator animator;
    public float maxHP = 10;
    public float HP;
    public Healthbar healthbar;
    public Easy_die_knight knight;
    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
        healthbar.setMaxHealth(HP);
    }

    public void TakeHit(float dmg)
    {
        HP -= dmg;
        healthbar.setHealth(HP);
        if (HP < 1)
        {
            animator.SetTrigger("Die");
            Destroy(gameObject);
        }
        else
        {
            knight.TakeHit(1);
            animator.SetTrigger("Ez_counter");
        }
    }
}
