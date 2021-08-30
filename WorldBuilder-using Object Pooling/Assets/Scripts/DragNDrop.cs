using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragNDrop : MonoBehaviour
{
    private bool _dragging;
    private Vector2 _offset;
    public BoxCollider2D GridArea;
    public bool _validArea;
    void OnEnable()
    {
        GridArea = GameObject.FindGameObjectWithTag("grid").GetComponent<BoxCollider2D>();
    }

 
    void Update()
    {
        var mousePosition = GetMousePos();
        if(!_dragging)
        {
            GetComponent<SpriteRenderer>().color = Color.white;
            return;
        }
        transform.position = mousePosition - _offset;
        CheckArea();
       
  
    }
   
    void OnMouseDown()
    {
       
            _dragging = true;
            _offset = GetMousePos() - (Vector2)transform.position;
   
    }
    void OnMouseUp()
    {
        _dragging = false;
        if(_validArea)
        {
            return;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void CheckArea()
    {
        Bounds bounds = this.GridArea.bounds;
        float Minx = bounds.min.x;
        float MinY = bounds.min.y;
        float Maxx = bounds.max.x;
        float MaxY = bounds.max.y;
        if((GetMousePos().x < Maxx && GetMousePos().x > Minx) && (GetMousePos().y < MaxY && GetMousePos().y > MinY))
        {
            _validArea = true;
            if (_dragging)
            { GetComponent<SpriteRenderer>().color = Color.white; }

        }
        else
        {
            _validArea = false;
            if (_dragging)
            { GetComponent<SpriteRenderer>().color = Color.red; }
           
        }

    }

    
}
