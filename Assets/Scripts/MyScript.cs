using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print("start!!!");
    }

    // Update is called once per frame
    void Update()
    {
        //print("update!!");
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("alpha1 down");
            SceneManager.LoadScene("Week02_Terrain");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("a down");
            SceneManager.LoadScene("Week02_3DObjects");
        }
    }
}
