using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    private Animator _animator;					// Reference to the player's animator component.

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {

    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 20), "站立"))
        {
            _animator.Play("Idle");
        }

        if (GUI.Button(new Rect(120, 10, 100, 20), "走路"))
        {
            _animator.Play("Run");
        }

        if (GUI.Button(new Rect(230, 10, 100, 20), "跳"))
        {
            _animator.Play("Jump");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
