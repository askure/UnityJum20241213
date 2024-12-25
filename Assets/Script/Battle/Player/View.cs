using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Battle.Player
{
    public class View : MonoBehaviour
    {
        public class ViewData
        {
            public Sprite PlayerIcon;
            public Sprite ShieldLeftIcon;
            public Sprite ShieldRightIcon;
            public Sprite ShieldUpIcon;
            public Sprite ShieldUnderIcon;

        }
        // Start is called before the first frame update
        [SerializeField] Transform _posShieldLeft = null;
        [SerializeField] Transform _posShieldRight = null;
        [SerializeField] Transform _posShiledUp = null;
        [SerializeField] Transform _posShieldUnder = null;
        [SerializeField] SpriteRenderer _iconPlayer = null;
        Shield.View ShieldLeft = null;
        Shield.View ShieldRignt = null;
        Shield.View ShieldUp = null;
        Shield.View ShieldUnder = null;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public static View Create(ViewData viewData, Transform pos)
        {
            var prefab = Resources.Load<View>("Prefab/player");
            var view = Instantiate(prefab, pos);
            view.SetUp(viewData);
            return view;
        }
        private void SetUp(ViewData viewData)
        {
            // TODO: ƒAƒCƒRƒ““±“üˆ—‚Å‚«‚½‚ç–ß‚·
            //this._iconPlayer.sprite  = viewData.PlayerIcon;
            ShieldLeft = Shield.View.Create(viewData.ShieldLeftIcon, _posShieldLeft);
            ShieldRignt = Shield.View.Create(viewData.ShieldRightIcon, _posShieldRight);
            ShieldUp = Shield.View.Create(viewData.ShieldUpIcon, _posShiledUp);
            ShieldUnder = Shield.View.Create(viewData.ShieldUnderIcon, _posShieldUnder);
            LeftActive(false);
            RightActive(false);
            UpActive(false);
            UnderActive(false);
        }

        public void LeftActive(bool isActive)=> ShieldLeft.Obj.SetActive(isActive);
        public void RightActive(bool isActive)=> ShieldRignt.Obj.SetActive(isActive);
        public void UpActive(bool isActive)=> ShieldUp.Obj.SetActive(isActive); 
        public void UnderActive(bool isActive) => ShieldUnder.Obj.SetActive(isActive);

    }
}

