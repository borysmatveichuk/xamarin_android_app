﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharedClassLibraryCSharp.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SharedClassLibraryCSharp.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;id&quot;: &quot;1&quot;,
        ///    &quot;question&quot;: &quot;What is your name?&quot;,
        ///    &quot;inputType&quot;: &quot;text&quot;,
        ///    &quot;validator&quot;: &quot;[A-Za-z ]&quot;,
        ///    &quot;points&quot;: 3,
        ///    &quot;next&quot;: &quot;2&quot;
        ///  },
        ///  {
        ///    &quot;id&quot;: &quot;2&quot;,
        ///    &quot;question&quot;: &quot;What is your sex?&quot;,
        ///    &quot;inputType&quot;: &quot;select&quot;,
        ///    &quot;answers&quot;: [
        ///      {
        ///        &quot;id&quot;: &quot;man&quot;,
        ///        &quot;content&quot;: &quot;Man&quot;,
        ///        &quot;points&quot;: 4,
        ///        &quot;next&quot;: &quot;3&quot;
        ///      },
        ///      {
        ///        &quot;id&quot;: &quot;women&quot;,
        ///        &quot;content&quot;: &quot;Woman&quot;,
        ///        &quot;points&quot;: 4,
        ///        &quot;next&quot;: &quot;3&quot;
        ///      },
        ///      {
        ///        &quot;id [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Questions_json {
            get {
                return ResourceManager.GetString("Questions_json", resourceCulture);
            }
        }
    }
}