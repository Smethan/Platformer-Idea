using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScreenScript : MonoBehaviour {

	private bool loadScene = false;

	private int scene;
	private Text loadingText;
	private string[] FlavorText;
	private int RandSeed;


	// Updates once per frame
	void Awake() {
		FlavorText = new string[6];
		FlavorText [0] = "Putting out Fires...";
		FlavorText [1] = "Refilling Water Buckets...";
		FlavorText [2] = "Purchasing Fire Blankets...";
		FlavorText [3] = "Checking Fire Extinguishers...";
		FlavorText [4] = "Eating Donuts...";
		FlavorText [5] = "Petting Dalmatians...";
		scene = SceneManager.GetActiveScene ().buildIndex + 1;
		loadingText = GetComponent<Text> ();
		RandSeed = Random.Range (0, 5);
	}
	void Update() {

		// If the player has pressed the space bar and a new scene is not loading yet...

		if (loadScene == false) {
			// ...set the loadScene boolean to true to prevent loading a new scene more than once...
			loadScene = true;

			// ...change the instruction text to read "Loading..."
			loadingText.text = "Loading...";

			// ...and start a coroutine that will load the desired scene.
			//if (scene < SceneManager.sceneCountInBuildSettings) {
			//	StartCoroutine (LoadNewScene ());
			//} else {
			//	scene = 0;
			//	StartCoroutine (LoadNewScene ());
			//}
			StartCoroutine (LoadNewScene ());
		}
		// If the new scene has started loading...
		if (loadScene == true) {
			//Debug.Log (FlavorText [0]);

			//loadingText.text = FlavorText [RandSeed];
			// ...then pulse the transparency of the loading text to let the player know that the computer is still working.
			loadingText.color = new Color(loadingText.color.r, loadingText.color.g, loadingText.color.b, Mathf.PingPong(Time.time, 1));


		}

	}


	// The coroutine runs on its own at the same time as Update() and takes an integer indicating which scene to load.
	IEnumerator LoadNewScene() {

		// This line waits for 3 seconds before executing the next line in the coroutine.
		// This line is only necessary for this demo. The scenes are so simple that they load too fast to read the "Loading..." text.
		yield return new WaitForSeconds(3);

		// Start an asynchronous operation to load the scene that was passed to the LoadNewScene coroutine.
		AsyncOperation async = Application.LoadLevelAsync(scene);

		// While the asynchronous operation to load the new scene is not yet complete, continue waiting until it's done.
		while (!async.isDone) {
			yield return null;
		}

	}

}
