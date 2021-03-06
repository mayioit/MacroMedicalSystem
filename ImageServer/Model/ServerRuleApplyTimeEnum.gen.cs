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

// This file is auto-generated by the Macro.Model.SqlServer.CodeGenerator project.

namespace Macro.ImageServer.Model
{
    using System;
    using System.Collections.Generic;
    using Macro.ImageServer.Model.EntityBrokers;
    using Macro.ImageServer.Enterprise;
    using System.Reflection;

[Serializable]
public partial class ServerRuleApplyTimeEnum : ServerEnum
{
      #region Private Static Members
      private static readonly ServerRuleApplyTimeEnum _SopReceived = GetEnum("SopReceived");
      private static readonly ServerRuleApplyTimeEnum _SopProcessed = GetEnum("SopProcessed");
      private static readonly ServerRuleApplyTimeEnum _SeriesProcessed = GetEnum("SeriesProcessed");
      private static readonly ServerRuleApplyTimeEnum _StudyProcessed = GetEnum("StudyProcessed");
      private static readonly ServerRuleApplyTimeEnum _StudyArchived = GetEnum("StudyArchived");
      private static readonly ServerRuleApplyTimeEnum _StudyRestored = GetEnum("StudyRestored");
      private static readonly ServerRuleApplyTimeEnum _SopEdited = GetEnum("SopEdited");
      #endregion

      #region Public Static Properties
      /// <summary>
      /// Apply rule when a SOP Instance has been received
      /// </summary>
      public static ServerRuleApplyTimeEnum SopReceived
      {
          get { return _SopReceived; }
      }
      /// <summary>
      /// Apply rule when a SOP Instance has been processed
      /// </summary>
      public static ServerRuleApplyTimeEnum SopProcessed
      {
          get { return _SopProcessed; }
      }
      /// <summary>
      /// Apply rule when a Series is initially processed
      /// </summary>
      public static ServerRuleApplyTimeEnum SeriesProcessed
      {
          get { return _SeriesProcessed; }
      }
      /// <summary>
      /// Apply rule after a Study has been processed
      /// </summary>
      public static ServerRuleApplyTimeEnum StudyProcessed
      {
          get { return _StudyProcessed; }
      }
      /// <summary>
      /// Apply rule after a Study is archived
      /// </summary>
      public static ServerRuleApplyTimeEnum StudyArchived
      {
          get { return _StudyArchived; }
      }
      /// <summary>
      /// Apply rule after a Study has been restored
      /// </summary>
      public static ServerRuleApplyTimeEnum StudyRestored
      {
          get { return _StudyRestored; }
      }
      /// <summary>
      /// Apply rule when a SOP Instance is edited
      /// </summary>
      public static ServerRuleApplyTimeEnum SopEdited
      {
          get { return _SopEdited; }
      }

      #endregion

      #region Constructors
      public ServerRuleApplyTimeEnum():base("ServerRuleApplyTimeEnum")
      {}
      #endregion
      #region Public Members
      public override void SetEnum(short val)
      {
          ServerEnumHelper<ServerRuleApplyTimeEnum, IServerRuleApplyTimeEnumBroker>.SetEnum(this, val);
      }
      static public List<ServerRuleApplyTimeEnum> GetAll()
      {
          return ServerEnumHelper<ServerRuleApplyTimeEnum, IServerRuleApplyTimeEnumBroker>.GetAll();
      }
      static public ServerRuleApplyTimeEnum GetEnum(string lookup)
      {
          return ServerEnumHelper<ServerRuleApplyTimeEnum, IServerRuleApplyTimeEnumBroker>.GetEnum(lookup);
      }
      #endregion
}
}
