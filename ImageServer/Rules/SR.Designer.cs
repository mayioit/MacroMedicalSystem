﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Macro.ImageServer.Rules {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Macro.ImageServer.Rules.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Attempted to autoroute to Device {0} with autoroute support disabled on partition {1} 的本地化字符串。
        /// </summary>
        internal static string AlertAutoRouteDestinationAEDisabled {
            get {
                return ResourceManager.GetString("AlertAutoRouteDestinationAEDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Attempted to autoroute to unknown device &apos;{0}&apos; on partition &apos;{1}&apos; 的本地化字符串。
        /// </summary>
        internal static string AlertAutoRouteUnknownDestination {
            get {
                return ResourceManager.GetString("AlertAutoRouteUnknownDestination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Auto Route Rule 的本地化字符串。
        /// </summary>
        internal static string AlertComponentAutorouteRule {
            get {
                return ResourceManager.GetString("AlertComponentAutorouteRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Data Access Rule 的本地化字符串。
        /// </summary>
        internal static string AlertComponentDataAccessRule {
            get {
                return ResourceManager.GetString("AlertComponentDataAccessRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Server Rules 的本地化字符串。
        /// </summary>
        internal static string AlertComponentRules {
            get {
                return ResourceManager.GetString("AlertComponentRules", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Attempted to Grant Access to unknown Authority Group OID &apos;{0}&apos; on partition &apos;{1}&apos; 的本地化字符串。
        /// </summary>
        internal static string AlertDataAccessUnknownAuthorityGroup {
            get {
                return ResourceManager.GetString("AlertDataAccessUnknownAuthorityGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Bad server rule configuration: specified tag &apos;{0}&apos; is invalid 的本地化字符串。
        /// </summary>
        internal static string AlertRuleInvalid {
            get {
                return ResourceManager.GetString("AlertRuleInvalid", resourceCulture);
            }
        }
    }
}