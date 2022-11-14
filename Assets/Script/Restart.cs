using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    public Transform tr;
    public GameObject shaiba;
    public void RestartScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void StartScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Shaiba()
    {
        shaiba.transform.position = tr.transform.position;
    }
}