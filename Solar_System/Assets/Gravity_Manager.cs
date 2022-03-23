using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity_Manager : MonoBehaviour
{
    float G = 100f;
    GameObject[] celestials;
    // Start is called before the first frame update
    void Start()
    {
        celestials = GameObject.FindGameObjectsWithTag("Celestial");
        InitialVelocity();
        foreach(GameObject i in celestials){
            i.GetComponent<Rigidbody>().AddTorque(0,1,0,ForceMode.VelocityChange);
        }
    }
    
   private void FixedUpdate() {
        Gravity();

    }
    
    void Gravity(){
        foreach (GameObject i in celestials)
        {
            foreach(GameObject j in celestials){
                if(!i.Equals(j)){
                    float m1 = i.GetComponent<Rigidbody>().mass;
                    float m2 = j.GetComponent<Rigidbody>().mass;
                    float r = Vector3.Distance(i.transform.position,j.transform.position);
                    
                    i.GetComponent<Rigidbody>().AddForce((j.transform.position - i.transform.position).normalized * (G * (m1 * m2) / (r * r)));
                }
            }
            
        }
    }

    void InitialVelocity() {
        foreach (GameObject a in celestials){
            foreach(GameObject b in celestials){
                    if(!a.Equals(b)){
                        float m2 = b.GetComponent<Rigidbody>().mass;
                        float r = Vector3.Distance(a.transform.position, b.transform.position);
                        a.transform.LookAt(b.transform);

                        a.GetComponent<Rigidbody>().velocity += a.transform.right * Mathf.Sqrt((G * m2)/r);
                    }
            }
        }
    }
}