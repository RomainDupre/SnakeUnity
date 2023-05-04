using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;
    private List<Transform> _segments;
    public Transform segmentPrefab;

    public bool IsMoving { get; set; }

    private void Start(){
        this.IsMoving = true;
        _segments = new List<Transform>();
        _segments.Add(this.transform);
        CreateBaseState();
    }
    private void Update(){
        if(!IsMoving){
            return;
        }
        if(Input.GetKeyDown(KeyCode.Z) && _direction != Vector2.down){
            _direction = Vector2.up;
        }
        if(Input.GetKeyDown(KeyCode.Q) && _direction != Vector2.right){
            _direction = Vector2.left   ;
        }
        if(Input.GetKeyDown(KeyCode.S) && _direction != Vector2.up){
            _direction = Vector2.down;
        }
        if(Input.GetKeyDown(KeyCode.D) && _direction != Vector2.left){
            _direction = Vector2.right;
        }
        
    }

    private void FixedUpdate(){
        for(int i = _segments.Count - 1; i > 0; i--){
            _segments[i].position = _segments[i-1].position;
        }
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + _direction.x,
            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f
        );
    }

    private void ResetState(){
        for (int i = 1; i < _segments.Count; i++){
            Destroy(_segments[i].gameObject);
        }
        _segments.Clear();
        _segments.Add(this.transform);
        this.transform.position = Vector3.zero;
        CreateBaseState();
        this.IsMoving = true;
    }

    private void CreateBaseState()
    {
        for (int i = 1; i < 4; i++)
        {
            Grow();
        }
    }

    private void Grow(){
        Transform segment = Instantiate(this.segmentPrefab);
        segment.position = _segments[_segments.Count-1].position;
        _segments.Add(segment);
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Food"){
            Grow();
        } else if (other.tag == "Obstacle"){
            ResetState();
        }
        
    }
}
