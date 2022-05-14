using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliteEnemyBehaviour : MonoBehaviour
{
    public Animator animator;
    public float maxHP = 30;
    public float HP;
    public Healthbar healthbar;
    public Elite_Player_Attack epa;
    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
        healthbar.setMaxHealth(maxHP);
    }

    // Update is called once per frame
    public void takeHit(float dmg) {
        HP -= dmg;
        healthbar.setHealth(HP);
        if (HP < 1)
        {
            Destroy(gameObject);
        }
        else {
            epa.TakeHit(10);
            animator.SetTrigger("Enemy_Att");
        }
    }


}
