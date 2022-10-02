using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    [SerializeField] private Timer timer;
    
    public void PlayGame()
    {
        SceneManager.LoadScene("PostPrototype");
        Cursor.visible = false;

    }

    public void QuitGame()
    {
        Debug.Log("Thanks for playing");
        Application.Quit();
    }
    
    // Update is called once per frame
    void Update()
    {
        timer.gameObject.SetActive(false);
        if (this.enabled)
        {
            Cursor.visible = true;
        }
        
        
        {
            if (Input.GetKey(KeyCode.P))
            {
                Application.Quit();
                Debug.Log("Thanks for playing");   
            }

            if (Input.GetKey(KeyCode.I))
            {
                SceneManager.LoadScene("PostPrototype");
            }
        }
;    }
}
