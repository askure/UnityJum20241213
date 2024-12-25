
namespace Battle
{
    public class Model
    {
        private int _suervive = 0;
        public int Ssuervive => _suervive;

        public Model(int suervive)
        {
            _suervive = suervive;
        }
        public UiView.ViewData GetUiViewData()
        {
            return new UiView.ViewData(_suervive);
        }
        public Player.View.ViewData GetPlayerViewData()
        {
            return new Player.View.ViewData();
        }
    }
}

