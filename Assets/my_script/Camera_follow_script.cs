using UnityEngine;
using System.Collections;

public class Camera_follow_script : MonoBehaviour {
    float distance = 6.0f;
    float height = 2.0f;
    float heightDamping = 9.0f;
    float rotationDamping = 6.0f;
	
	// Update is called once per frame
	void Update () {
        float wantedRotationAngle = transform.eulerAngles.y;
        float wantedHeight = transform.position.y + height;

        float currentRotationAngle = Camera.main.transform.eulerAngles.y;
        float currentHeight = Camera.main.transform.position.y;

        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

        Quaternion currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

        Camera.main.transform.position = transform.position;
        Camera.main.transform.position -= currentRotation * Vector3.forward * distance;
        Vector3 temp = Camera.main.transform.position;
        temp.y = currentHeight;
        Camera.main.transform.position = temp;

        Camera.main.transform.LookAt(transform);
    }
}
