using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim3 : MonoBehaviour
{
    Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = gameObject.transform.rotation.eulerAngles + new Vector3(45,0,0);
        
    }

    public void X90()
    {
        Vector3 nowRotation = gameObject.transform.rotation.eulerAngles;

        if(gameObject.transform.rotation.eulerAngles.x <
            Quaternion.Euler(target).eulerAngles.x)
        {
            gameObject.transform.rotation = Quaternion.Euler(
                nowRotation + new Vector3(1, 0, 0));
        } else
        {
            StopCoroutine("RotateX90");
        }
        //gameObject.transform.rotation.eulerAngles.x == Quaternion.Euler(target).eulerAngles.x

    }

    IEnumerator RotateX90()
    {
        for(; ; )
        {
            X90();
            yield return new WaitForSeconds(0.01f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("RotateX90");
        }
    }
}
