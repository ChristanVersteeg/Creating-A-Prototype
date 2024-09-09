using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    private string Scene => SceneManager.GetActiveScene().path;

    private LoadSceneParameters loadSceneMode = new(LoadSceneMode.Single);

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            EditorSceneManager.LoadSceneAsyncInPlayMode(Scene, loadSceneMode);
        }
    }
}
