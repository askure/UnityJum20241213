using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ƒ^ƒCƒgƒ‹‰æ–Ê
namespace Title
{
    public class Manager : MonoBehaviour
    {
        public static string SceneName = "Title";
        Control control = null;
        // Start is called before the first frame update
        void Start()
        {
            control = new Control();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Sys.Scene.ChangeScene(Battle.Manager.SceneName);
            }
        }


    }
}


