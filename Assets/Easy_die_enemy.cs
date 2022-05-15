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
    public Game_Load GL;
    Vector3 myVector;

    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
        healthbar.setMaxHealth(HP);
        myVector = new Vector3(2.0f, 4.8f, 0.0f);

    }

    public void TakeHit(float dmg)
    {
        HP -= dmg;
        healthbar.setHealth(HP);
        if (HP < 1)
        {
            animator.SetTrigger("Die");
            Destroy(gameObject);
            GL.LoadNextLevel2();
        }
        else
        {
            knight.TakeHit(1);
            animator.SetTrigger("Ez_counter");
            //System.Threading.Thread.Sleep(1000);
            DamagePopUp.Create(myVector, 1);
        }
    }
}
