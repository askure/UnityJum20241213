using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Title
{
    public class View : MonoBehaviour
    {
        
        public static View Create()
        {

            var prefab = Resources.Load<View>("Prefab/title_ui");
            var canvasRoot = GameObject.Find("Canvas").transform;
            var view = Instantiate(prefab, canvasRoot);
            view.SetUp();
            return view;
        }

        private void SetUp()
        {
        }
    }
}

