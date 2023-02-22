using UnityEngine;

public class Player : MonoBehaviour
{
    private bool hasKey;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name.Contains("�_��"))
        {
            hasKey = true;
            Destroy(hit.gameObject);
        }

        if (hit.gameObject.name.Contains("��"))
        {
            if (hasKey)
            {
                hit.transform.parent.GetComponent<Animator>().enabled = true;
            }
        }
    }
}
