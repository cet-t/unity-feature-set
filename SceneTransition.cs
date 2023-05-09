// for Unity

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] string stage = "Stage";
    [SerializeField] string tag = "Player";

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag(tag))
        {
            var _scene = SceneManager.GetActiveScene().name;
            var ar = int.Parse(_scene.Replace(stage, ""));
            
            SceneManager.LoadScene(stage + (ar + 1));
        }
    }
}
