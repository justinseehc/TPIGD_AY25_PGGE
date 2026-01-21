using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PGGE.Patterns;

public enum PlayerStateType
{
    MOVEMENT = 0,
    ATTACK,
    RELOAD,
}

public class PlayerState : FSMState
{
    protected Player mPlayer = null;
    public PlayerState(Player player) : base() {
        mPlayer = player;
        mFsm = mPlayer.mFsm;
    }

    public override void Enter()
    {
        base.Enter();
    }
    public override void Exit()
    {
        base.Exit();
    }
    public override void Update()
    {
        base.Update();
    }
    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }
}
public class PlayerState_ATTACK : PlayerState
{
    public PlayerState_ATTACK(Player player) : base(player)
    {
        mId = (int)PlayerStateType.ATTACK;
    }
}

public class PlayerState_RELOAD : PlayerState
{
    public PlayerState_RELOAD(Player player) : base(player)
    {
        mId = (int)PlayerStateType.RELOAD;
    }
}

public class PlayerState_MOVEMENT : PlayerState
{
    public PlayerState_MOVEMENT(Player player) : base(player) 
    { 
        mId = (int)PlayerStateType.MOVEMENT;
    }

    public override void Enter()
    {
        base.Enter();
    }
    public override void Exit()
    {
        base.Exit();
    }
    public override void Update()
    {
        base.Update();
        mPlayer.Move(); // call the move function in PlayerMovement.cs
        for (int i = 0; i < mPlayer.mAttackButtons.Length; ++i)
        {
            if (mPlayer.mAttackButtons[i])
            {
                if (mPlayer.mBulletsInMagazine > 0)
                {
                    PlayerState_ATTACK attack =
                        (PlayerState_ATTACK)mFsm.GetState(
                            (int)PlayerStateType.ATTACK);

                    //attack.AttackID = i;
                    mPlayer.mFsm.SetCurrentState((int)PlayerStateType.ATTACK);
                }
                else
                {
                    Debug.Log("No more ammo left");
                }
            }
        }
    }
    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }
}