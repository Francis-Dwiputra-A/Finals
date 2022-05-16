using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Boss : MonoBehaviour
{
    [SerializeField] private GameObject player;

    public Animator transition;
    public float transitionTime = 5f;
    // Start is called before the first frame update

    // Update is called once per frame

    private void OnTriggerStay2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            if((Input.GetAxisRaw("Vertical") == -1) || Input.GetKey(KeyCode.DownArrow)){
                LoadNextLevel();
            }
        }
    }

    public void LoadNextLevel(){
        StartCoroutine(NextEasyLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }

    IEnumerator NextEasyLevel(int levelIndex){
        transition.SetTrigger("Boss");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
