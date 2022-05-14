using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Hard : MonoBehaviour
{
    [SerializeField] private GameObject player;

    public Animator transition;
    public float transitionTime = 1f;
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
        StartCoroutine(NextHardLevel(SceneManager.GetActiveScene().buildIndex + 2));

    }

    IEnumerator NextHardLevel(int levelIndex){
        //transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
