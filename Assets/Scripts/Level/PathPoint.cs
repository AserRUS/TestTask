using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PathPoint : MonoBehaviour
{
    [SerializeField] private float angle;
    [SerializeField] private bool isFinish;

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.transform.parent.GetComponent<Player>();
        if (player == null) return;
        if (isFinish)
        {
            GameController.Default.Finish();
        }
        else
        {
            player.Rotation(angle);
        }

    }
}
