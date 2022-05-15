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
    public Game_Load GL;
    // Start is called before the first frame update
    Vector3 myVector;
    void Start()
    {
        HP = maxHP;
        healthbar.setMaxHealth(maxHP);
        myVector = new Vector3(2.0f, 4.8f, 0.0f);
    }

    // Update is called once per frame
    public void takeHit(float dmg) {
        HP -= dmg;
        healthbar.setHealth(HP);
        if (HP < 1)
        {
            Destroy(gameObject);
            GL.LoadNextLevel();
        }
        else {
            epa.TakeHit(10);
            if (HP < 0)
            {

            }
            else
            {
                //System.Threading.Thread.Sleep(1000);
                //Thread.Sleep(1000);
                
                DamagePopUp.Create(myVector, 10);
            }
            animator.SetTrigger("Enemy_Att");
        }
    }


}
