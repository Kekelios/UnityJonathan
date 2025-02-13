using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void LoadTheLevelByName(string NomDeMap)
    {
        SceneManager.LoadScene(NomDeMap);
    }

    public void LoadSceneByIndex(int numeroIndex)
    {
        SceneManager.LoadScene(numeroIndex);
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
