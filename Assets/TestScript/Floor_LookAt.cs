using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// sol1

/*
모든 물체의 트랜스폼의 상태를 고정시켜주는 함수를 fixed update 에서 계속 실행시켜준다.

최종적인 위치에 이동할 수 있고, 그 이동값이 최적화된 값이라면 Lerp와 interpolation을 통해 중간값을 설정값을 가져오고

그를 통해서 애니메이션을 따면 된다.
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
