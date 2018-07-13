using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {

	// waktu delay untuk load scene
	[SerializeField] private float delayLoading = 3f;
	
	// nama scene untuk pindah scene yang diinputkan pada Inspector
	[SerializeField] private string namaScene;

	private float timeElapsed;
	
	private void Update () {
		timeElapsed += Time.deltaTime;
		
		if (timeElapsed > delayLoading) {
			SceneManager.LoadScene(namaScene);
		}
	}
}
