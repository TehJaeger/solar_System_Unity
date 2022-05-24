using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gravity_Manager : MonoBehaviour
{
    public float G = 100f;
    public GameObject[] planets;

    GameObject[] celestials;
    // Start is called before the first frame update
    void Start()
    {
        int cont = 0;
        foreach(GameObject i in planets){
        switch (cont)
        {
            case 1:
                Instantiate(planets[1],new Vector3(580,0,0),Quaternion.identity,transform);
                break;
            case 2:
                Instantiate(planets[2],new Vector3(1083,0,0),Quaternion.identity,transform);
                break;
            case 3:
                Instantiate(planets[3],new Vector3(1510,0,0),Quaternion.identity,transform);
                break;
            case 4:
                Instantiate(planets[4],new Vector3(1515,0,0),Quaternion.identity,transform);
                break;
            case 5:
                Instantiate(planets[5],new Vector3(2160,0,0),Quaternion.identity,transform);
                break;
            case 6:
                Instantiate(planets[6],new Vector3(7449,0,0),Quaternion.identity,transform);
                break;
            case 7:
                Instantiate(planets[7],new Vector3(14791,0,0),Quaternion.identity,transform);
                break;
            case 8:
                Instantiate(planets[8],new Vector3(29480,0,0),Quaternion.identity,transform);
                break;
            case 9:
                Instantiate(planets[9],new Vector3(44745,0,0),Quaternion.identity,transform);
                break;
            default:
                Instantiate(planets[0],new Vector3(0,0,0),Quaternion.identity,transform);
                break;
        }
        cont++;
        }
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