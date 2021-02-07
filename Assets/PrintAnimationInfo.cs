using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAnimationInfo : MonoBehaviour
{
    Animator m_Animator;
    string m_ClipName;

    // Start is called before the first frame update
    const string animBaseLayer = "Base Layer";
    private AnimationClip m_CurrentClip;

    void Start()
    {
        //Get them_Animator, which you attach to the GameObject you intend to animate.
        m_Animator = gameObject.GetComponent<Animator>();
        Debug.Log($"clip name {m_ClipName} ");
    }


    // Update is called once per frame
    void Update()
    {
        var currentClipInfo = this.m_Animator.GetCurrentAnimatorClipInfo(0);

        //Access the current length of the clip

        AnimatorStateInfo animState = m_Animator.GetCurrentAnimatorStateInfo(0);
        //Get the current animation hash

        //Convert the animation hash to animation clip
        AnimationClip clip = currentClipInfo[0].clip;
        m_ClipName = currentClipInfo[0].clip.name;
        //Get the current time
        float currentTime = clip.length * animState.normalizedTime;

        //if (m_ClipName == "crawlMover" && currentTime < 10)
        //{
        //    Time.timeScale = 20f;
        //}
        //else
        //{
        //    Time.timeScale = 0.5f;
        //}

        Debug.Log($"clip name {m_ClipName} time: {currentTime}");
    }
    void OnGUI()
    {
        //Output the current Animation name and length to the screen
        GUI.Label(new Rect(0, 0, 200, 20), "Clip Name : " + m_ClipName);
    }
}