using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ƒ^ƒCƒgƒ‹‰æ–Ê

public class TitleManager : MonoBehaviour
{   
    public static string SceneName = "Title";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.ChangeScene(BattleManager.SceneName);
        }
    }


}
