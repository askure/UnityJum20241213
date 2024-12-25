namespace Sys
{
    public class Scene
    {
        public static void ChangeScene(string sceneName)
        {
            if (sceneName == null) return;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }


}

