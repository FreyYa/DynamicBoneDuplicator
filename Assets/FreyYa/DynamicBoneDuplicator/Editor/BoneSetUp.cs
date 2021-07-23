using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace FreyYa
{
	public class BoneSetUp : MonoBehaviour
	{
		internal void CopyBones(List<GameObject> targetList, DynamicBone baseDynamicBone, bool forceSetup)
		{
			foreach (var targetObject in targetList)
			{
				var bones = targetObject.GetComponents<DynamicBone>();
				if (bones != null && forceSetup)
				{
					foreach (var bone in bones)
					{
						DestroyImmediate(bone);//덮어씌울땐 우선 기존의 다이나믹본을 모두 제거한다
					}
				}
				var target = targetObject.AddComponent<DynamicBone>();

				CopyDynamicBoneParameter(target, baseDynamicBone, targetObject.GetComponent<Transform>());
			}
		}

		private void CopyDynamicBoneParameter(DynamicBone target, DynamicBone ori, Transform transform)
		{
			target.m_Root = transform;
			target.m_UpdateRate = ori.m_UpdateRate;
			target.m_UpdateMode = ori.m_UpdateMode;
			target.m_Damping = ori.m_Damping;
			target.m_DampingDistrib = ori.m_DampingDistrib;
			target.m_Elasticity = ori.m_Elasticity;
			target.m_ElasticityDistrib = ori.m_ElasticityDistrib;
			target.m_Stiffness = ori.m_Stiffness;
			target.m_StiffnessDistrib = ori.m_StiffnessDistrib;
			target.m_Inert = ori.m_Inert;
			target.m_InertDistrib = ori.m_InertDistrib;
			target.m_Friction = ori.m_Friction;
			target.m_FrictionDistrib = ori.m_FrictionDistrib;
			target.m_Radius = ori.m_Radius;
			target.m_RadiusDistrib = ori.m_RadiusDistrib;
			target.m_EndLength = ori.m_EndLength;
			target.m_EndOffset = ori.m_EndOffset;
			target.m_Gravity = ori.m_Gravity;
			target.m_Force = ori.m_Force;
			target.m_Colliders = ori.m_Colliders;
			target.m_Exclusions = ori.m_Exclusions;
			target.m_FreezeAxis = ori.m_FreezeAxis;
			target.m_DistantDisable = ori.m_DistantDisable;
			target.m_DistanceToObject = ori.m_DistanceToObject;
			target.m_ReferenceObject = ori.m_ReferenceObject;
		}
	}
}