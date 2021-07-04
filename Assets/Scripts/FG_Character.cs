using UnityEngine;

public class FG_Character : MonoBehaviour
{
    [Header("Character Settings")]
    [SerializeField] private float movementSpeed = 0.05f;

    [Header("Character References")]
    [SerializeField] private Animator anim;

    private void move(float movement) => transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + movement);

    public void moveLeft() => move(-movementSpeed);
    public void moveRight() => move(movementSpeed);

    public void attack() => anim.Play("FG_Dummy_Attack");
    public void defendStart() => anim.Play("FG_Dummy_Defend_Start");
    public void defendStop() => anim.Play("FG_Dummy_Defend_Stop");

    public void takeDamage() => Debug.Log(gameObject.transform.parent.gameObject.name + " says 'OUCH'.");
}
