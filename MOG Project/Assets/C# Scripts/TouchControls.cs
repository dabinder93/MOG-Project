using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour {

    private PlayerController player;


    // Use this for initialization
    void Start() {
        player = FindObjectOfType<PlayerController>();

    }

    public void LeftArrow(){
        player.Move(-1);
        
    }

    public void RightArrow(){
        player.Move(1);
    }

    public void Jump(){
        player.Jump();
    }

    public void UnpressedArrow() {
        player.Move(0);
    }

}
