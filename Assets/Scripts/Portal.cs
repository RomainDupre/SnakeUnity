using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform _spawnTo;

    /**
     * On trigger enter 2D
     */
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Teleporting player to " + _spawnTo.position);
            other.transform.position = _spawnTo.position;
        }
    }
}
