using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle.Shield
{
    public class View : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] SpriteRenderer icon;
        public GameObject Obj => gameObject;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public static View Create(Sprite icon, Transform pos)
        {
            var prafab = Resources.Load<View>("Prefab/shield");
            var view = Instantiate(prafab, pos);
            view.SetUp(icon);
            return view;
        }

        private void SetUp(Sprite icon)
        {   
            // TODO: ƒAƒCƒRƒ““±“üˆ—‚Å‚«‚½‚ç–ß‚·
            //this.icon.sprite = icon;
        }
        
    }
}

