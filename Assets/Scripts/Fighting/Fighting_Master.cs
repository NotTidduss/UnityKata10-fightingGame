using System.Collections;
using UnityEngine;

public class Fighting_Master : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] private Fighting_System sys;
    [SerializeField] private Transform charSpawnP1;
    [SerializeField] private Transform charSpawnP2;

    [Header("Prefab References")]
    [SerializeField] private GameObject prefabCharP1;
    [SerializeField] private GameObject prefabCharP2;

    private GameObject charObjectP1;
    private GameObject charObjectP2;
    private Fighting_Character charP1;
    private Fighting_Character charP2;

    void Start() {
        initializeChars();

        StartCoroutine("CheckForButtonLongPress");
        StartCoroutine("CheckForButtonShortPress");
        StartCoroutine("CheckForButtonRelease");
    }

    IEnumerator CheckForButtonLongPress() {
        while (true) {
            if (Input.GetKey(sys.inputMoveLeftP1)) charP1.moveLeft();
            if (Input.GetKey(sys.inputMoveRightP1)) charP1.moveRight();

            if (Input.GetKey(sys.inputMoveLeftP2)) charP2.moveLeft();
            if (Input.GetKey(sys.inputMoveRightP2)) charP2.moveRight();

            yield return null;
        }
    }

    IEnumerator CheckForButtonShortPress() {
        while (true) {
            if (Input.GetKeyDown(sys.inputAttackP1)) charP1.attack();
            if (Input.GetKeyDown(sys.inputDefendP1)) charP1.defendStart();

            if (Input.GetKeyDown(sys.inputAttackP2)) charP2.attack();
            if (Input.GetKeyDown(sys.inputDefendP2)) charP2.defendStart();

            yield return null;
        }
    }

    IEnumerator CheckForButtonRelease() {
        while (true) {
            if (Input.GetKeyUp(sys.inputDefendP1)) charP1.defendStop();
            if (Input.GetKeyUp(sys.inputDefendP2)) charP2.defendStop();

            yield return null;
        }
    }

    private void initializeChars() {
        charObjectP1 = Instantiate(prefabCharP1, charSpawnP1);
        charObjectP2 = Instantiate(prefabCharP2, charSpawnP2);

        charP1 = charObjectP1.GetComponent<Fighting_Character>();
        charP2 = charObjectP2.GetComponent<Fighting_Character>();
    }
}
