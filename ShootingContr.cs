using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//стрельба и вывод количества убитых монстров
public class ShootingContr : MonoBehaviour
{
    public Camera cam;
    [SerializeField] TextMeshProUGUI kills;
    public float range=100f;
    public ParticleSystem partic;
    int score=0;
    void Start()
    {
        
    }

    //Raycast куда-то надо
    void Update()
    {
        Debug.DrawRay(cam.transform.position,cam.transform.forward*100f,Color.green);
        RaycastHit hit;
        if(Input.GetButtonDown("Fire1"))
        {
            partic.Play();
            if(Physics.Raycast(cam.transform.position,cam.transform.forward,out hit,100)){
                if(hit.transform.gameObject.tag=="enemy"){
                    Destroy(hit.transform.gameObject);
                    score=score+1;
                    // kills.text=score;
                }
            }
        }
    }
}
