using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim1 : MonoBehaviour
{
    enum axisValue
    {
        x = 0,
        y= 1,
        z = 2
    }

    public GameObject Object_Anim1;
    public float rotationSpeed;
    public float preVRotation;
    public bool PrevRotationValue;

    // Start is called before the first frame update
    void Start()
    {
        Object_Anim1 = gameObject;
        
    }

    public void rotationZ(float speed)
    {
        rotationSpeed = speed;
        Object_Anim1.transform.Rotate(0, 0, 1 * rotationSpeed * Time.deltaTime,Space.Self);
    }

    public void rotation1(int axis, float speed)
    {

        switch (axis)
        {
            case 0:
                Object_Anim1.transform.Rotate(1 * speed * Time.deltaTime, 0, 0, Space.Self);
                break;
            case 1:
                Object_Anim1.transform.Rotate(0, 1 * speed * Time.deltaTime, 0, Space.Self);
                break;
            case 2:
                Object_Anim1.transform.Rotate(0, 0, 1 * speed * Time.deltaTime, Space.Self);
                break;
        }

    }

    //¿ÀÂ÷À² 0 ~ 0.04
    public void rotation2(float speed, float rotationAngle)
    {
        if (!PrevRotationValue)
        {
            preVRotation = Object_Anim1.transform.eulerAngles.x;
            PrevRotationValue = true;
        }

        float nowRotation = Object_Anim1.transform.eulerAngles.x;

        if (nowRotation < preVRotation + rotationAngle)
        {
            Object_Anim1.transform.Rotate(1 * speed * Time.deltaTime, 0, 0, Space.Self);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //rotationZ(100);
        //rotation1(2, 100);
        rotation2(10,90);

    }
}
