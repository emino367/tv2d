using UnityEngine;
using System.Collections;

public class ControladorCañon : MonoBehaviour {

    public float rotar = 0.3f;
    public float posicionMouse1=0f;
    public float posicionMouse2;
    public float diferencia=0f;
    public float AngleDeg;
    public Transform b;

    public Vector3 gunPosVector { get; private set; }

    // Use this for initialization
    void Start () {
        gunPosVector = Camera.main.WorldToScreenPoint(transform.position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
    void Update () {

       
        float AngleRad = Mathf.Atan2(Input.mousePosition.y - gunPosVector.y, Input.mousePosition.x - gunPosVector.x);
        float hip = (Input.mousePosition.y - gunPosVector.y) / Mathf.Cos(AngleRad);
        AngleDeg = AngleRad * Mathf.Rad2Deg;
        if (AngleDeg < 90 && AngleDeg > 0 )
        {
            transform.rotation = Quaternion.Euler(0, 0, AngleDeg);
        }  
        
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = (GameObject)Instantiate(b, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector3(Input.mousePosition.x - gunPosVector.x, 10*(Input.mousePosition.y - gunPosVector.y), 0));
                  
        }
    }
}
