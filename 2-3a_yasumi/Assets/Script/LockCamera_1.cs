using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[ExecuteInEditMode]
[SaveDuringPlay]
[AddComponentMenu("")]
public class LockCamera_1 : CinemachineExtension
{
    [Tooltip("カメラのY.Z座標を固定する値")]
    public float m_YPosition =-0.11f;
    //public  float m_ZPosition = -1.258089f;



    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            pos.y = m_YPosition;
            //pos.z = m_ZPosition;
            state.RawPosition = pos;
        }
    }

}