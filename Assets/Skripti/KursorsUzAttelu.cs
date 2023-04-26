using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursorsUzAttelu : MonoBehaviour {
    public AudioSource skanasAvots;
    public AudioClip skanaKoAtskanot;

    public void uzbititUzAttela() {
        skanasAvots.PlayOneShot(skanaKoAtskanot);
    }
    public void kursorsNost() {
        skanasAvots.Stop();
    }
}
