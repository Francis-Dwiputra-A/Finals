using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Load : MonoBehaviour
{
    public Animator transition;
    public float transtime = 1f;
    // Update is called once per frame
    void Update()
    {

    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void LoadNextLevel2()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
    }
    
    public void LoadMenu()
    {
        StartCoroutine(LoadLevel(0));
    }
    public void LoadMenu_Lose()
    {
        StartCoroutine(LoadLevelMenuLose(0));
    }

    public void LoadMenu_Win()
    {
        StartCoroutine(LoadLevelMenuWin(0));
    }

    IEnumerator LoadLevel(int LevelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(LevelIndex);
    }
        IEnumerator LoadLevelMenuWin(int LevelIndex)
    {
        transition.SetTrigger("Win");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(LevelIndex);
    }

          IEnumerator LoadLevelMenuLose(int LevelIndex)
    {
        transition.SetTrigger("Lose");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(LevelIndex);
    }
}
