using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState
{
    Idle = 0,
    Patrolling,
    Socializing
};

public class EnemyScript : MonoBehaviour {

    EnemyState _EnemyState;

    float _Timer = 0;
    int _Index = 0;

    [SerializeField]
    private Transform[] _TargetPoints;

	void Start () {
        _EnemyState = EnemyState.Idle;
	}
	
	void Update () {

        if (_Index >= _TargetPoints.Length)
        {
            _Index = 0;
        }

        switch (_EnemyState)
        {
            case EnemyState.Idle:
                IdleBehaviour();
                break;

            case EnemyState.Patrolling:
                PatrolBehaviour();
                break;

            case EnemyState.Socializing:
                SocializeBehaviour();
                break;
        }

	}

    public void IdleBehaviour()
    {
        _Timer += Time.deltaTime;

        if(_Timer >= 1)
        {
            _Timer = 0;
            _Index += 1;
            _EnemyState = EnemyState.Patrolling;
        }
    }

    public void PatrolBehaviour()
    {

        transform.position = Vector2.MoveTowards(transform.position, _TargetPoints[_Index].position, 4 * Time.deltaTime);

        Vector3 dir = _TargetPoints[_Index].position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        if(Vector2.Distance(transform.position, _TargetPoints[_Index].position) < 0.5)
        {
            _EnemyState = EnemyState.Idle;
        }
    }

    public void SocializeBehaviour()
    {

    }
}
