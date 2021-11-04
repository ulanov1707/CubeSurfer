using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollecterCube : MonoBehaviour
{

    [SerializeField]float heightOfMain;
    [SerializeField] AudioSource SoundSource;
    [SerializeField] AudioClip clipUp, clipDown,clipDimond;
    ParticleSystem particle;

    GameObject MainCube;
    public  int ScoreBoxes = 0;
    public  int ScoreDimonds = 0;

    private void Start()
    {
        MainCube = GameObject.Find("Main Cube");
        if (MainCube == null) { Debug.Log("Main Cube isnt Found"); }
        heightOfMain = 0;
        if (SoundSource == null) { Debug.Log("CollectorCube:SoundSource isnt set!"); }
        particle = GetComponent<ParticleSystem>();
    }
    
    private void Update()
    {
    
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CollectCube") 
        {
            CollectableCube cubeCollected = other.GetComponent<CollectableCube>();

            if (cubeCollected.GetCollected() == false ) {

                
                heightOfMain++; 
                cubeCollected.SetCollectedTrue();
                other.transform.parent = MainCube.transform;
                SetHeight(0.2f);
                CollectorHeightDecrease();
                other.transform.localPosition = new Vector3(0, 0 - heightOfMain, 0);
                PlayAudio(clipUp);
                particle.Play();

            }
        }
    }

    public void DecresceHeight() {        
        heightOfMain--;
        SetHeight(0.2f);
        CollectorHeightIncrease();
    }

    private void CollectorHeightDecrease() //Decreases height of collector
    {
        transform.localPosition = new Vector3(0, 0 - heightOfMain, 1.3f);
    }
    public void CollectorHeightIncrease()//increases height of Collector
    {
        transform.localPosition = new Vector3(0, transform.localPosition.y + 1 , 1.3f);
    }
   
    void SetHeight(float speed)//Sets Height of Main
    {
        StartCoroutine(WaitOneFrame());
    }

   
    IEnumerator WaitOneFrame() {

        yield return new WaitForEndOfFrame();
         MainCube.transform.position = new Vector3(transform.position.x, (heightOfMain), transform.position.z);
         

    }

    public void PlayAudio(AudioClip newClip) {
        SoundSource.clip = newClip;
        SoundSource.Play();
    }
    public AudioClip GetDimondClip() {
        return clipDimond;
    }
    public AudioClip GetDownClip()
    {
        return clipDown;
    }
}
