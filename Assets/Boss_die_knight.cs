using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_die_knight : MonoBehaviour
{
    public Animator animator;
    public float maxHP = 30;
    public float HP;
    public Healthbar healthbar;
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
            animator.SetTrigger("Boss_Die");
            Destroy(gameObject);
        }
    }
}
