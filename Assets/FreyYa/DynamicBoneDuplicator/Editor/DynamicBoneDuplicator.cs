using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace FreyYa
{
	public class DynamicBoneDuplicator
	{
		private const string MenuItemName = "GameObject/DynamicBoneDuplicator";
		private const int MenuItemPriority = 48;
		[MenuItem(MenuItemName, false, MenuItemPriority)]
		public static void Run()
		{
			List<GameObject> targetList = new List<GameObject>();
			foreach (var target in Selection.gameObjects)
			{
				targetList.Add(target);
			}
			var window = EditorWindow.GetWindow<FunctionWindow>("DynamicBone Duplicator");
			window.SetData(targetList);
		}
	}

}