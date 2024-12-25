using UnityEngine;

namespace Battle
{
    public class Control
    {
        Model model;
        UiView  uiView;
        Player.View playerView;
        Player.Conrtol playerConrtol;
        Enemy.View enemyView;
        Enemy.Control enemyControl;
        private const int INIT_SURVIVE = 0;
        System.Action<bool> _leftAction = null;
        System.Action<bool> _rightAction = null;
        System.Action<bool> _upAction = null;
        System.Action<bool> _underAction = null;
        public Control(Transform player) 
        {
            model = new Model(INIT_SURVIVE);
            uiView = UiView.Create(model.GetUiViewData());
            playerView = Player.View.Create(model.GetPlayerViewData(), player);
            playerConrtol = playerView.gameObject.GetComponent<Player.Conrtol>();  
            enemyView = Enemy.View.Create(null);
            enemyControl = enemyView.gameObject.GetComponent<Enemy.Control>();
            enemyControl.GetPlayer(playerConrtol);
            _leftAction = (bool isActive) =>
            {
                if(playerView != null)
                {
                    playerView.LeftActive(isActive);
                }
            };
            _rightAction = (bool isActive) => { 
                if(playerView != null)
                {
                    playerView.RightActive(isActive);
                }
            };
            _upAction = (bool isActive) =>
            {
                if (playerView != null)
                {

                    playerView.UpActive(isActive);
                }
            };

            _underAction = (bool isActive) =>
            {
                if (playerView != null)
                {
                    playerView.UnderActive(isActive);
                }
            };
        }

        public void Update()
        {
            // 毎フレームMangerから渡されるtimeをチェックする

        }

        public System.Action<bool>[] GetActions()
        {
            return new System.Action<bool>[] { _leftAction, _rightAction, _upAction, _underAction };
        }
    }

}
