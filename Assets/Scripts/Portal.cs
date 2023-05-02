
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform _spawnTo;

    [SerializeField] private Collider2D _collider2D;
    
    /**
     * On trigger enter 2D
     */
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D");
        if (other.tag == "Player")
        {
            Debug.Log("trigger entered player");
            other.transform.position = _spawnTo.position;
        }
    }
}
