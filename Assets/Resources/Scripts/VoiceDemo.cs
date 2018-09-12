using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings("0.1");
	}

	void OnJoinedLobby() {
		Debug.Log("ロビーへ入室しました");
		RoomOptions options = new RoomOptions() {
			IsVisible = false,
			MaxPlayers = 4
		};
		PhotonNetwork.JoinOrCreateRoom("room", options, TypedLobby.Default);
	}

	void OnJoinedRoom() {
		Debug.Log("ルームへ入室しました");
		PhotonNetwork.Instantiate(
			"cube",	
			Vector3.zero,
			Quaternion.identity,
			0
		);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
