using UnityEngine;

public class Ice : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            other.GetComponent<Snake>().IsMoving = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Player") {
            other.GetComponent<Snake>().IsMoving = true;
        }
    }
}