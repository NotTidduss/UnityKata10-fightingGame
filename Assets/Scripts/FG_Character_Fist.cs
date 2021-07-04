using UnityEngine;

public class FG_Character_Fist : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Body") {
            collision.transform.parent.parent.GetComponent<FG_Character>().takeDamage();
        }
    }
}
