using UnityEngine;
using System.Collections;

public class DialogueTrigger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.5f;
    }

    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.name == "NPC1" || collisionInfo.collider.name == "NPC2" ||  
            collisionInfo.collider.name == "NPC3") {
            StartCoroutine(dialogueBreak());
        }
    }

    IEnumerator dialogueBreak() {
        Debug.Log("NPC Dialogue time triggered");
        Time.timeScale = 0f;
        Debug.Log("Time frozen");
        yield return new WaitForSecondsRealtime(5.0f);
        Debug.Log("Time unfrozen");
        Time.timeScale = 1.5f;
    }

}
