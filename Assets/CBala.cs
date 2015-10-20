using UnityEngine;
using System.Collections;

public class CBala : MonoBehaviour {

    private float tiempo = 5f;
    public Collider2D[] conejos;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //yield return new WaitForSeconds(5);
        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;
        }
        else
        {
            conejos = Physics2D.OverlapCircleAll(this.transform.position, 1f);
            //this.GetComponent<Rigidbody>().AddExplosionForce(10f, this.transform.position,10f);

            //Destroy(gameObject);
            foreach (Collider2D col in conejos)
            {
                if (col.name.Equals("Rabbit_1"))
                {
                    Destroy(col);
                    
                }
            }
            Destroy(gameObject);
        }


    }
}
