using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navegationMenu : MonoBehaviour
{
    public void CallCourse()
    {
        SceneManager.LoadScene("ListCourses");
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
