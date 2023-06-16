using System;
using System.Reflection;
using UnityEngine;
using ColossalFramework.UI;
using ICities;

namespace JP_AirportNameList
{
	public class JP_AirportNameList : IUserMod
	{

		public string Name
		{
			get { return "JP Airport Name List (CNL) v1.0"; }
		}

		public string Description
		{
			get { return "Custom Name Listsを使って、DLC Airportsの空港エリア名を変更します"; }
		}

	}
}