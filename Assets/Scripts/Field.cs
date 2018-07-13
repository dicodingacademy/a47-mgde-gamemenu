using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Field : MonoBehaviour {
	
	// input nama Anda pada field
	public InputField nama;
	
	// input hewan kesukaan pada field
	public InputField hewan;
	
	// menampilkan teks
	public Text teks;

	public void TeksField () {
		if (nama.text=="" || hewan.text=="") {
			teks.text = "Lengkapilah kolom terlebih dahulu...";
		}
		else {
			teks.text = "Namaku " + nama.text + ", dan Hewan kesukaanku " + hewan.text;
		}
	}
}
