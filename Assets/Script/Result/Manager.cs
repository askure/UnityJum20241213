using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Result {

    public class Manager : MonoBehaviour
    {
        // Start is called before the first frame update
        public static string SceneName = "Result";
        Control control = null;
        private void Awake()
        {
            control = new Control();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Sys.Scene.ChangeScene(Title.Manager.SceneName);
            }
        }
    }
}


