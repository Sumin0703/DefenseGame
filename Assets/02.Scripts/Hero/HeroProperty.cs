using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroProperty : MonoBehaviour
{
    #region ���� �ɷ�ġ
    private float _attackPower;
    public float AttackPower
    {
        get { return _attackPower; } 
        set { _attackPower = Mathf.Max(0, value); }
    }

    private float _attackSpeed;
    public float AttackSpeed
    {
        get { return _attackSpeed; }
        set { _attackSpeed = Mathf.Max(0.1f, value); } // ���ݼӵ��� 0.1 �̻��̾�� ��
    }

    private float _attackRange;
    public float AttackRange
    {
        get { return _attackRange; }
        set { _attackRange = Mathf.Max(0, value); } 
    }

    private float _skillCoolDown;
    public float SkillCoolDown
    {
        get { return _skillCoolDown; }
        set { _skillCoolDown = Mathf.Max(0, value); }
    }
    #endregion

    #region ��Ÿ �ʵ�
    protected Transform []target;

    #endregion
    // Start is called before the first frame update

    #region �ൿ
    protected void Attack()
    {

    }
    #endregion


    void Start()
    {
        
    }

    // Update is called once per frame
    protected void Update()
    {
        
    }

}
