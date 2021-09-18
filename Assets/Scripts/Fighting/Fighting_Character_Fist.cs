using UnityEngine;

public class Fighting_Character_Fist : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Body") {
            collision.transform.parent.parent.GetComponent<Fighting_Character>().takeDamage();
        }
    }
}
