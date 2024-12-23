public class SceneManager
{
    public static void ChangeScene(string sceneName)
    {
        if (sceneName == null) return;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
