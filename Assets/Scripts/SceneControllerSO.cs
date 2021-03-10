using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Scene Controller SO", menuName = "Scene Controller")]
public class SceneControllerSO : ScriptableObject
{
    public void LoadScene(string sceneName) => SceneManager.LoadScene(sceneName);
    public void LoadScene(int buildIndex) => SceneManager.LoadScene(buildIndex);
}
