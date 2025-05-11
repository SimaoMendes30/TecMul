using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void RestartLevel()
    {
        if (!string.IsNullOrEmpty(FimDoLabirinto.LastSceneName))
        {
            SceneManager.LoadScene(FimDoLabirinto.LastSceneName);
        }
        else
        {
            Debug.LogError("Nome da cena anterior não encontrado!");
        }
    }
}
