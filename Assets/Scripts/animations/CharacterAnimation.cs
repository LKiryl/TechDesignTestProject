using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    
    [SerializeField] private bool _isStartPlaying = false;

    private static readonly int JUMP_HASH = Animator.StringToHash("Jump");
    private static readonly int RUN_HASH = Animator.StringToHash("Run");
    private Animator _animator; 
    private void Start()
    {
        _animator = GetComponent<Animator>();
        if (!_isStartPlaying) { return; }      
        _animator.Play(JUMP_HASH, 0 ,0f);
    }

    public void RunAnimation()
    {
        _animator.Play(RUN_HASH, 0, 0f);
    }
}
