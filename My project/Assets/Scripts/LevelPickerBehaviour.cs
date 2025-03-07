using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPickerBehaviour : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
