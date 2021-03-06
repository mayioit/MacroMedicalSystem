#region License

// Copyright (c) 2011, ClearCanvas Inc.
// All rights reserved.
// http://www.ClearCanvas.ca
//
// This software is licensed under the Open Software License v3.0.
// For the complete license, see http://www.ClearCanvas.ca/OSLv3.0

#endregion

using System.Runtime.Serialization;
using Macro.Web.Common;

namespace Macro.ImageViewer.Web.Common.Messages
{
    [DataContract(Namespace = ViewerNamespace.Value)]
    public class SetLayoutActionMessage : Message
    {
        [DataMember(IsRequired = true)]
        public int Rows { get; set; }

        [DataMember(IsRequired = true)]
        public int Columns { get; set; }
    }
}
