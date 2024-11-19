using UnityEngine;
using UnityEngine.SceneManagement;

public class UICont : MonoBehaviour
{
    public GameObject fir;
    public GameObject timer;
    public GameObject guideUI;
    public GameObject gameOverUI;


    void Start()
    {
        fir.SetActive(true);
        timer.SetActive(false);
        guideUI.SetActive(false);
        gameOverUI.SetActive(false);
    }

    
    void Update()
    {
        
    }

     public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverUI.SetActive(false);
    }
}
