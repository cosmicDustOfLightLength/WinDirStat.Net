﻿using System;
using System.Collections.Generic;
using System.Text;
using WinDirStat.Net.Services.Structures;

namespace WinDirStat.Net.Services {
	/// <summary>A service for storing platform independent shortcuts.</summary>
	public interface IShortcutsService {

		#region File Menu

		IShortcut Open { get; }
		IShortcut Save { get; }
		IShortcut Reload { get; }
		IShortcut Close { get; }
		IShortcut Cancel { get; }
		IShortcut Elevate { get; }
		IShortcut Exit { get; }

		#endregion

		#region Context Menu/Toolbar

		IShortcut Expand { get; }
		IShortcut OpenItem { get; }
		IShortcut CopyPath { get; }
		IShortcut Explore { get; }
		IShortcut CommandPrompt { get; }
		IShortcut PowerShell { get; }
		IShortcut RefreshSelected { get; }
		IShortcut DeleteRecycle { get; }
		IShortcut DeletePermanently { get; }
		IShortcut Properties { get; }

		#endregion

		#region Options Menu

		IShortcut ShowFreeSpace { get; }
		IShortcut ShowUnknown { get; }
		IShortcut ShowTotalSpace { get; }
		IShortcut ShowFileTypes { get; }
		IShortcut ShowTreemap { get; }
		IShortcut ShowToolBar { get; }
		IShortcut ShowStatusBar { get; }
		IShortcut Configure { get; }

		#endregion

		#region Other

		IShortcut EmptyRecycleBin { get; }

		#endregion
	}
}
