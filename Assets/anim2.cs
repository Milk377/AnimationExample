using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim2 : MonoBehaviour
{
    public void Rotate1()
    {
        // 90에 도달하는 순간 끝인데 계속 도니까 뻑뻑한다.
        Vector3 nowRotation = gameObject.transform.rotation.eulerAngles;
        gameObject.transform.rotation = Quaternion.Euler(nowRotation + new Vector3(1, 0, 0));
    }

    IEnumerator DoRotate1()
    {
        for (; ; )
        {
            Rotate1();
            yield return new WaitForSeconds(.1f);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            StartCoroutine("DoRotate1");
        }
    }
}
