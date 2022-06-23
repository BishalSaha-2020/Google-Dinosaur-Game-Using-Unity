using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengesScroller : MonoBehaviour
{
   
    public GameObject[] challenges;
    public float scrollSpeed=10f;
    public Transform challengeSpwanPoint;
    public float counter=0f;
    void Start()
    {
        GenerateChallenges();
    }

    void GenerateChallenges(){
        GameObject newChallenge=Instantiate(challenges[Random.Range(0,challenges.Length)],challengeSpwanPoint.position,Quaternion.identity);
        newChallenge.transform.parent=transform;
        counter=2f;
    }

    // Update is called once per frame
    void Update()
    {
       if(counter<=0){
           GenerateChallenges();
       }
       else{
           counter-=Time.deltaTime;
       }
    GameObject CurrentChild;
    for(int i=0;i<transform.childCount;i++){
        CurrentChild=transform.GetChild(i).gameObject;
        ScrollChallenge(CurrentChild);
    }

    }

    void ScrollChallenge(GameObject currentChallenge){
        currentChallenge.transform.position+=Vector3.left*scrollSpeed*Time.deltaTime;
    }
}
