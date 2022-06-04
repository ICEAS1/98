using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

//движение через character controller, время, hp.
public class BodyContr : MonoBehaviour
{   
    [SerializeField] TextMeshProUGUI sec;
    public Transform playerBody;
    public CharacterController contr;
    float speed=10f;
    int time = 20;
    int hp = 100;
    

    
    void Start()
    {
        playerBody=GetComponent<Transform>();
        contr = GetComponent<CharacterController>();
        InvokeRepeating("timeMinus",1,1);
    }

    void timeMinus()
    {
        time=time-1;
        // time.ToString(sec);
        // sec.text=time;
        print(time);
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        
        contr.Move(playerBody.forward*vertical*speed*Time.deltaTime);
        contr.Move(playerBody.right*horizontal*speed*Time.deltaTime);

        if(playerBody.tag=="enemy"){
            hp=hp-1;
            print(hp);
        }
        if(time==0){
            CancelInvoke();
        }
    }


   
}
