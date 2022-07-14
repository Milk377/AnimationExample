using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim2 : MonoBehaviour
{
    Vector3 targetRotation;

    public void Rotate1()
    {
        // 90에 도달하는 순간 끝인데 계속 도니까 뻑뻑한다.
        // 도달시 멈추는걸로 하니까 끝 
        Vector3 nowRotation = gameObject.transform.rotation.eulerAngles;

        if (gameObject.transform.rotation.eulerAngles.x < Quaternion.Euler(targetRotation).eulerAngles.x) 
        {
            gameObject.transform.rotation = Quaternion.Euler(nowRotation + new Vector3(2, 0, 0));

        } 
        else if (gameObject.transform.rotation.eulerAngles.x >= Quaternion.Euler(targetRotation).eulerAngles.x)
        {
            StopCoroutine("DoRotate1");
            Debug.Log("StopCoroutine Rotate1");
        }
    }

    IEnumerator DoRotate1()
    {
        for (; ; )
        {
            Rotate1();
            yield return new WaitForSeconds(.01f);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        targetRotation = gameObject.transform.rotation.eulerAngles + new Vector3(90,0,0);

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
