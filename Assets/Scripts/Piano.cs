using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    public AudioClip[] audioClip;
    private AudioSource audioSource;

    public Transform[] notesW;
    public Transform[] notesB;

    private void Start(){
        Notes.toneName+=PlaySound;
        audioSource=GetComponent<AudioSource>();
    }
    private void OnDestroy(){
        Notes.toneName-=PlaySound;
    }

    private void Update(){
        if(Input.GetMouseButtonUp(0)){
             for(int i=0; i<notesW.Length;i++){
                  notesW[i].localScale=new Vector3(8,4,1);
                 }
             for(int j=0; j<notesB.Length;j++){
                 notesB[j].localScale=new Vector3(5,4,1);
                 }
        }
    }
    public void PlaySound(string name){
        switch(name){
            case "w1":
            audioSource.PlayOneShot(audioClip[0]);
            notesW[0].localScale=pos();
            break;
            case "w2":
            audioSource.PlayOneShot(audioClip[1]);
            notesW[1].localScale=pos();
            break;
            case "w3":
            audioSource.PlayOneShot(audioClip[2]);
            notesW[2].localScale=pos();
            break;
            case "w4":
            audioSource.PlayOneShot(audioClip[3]);
            notesW[3].localScale=pos();
            break;
            case "w5":
            audioSource.PlayOneShot(audioClip[4]);
            notesW[4].localScale=pos();
            break;
            case "w6":
            audioSource.PlayOneShot(audioClip[5]);
            notesW[5].localScale=pos();
            break;
            case "w7":
            audioSource.PlayOneShot(audioClip[6]);
            notesW[6].localScale=pos();
            break;
            case "w8":
            audioSource.PlayOneShot(audioClip[7]);
            notesW[7].localScale=pos();
            break;
            case "w9":
            audioSource.PlayOneShot(audioClip[8]);
            notesW[8].localScale=pos();
            break;
            case "w10":
            audioSource.PlayOneShot(audioClip[9]);
            notesW[9].localScale=pos();
            break;
            case "w11":
            audioSource.PlayOneShot(audioClip[10]);
            notesW[10].localScale=pos();
            break;
            case "w12":
            audioSource.PlayOneShot(audioClip[11]);
            notesW[11].localScale=pos();
            break;
            case "w13":
            audioSource.PlayOneShot(audioClip[12]);
            notesW[12].localScale=pos();
            break;
            case "w14":
            audioSource.PlayOneShot(audioClip[13]);
            notesW[13].localScale=pos();
            break;
            case "b1":
            audioSource.PlayOneShot(audioClip[14]);
            notesB[0].localScale=pos1();
            break;
            case "b2":
            audioSource.PlayOneShot(audioClip[15]);
           notesB[1].localScale=pos1();
            break;
            case "b3":
            audioSource.PlayOneShot(audioClip[16]);
            notesB[2].localScale=pos1();
            break;
            case "b4":
            audioSource.PlayOneShot(audioClip[17]);
            notesB[3].localScale=pos1();
            break;
            case "b5":
            audioSource.PlayOneShot(audioClip[18]);
            notesB[4].localScale=pos1();
            break;
            case "b6":
            audioSource.PlayOneShot(audioClip[19]);
            notesB[5].localScale=pos1();
            break;
            case "b7":
            audioSource.PlayOneShot(audioClip[20]);
            notesB[6].localScale=pos1();
            break;
            case "b8":
            audioSource.PlayOneShot(audioClip[21]);
            notesB[7].localScale=pos1();
            break;
            case "b9":
            audioSource.PlayOneShot(audioClip[22]);
           notesB[8].localScale=pos1();
            break;
            case "b10":
            audioSource.PlayOneShot(audioClip[23]);
            notesB[9].localScale=pos1();
            break;
        }
    }

    private Vector3 pos(){
        return new Vector3(7.95f,3.95f,0.95f);
    }

    private Vector3 pos1(){
        return new Vector3(4.95f,3.95f,0.95f);
    }
}
