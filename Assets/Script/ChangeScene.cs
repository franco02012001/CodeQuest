using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GoToUserName()
    {
        
        SceneManager.LoadScene("UserName");
    }

    public void GoToMainpage()
    {
        
        SceneManager.LoadScene("Mainpage");
    }
    public void GoToSever()
    {
        
        SceneManager.LoadScene("Server");
    }
    public void GoToLandingPage()
    {

        SceneManager.LoadScene("LandingPage");
    }
    public void GoToWelcome()
    {

        SceneManager.LoadScene("Welcome");
    }


}
