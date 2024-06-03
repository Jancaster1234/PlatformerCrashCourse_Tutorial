using UnityEngine;
using UnityEngine.SceneManagement;

//public class FinishPoint : MonoBehaviour
//{
//    [SerializeField] bool goNextLevel;
//    [SerializeField] string levelName;
//    private void OnTriggerEnter(Collider collision)
//    {
//        Debug.Log("OnTriggerEnter method called");

//        // Check if the object entering the trigger is the player
//        if (collision.CompareTag("Player"))
//        {
//            Debug.Log("Collision with Player detected");

//            if (goNextLevel)
//            {
//                Debug.Log("goNextLevel is true");
//                Debug.Log("Entered Trigger: " + collision.name);
//                SceneController.instance.NextLevel();
//            }
//            else
//            {
//                Debug.Log("goNextLevel is false");
//                Debug.Log("Entered Trigger: " + collision.name);
//                SceneController.instance.LoadScene(levelName);
//            }
//        }
//        else
//        {
//            Debug.Log("Collision with non-Player object detected: " + collision.name);
//        }
//    }


//    private void LoadNextScene()
//    {
//#if (UNITY_EDITOR || DEVELOPMENT_BUILD)
//        Debug.Log(this.name + " : " + this.GetType() + " : " + System.Reflection.MethodBase.GetCurrentMethod().Name);
//#endif

//        SceneManager.LoadScene("GameplayScene1");
//    }
//}
public class FinishPoint : MonoBehaviour
{
    [SerializeField] private string nextSceneName; // Name of the next scene to load

    //private void OnTriggerEnter(Collider other)

    //{
    //    Debug.Log("OnTriggerEnter method called");
    //    // Check if the object entering the trigger is the player
    //    if (other.CompareTag("Player"))
    //    {
    //        Debug.Log("Collision with Player detected");
    //        LoadNextScene();
    //    }
    //    else
    //    {
    //        Debug.Log("Collision with non-Player object detected: " + other.name);
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter method called");
        // Check if the object entering the trigger is the player
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Collision with Player detected");
            LoadNextScene();
        }
        else
        {
            Debug.Log("Collision with non-Player object detected: " + collision.name);
        }
    }
    private void LoadNextScene()
    {
        Debug.Log("Loading next scene: " + nextSceneName);
        SceneManager.LoadScene(nextSceneName);
    }
}