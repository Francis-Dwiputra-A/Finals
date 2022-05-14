using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_die_enemy : MonoBehaviour
{
    public Animator animator;
    public float maxHP = 50;
    public float HP;
    public Healthbar healthbar;
    public Boss_die_knight knight;
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
        else if (HP < 25)
        {
            knight.TakeHit(5);
            animator.SetTrigger("Boss_counter_2");
        }
        else
        {
            knight.TakeHit(1);
            animator.SetTrigger("Boss_counter");
        }
    }
}
