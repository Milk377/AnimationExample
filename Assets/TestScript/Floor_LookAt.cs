using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// sol1

/*
��� ��ü�� Ʈ�������� ���¸� ���������ִ� �Լ��� fixed update ���� ��� ��������ش�.

�������� ��ġ�� �̵��� �� �ְ�, �� �̵����� ����ȭ�� ���̶�� Lerp�� interpolation�� ���� �߰����� �������� ��������

�׸� ���ؼ� �ִϸ��̼��� ���� �ȴ�.
*/

public class Floor_LookAt : MonoBehaviour
{
    public GameObject TargetObject1;

    public List<GameObject> TargetObjects;
    

    // Start is called before the first frame update
    void Start()
    {
        TargetObject1 = GameObject.Find("Target1");
        
    }

    public void LookAt1()
    {
        Vector3 convertTargetPos = new Vector3(TargetObject1.transform.position.x,
            this.transform.position.y, TargetObject1.transform.position.z);

        this.transform.LookAt(convertTargetPos);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LookAt1();

        }
    }
}
