using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class SceneChange : MonoBehaviour
{

    void Start()
    {

    }
    [YarnCommand("MyScene2")]
    public void MyScene2()
    {
        SceneManager.LoadScene("Explore_Mansion");
    }

    [YarnCommand("MyScene3")]
    public void MyScene3()
    {
        SceneManager.LoadScene("The_Canvas_&_The_Entity");
    }

    [YarnCommand("MyScene4")]
    public void MyScene4()
    {
        SceneManager.LoadScene("Ending_1_The_Cursed_Canvas");
    }
    [YarnCommand("MyScene5")]
    public void MyScene5()
    {
        SceneManager.LoadScene("Ending_2_The_Cursed_Canvas");
    }

}
