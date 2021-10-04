using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour {

    public Rigidbody rb;
    public TankMover mover;
    public TankShooter shooter;
    //Variables for our tanks in game
    public float speed;
    public float turnSpeed;
    public float moveSpeed;
    public float health;
    public float maxHealth;
    public float fireRate;

	// Use this for initialization
	void Start () {
        //Save myself to the GameManager.
        GameManager.Instance.tanks.Add(this);
        //Load the mover
        mover = this.gameObject.GetComponent<TankMover>();
        //Load the shooter.
        shooter = this.gameObject.GetComponent<TankShooter>();
        //Load RigidBody
        rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        //Remove myself from the list.
        GameManager.Instance.tanks.Remove(this);
    }
}
