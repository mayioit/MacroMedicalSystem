#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.ClearCanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using System.IO;
using Macro.Common;

namespace Macro.ImageViewer.Utilities.StudyFilters.Columns
{
	[ExtensionOf(typeof(SpecialColumnExtensionPoint))]
	public class DriveFormatColumn : SpecialColumn<string>, ILexicalSortableColumn
	{
		public const string KEY = "DriveFormat";

		public DriveFormatColumn() : base(SR.DriveFormat, KEY) { }

		public override string GetTypedValue(IStudyItem item)
		{
			DriveInfo drive = DriveColumn.GetDriveInfo(item);
			if (drive == null)
				return string.Empty;
			return drive.DriveFormat;
		}

		public override bool Parse(string input, out string output)
		{
			output = input;
			return true;
		}

		public override int Compare(IStudyItem x, IStudyItem y)
		{
			return this.CompareLexically(x, y);
		}

		public int CompareLexically(IStudyItem x, IStudyItem y)
		{
			return this.GetTypedValue(x).CompareTo(this.GetTypedValue(y));
		}
	}
}