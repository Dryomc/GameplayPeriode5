using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCone : MonoBehaviour
{
    [SerializeField]
    private Transform _Player;

    [SerializeField]
    private LayerMask _RayCastLayer;

    private Vector2 _EnemyForward;

    [SerializeField]
    private GameManager _GameManager;

    void Update()
    {
        Vector2 playerDirection = transform.position - _Player.transform.position;
        _EnemyForward = transform.up;
        Debug.DrawRay(transform.position, playerDirection, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, playerDirection);
        float angle = Vector2.Angle(_EnemyForward, playerDirection);
        float distance = Vector2.Distance(transform.position, _Player.transform.position);
        if (hit)
        {

            if (angle > 160 && distance < 9)
            {
                print("Caught");
                _GameManager._GameState = GameState.Caught;
            }
        }
        //for(int i = 0; i < hit.Length; i++)
        //{
        //    Debug.Log("Hoi " + hit[i].collider.gameObject.tag, hit[i].collider.gameObject);

        //    if (hit[i].collider.gameObject.tag == "Player")
        //    {
        //        if (angle > 160 && distance < 9)
        //        {
        //            print("Caught");
        //        }
        //    }            
        //}      
    }
}
