using GoudKoortsV2.Builder;

namespace GoudKoortsV2.Controller
{
    public class GameController
    {
        private Map _map;
        public GameController()
        {
            init();
        }

        private void init()
        {
            _map = new MapBuilder().buildMap();
        }

        public void start()
        {
            
        }
    }
}