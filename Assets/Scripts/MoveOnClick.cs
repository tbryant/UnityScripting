using UnityEngine;
using System.Collections;

public class MoveOnClick : MonoBehaviour
{

    private Vector3 targetPosition;
    public float speed = 25;
    public GameObject clickEffect;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            Plane playerPlane = new Plane(Vector3.up, transform.position);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float hitdist = 0.0f;

            if (playerPlane.Raycast(ray, out hitdist))
            {
                Vector3 targetPoint = ray.GetPoint(hitdist);
                targetPosition = ray.GetPoint(hitdist);
                Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
                transform.rotation = targetRotation;
            }
        }

        Vector3 dir = targetPosition - transform.position;
        float dist = dir.magnitude;
        float move = speed * Time.deltaTime;

        if (dist > move)
        {
            transform.position += dir.normalized * move;
            if (clickEffect != null)
            {
                Instantiate(clickEffect, targetPosition, Quaternion.identity);
            }
        }
        else {
            transform.position = targetPosition;
        }

        transform.position += (targetPosition - transform.position).normalized * speed * Time.deltaTime;

    }
}