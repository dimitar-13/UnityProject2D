using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] float damange = 10.0f;
    [SerializeField] float range = 2.0f;

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePositionWorldCoords;
        
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            mousePositionWorldCoords = Camera.main.ScreenToWorldPoint(Input.mousePosition);     
            if(IsAttackInRange(mousePositionWorldCoords))
            {
                Debug.Log("Attack in range");
            }
            else
            {
                Debug.Log("Attack is not in range");
            }
            Debug.Log(string.Format("Player attacked at mouse pos x={0} y={1}.", mousePositionWorldCoords.x, mousePositionWorldCoords.y));
        }
    }
    bool IsAttackInRange(Vector2 mousePosition)
    {
        Vector2 objectPos = this.gameObject.transform.position.ConvertTo<Vector2>();
        return Vector2.Distance(objectPos, mousePosition) <= range;
    }
}
