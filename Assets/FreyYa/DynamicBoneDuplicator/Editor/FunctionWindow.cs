using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace FreyYa
{
	public class FunctionWindow : EditorWindow
	{
		List<GameObject> TargetList { get; set; }
		DynamicBone baseDynamicBone;
		bool forceSetup;

		internal void SetData(List<GameObject> targetList)
		{
			TargetList = targetList;
		}

		public void OnGUI()
		{
			GUILayout.BeginVertical();

			GUILayout.BeginHorizontal();
			UnityEditor.EditorGUILayout.LabelField("Source");
			baseDynamicBone = UnityEditor.EditorGUILayout.ObjectField(baseDynamicBone, typeof(DynamicBone), true) as DynamicBone;
			GUILayout.EndHorizontal();

			GUILayout.BeginHorizontal();
			forceSetup = EditorGUILayout.Toggle("Overwrite DynamicBones", forceSetup);
			GUILayout.EndHorizontal();
			GUILayout.Space(30);

			if (GUILayout.Button("Copy it!"))
			{
				BoneSetUp setup = new BoneSetUp();
				setup.CopyBones(TargetList, baseDynamicBone, forceSetup);
				this.Close();
			}

			GUILayout.EndVertical();
		}
	}
}
