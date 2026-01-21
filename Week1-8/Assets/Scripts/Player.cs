using PGGE.Patterns;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector]
    public FSM mFsm = new FSM();
    public Animator mAnimator;
    public PlayerMovement mPlayerMovement;

    public bool[] mAttackButtons = new bool[3]; // store an array of which Fire button is clicked
    public int mBulletsInMagazine = 40; // to count of bullets in the magazine

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mFsm.Add(new PlayerState_MOVEMENT(this)); // add a movement state to the FSM
        mFsm.SetCurrentState((int)PlayerStateType.MOVEMENT); //set movement as current active state
    }

    // Update is called once per frame
    void Update()
    {
        mFsm.Update();

        if (Input.GetButton("Fire1"))
        {
            mAttackButtons[0] = true;
            mAttackButtons[1] = false;
            mAttackButtons[2] = false;
        }
        else
        {
            mAttackButtons[0] = false;
        }

        if (Input.GetButton("Fire2"))
        {
            mAttackButtons[0] = false;
            mAttackButtons[1] = true;
            mAttackButtons[2] = false;
        }
        else
        {
            mAttackButtons[1] = false;
        }

        if (Input.GetButton("Fire3"))
        {
            mAttackButtons[0] = false;
            mAttackButtons[1] = false;
            mAttackButtons[2] = true;
        }
        else
        {
            mAttackButtons[2] = false;
        }
    }

    public void Move()
    {
        mPlayerMovement.HandleInputs();
        mPlayerMovement.Move();
    }
}
