using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using HutongGames.PlayMaker;

public class SaveLoadManager : MonoBehaviour{


	public static void SaveData(int[] Data) {
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream stream = new FileStream (Application.persistentDataPath + "/cantedit.lol", FileMode.Create);

		bf.Serialize (stream, Data);
		stream.Close ();
	}

	public static int[] Load() {
		if (File.Exists (Application.persistentDataPath + "/cantedit.lol")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream stream = new FileStream (Application.persistentDataPath + "/cantedit.lol", FileMode.Open);

			int[] SavDat = bf.Deserialize (stream) as int[];
			stream.Close ();
			return SavDat;
		} else {
			Debug.LogError ("No file found!");
			return new int[2];
		}
	}
}
