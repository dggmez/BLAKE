﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLAKE.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BLAKE.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to BLAKE Function.
        /// </summary>
        internal static string BLAKEFunctionCaption {
            get {
                return ResourceManager.GetString("BLAKEFunctionCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BLAKE-224.
        /// </summary>
        internal static string BLAKEFunctionList1 {
            get {
                return ResourceManager.GetString("BLAKEFunctionList1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BLAKE-256.
        /// </summary>
        internal static string BLAKEFunctionList2 {
            get {
                return ResourceManager.GetString("BLAKEFunctionList2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BLAKE-384.
        /// </summary>
        internal static string BLAKEFunctionList3 {
            get {
                return ResourceManager.GetString("BLAKEFunctionList3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BLAKE-512.
        /// </summary>
        internal static string BLAKEFunctionList4 {
            get {
                return ResourceManager.GetString("BLAKEFunctionList4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the BLAKE hash function.
        /// </summary>
        internal static string BLAKEFunctionTooltip {
            get {
                return ResourceManager.GetString("BLAKEFunctionTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input stream.
        /// </summary>
        internal static string InputDataStreamCaption {
            get {
                return ResourceManager.GetString("InputDataStreamCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input data to be hashed.
        /// </summary>
        internal static string InputDataStreamTooltip {
            get {
                return ResourceManager.GetString("InputDataStreamTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output data.
        /// </summary>
        internal static string OutputDataCaption {
            get {
                return ResourceManager.GetString("OutputDataCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hash value.
        /// </summary>
        internal static string OutputDataTooltip {
            get {
                return ResourceManager.GetString("OutputDataTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BLAKE.
        /// </summary>
        internal static string PluginCaption {
            get {
                return ResourceManager.GetString("PluginCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BLAKE hash function.
        /// </summary>
        internal static string PluginTooltip {
            get {
                return ResourceManager.GetString("PluginTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Salt.
        /// </summary>
        internal static string SaltDataCaption {
            get {
                return ResourceManager.GetString("SaltDataCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must be 16 bytes for BLAKE-224 and BLAKE-256, and 32 bytes for BLAKE-384 and BLAKE-512.
        /// </summary>
        internal static string SaltDataTooltip {
            get {
                return ResourceManager.GetString("SaltDataTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use salt.
        /// </summary>
        internal static string UseSaltCaption {
            get {
                return ResourceManager.GetString("UseSaltCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check if you want to use a salt.
        /// </summary>
        internal static string UseSaltTooltip {
            get {
                return ResourceManager.GetString("UseSaltTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: Wrong salt size. Salt size must be {0} bytes.
        /// </summary>
        internal static string WrongSaltSizeErrorMessage {
            get {
                return ResourceManager.GetString("WrongSaltSizeErrorMessage", resourceCulture);
            }
        }
    }
}