using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(LoadNextLevel());
        }
    }
    
    IEnumerator LoadNextLevel()
    {
        transition.SetTrigger("ChangeScene");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
