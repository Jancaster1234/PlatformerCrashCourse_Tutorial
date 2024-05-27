using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] bool goNextLevel;
    [SerializeField] string levelName;
    private void OnTriggerEnter(Collider collision)
    {
        // Check if the object entering the trigger is the player
        if (collision.CompareTag("Player"))
        {
            if (goNextLevel)
            {
                Debug.Log("Entered Trigger: " + collision.name);
                SceneController.instance.NextLevel();
            }
            else
            {
                Debug.Log("Entered Trigger: " + collision.name);
                SceneController.instance.LoadScene(levelName);
            }
        } else
        {
            Debug.Log("Entered Trigger: " + collision.name);
        }
    }

    private void LoadNextScene()
    {
#if (UNITY_EDITOR || DEVELOPMENT_BUILD)
        Debug.Log(this.name + " : " + this.GetType() + " : " + System.Reflection.MethodBase.GetCurrentMethod().Name);
#endif

        SceneManager.LoadScene("GameplayScene1");
    }
}
